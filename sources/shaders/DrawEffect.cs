﻿// Copyright (c) 2014 Silicon Studio Corp. (http://siliconstudio.co.jp)
// This file is distributed under GPL v3. See LICENSE.md for details.

using System;
using System.Collections.Generic;

using SiliconStudio.Core;
using SiliconStudio.Core.Mathematics;
using SiliconStudio.Core.Serialization.Assets;
using SiliconStudio.Paradox.Effects.Images;
using SiliconStudio.Paradox.Graphics;

using Buffer = SiliconStudio.Paradox.Graphics.Buffer;

namespace SiliconStudio.Paradox.Effects
{
    /// <summary>
    /// The base class in charge of applying and drawing an effect.
    /// </summary>
    [DataContract]
    public abstract class DrawEffect : ComponentBase
    {
        private bool isInDrawCore;

        private readonly List<GraphicsResource> scopedResources = new List<GraphicsResource>();

        private ImageScaler scaler;

        // Sub-effects needed by the DrawEffect
        private readonly List<DrawEffect> subEffects;

        /// <summary>
        /// Initializes a <see cref="DrawEffect"/>.
        /// </summary>
        protected DrawEffect(String name):
            base(name)
        {
            Enabled = true;
            Parameters = new ParameterCollection();
            subEffects = new List<DrawEffect>();
        }

        /// <summary>
        /// Initializes the <see cref="DrawEffect"/> with the given <see cref="DrawEffectContext"/>.
        /// </summary>
        protected DrawEffect() :
            this((string)null)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DrawEffect" /> class.
        /// </summary>
        /// <param name="context">The context.</param>
        /// <param name="name">The name.</param>
        protected DrawEffect(DrawEffectContext context, string name = null)
            : this(name)
        {
            Initialize(context);
        }

        /// <summary>
        /// Initializes the <see cref="DrawEffect"/> with the given <see cref="DrawEffectContext"/>.
        /// </summary>
        /// <param name="context">The context.</param>
        /// /// <exception cref="System.ArgumentNullException">context</exception>
        public virtual void Initialize(DrawEffectContext context)
        {
            if (context == null) throw new ArgumentNullException("context");
            Context = context;
            GraphicsDevice = Context.GraphicsDevice;
            Assets = context.Services.GetSafeServiceAs<AssetManager>();
            // Recursively initializes all our sub-effects
            foreach (var drawEffect in subEffects)
            {
                drawEffect.Initialize(context);
            }
        }

        /// <summary>
        /// Gets or sets a value indicating whether this post effect is enabled.
        /// </summary>
        /// <value><c>true</c> if enabled; otherwise, <c>false</c>.</value>
        [DataMember(-10)]
        public bool Enabled { get; set; }

        /// <summary>
        /// Gets the context.
        /// </summary>
        /// <value>The context.</value>
        [DataMemberIgnore]
        public DrawEffectContext Context { get; private set; }

        /// <summary>
        /// Gets the parameters.
        /// </summary>
        /// <value>The parameters.</value>
        [DataMemberIgnore]
        public ParameterCollection Parameters { get; private set; }

        /// <summary>
        /// Gets the <see cref="AssetManager"/>.
        /// </summary>
        /// <value>The content.</value>
        [DataMemberIgnore]
        protected AssetManager Assets { get; private set; }

        /// <summary>
        /// Gets the graphics device.
        /// </summary>
        /// <value>The graphics device.</value>
        [DataMemberIgnore]
        protected GraphicsDevice GraphicsDevice { get; private set; }

        /// <summary>
        /// Gets a shared <see cref="ImageScaler"/>.
        /// </summary>
        [DataMemberIgnore]
        protected ImageScaler Scaler
        {
            get
            {
                // TODO
                // return scaler ?? (scaler = Context.GetSharedEffect<ImageScaler>());
                if (scaler == null)
                {
                    scaler = new ImageScaler();
                    scaler.Initialize(Context);
                }
                return scaler;
            }
        }

        /// <summary>
        /// Resets the state of this effect.
        /// </summary>
        public virtual void Reset()
        {
            SetDefaultParameters();
        }

        /// <summary>
        /// Sets the default parameters (called at constructor time and if <see cref="Reset"/> is called)
        /// </summary>
        protected virtual void SetDefaultParameters()
        {
        }

        /// <summary>
        /// Draws a full screen quad using iterating on each pass of this effect.
        /// </summary>
        public void Draw(ParameterCollection contextParameters, string name = null)
        {
            if (!Enabled)
            {
                return;
            }

            if (Context == null)
            {
                throw new NullReferenceException("No DrawEffectContext was provided for this DrawEffect! Did you call Initialize(context)?");
            }

            PreDrawCore(name);

            // Allow scoped allocation RenderTargets
            isInDrawCore = true;
            DrawCore(contextParameters);
            isInDrawCore = false;

            // Release scoped RenderTargets
            ReleaseAllScopedResources();

            PostDrawCore();
        }

        /// <summary>
        /// Draws a full screen quad using iterating on each pass of this effect.
        /// </summary>
        public void Draw(string name = null)
        {
            Draw((ParameterCollection)null, name);
        }

        /// <summary>
        /// Draws a full screen quad using iterating on each pass of this effect.
        /// </summary>
        public void Draw(string nameFormat, params object[] args)
        {
            // TODO: this is alocating a string, we should try to not allocate here.
            Draw(string.Format(nameFormat, args));
        }

        /// <summary>
        /// Draws a full screen quad using iterating on each pass of this effect.
        /// </summary>
        public void Draw(ParameterCollection contextParameters, string nameFormat, params object[] args)
        {
            // TODO: this is alocating a string, we should try to not allocate here.
            Draw(contextParameters, string.Format(nameFormat, args));
        }

        /// <summary>
        /// Returns a <see cref="System.String" /> that represents this instance.
        /// </summary>
        /// <returns>A <see cref="System.String" /> that represents this instance.</returns>
        public override string ToString()
        {
            return string.Format("Effect {0}", Name);
        }

        /// <summary>
        /// Prepare call before <see cref="DrawCore"/>.
        /// </summary>
        /// <param name="name">The name.</param>
        protected virtual void PreDrawCore(string name)
        {
            GraphicsDevice.BeginProfile(Color.Green, name ?? Name);
        }

        /// <summary>
        /// Posts call after <see cref="DrawCore"/>
        /// </summary>
        protected virtual void PostDrawCore()
        {
            GraphicsDevice.EndProfile();
        }

        /// <summary>
        /// Draws this post effect for a specific pass, implementation dependent.
        /// </summary>
        /// <param name="contextParameters"></param>
        protected virtual void DrawCore(ParameterCollection contextParameters)
        {
        }

        /// <summary>
        /// Gets a render target with the specified description, scoped for the duration of the <see cref="DrawEffect.DrawCore"/>.
        /// </summary>
        /// <param name="description">The description of the buffer to allocate</param>
        /// <param name="viewFormat">The pixel format seen in shader</param>
        /// <returns>A new instance of texture.</returns>
        protected Buffer NewScopedBuffer(BufferDescription description, PixelFormat viewFormat = PixelFormat.None)
        {
            CheckIsInDrawCore();
            return PushScopedResource(Context.Allocator.GetTemporaryBuffer(description, viewFormat));
        }

        /// <summary>
        /// Pushes a new scoped resource to the current Draw.
        /// </summary>
        /// <param name="resource">The scoped resource</param>
        /// <returns></returns>
        protected T PushScopedResource<T>(T resource) where T: GraphicsResource
        {
            scopedResources.Add(resource);
            return resource;
        }

        private void ReleaseAllScopedResources()
        {
            foreach (var scopedResource in scopedResources)
            {
                Context.Allocator.ReleaseReference(scopedResource);
            }
            scopedResources.Clear();
        }

        /// <summary>
        /// Checks that the current execution path is between a PreDraw/PostDraw sequence and throws and exception if not.
        /// </summary>
        protected void CheckIsInDrawCore()
        {
            if (!isInDrawCore)
            {
                throw new InvalidOperationException("The method execution path is not within a DrawCore operation");
            }
        }

        protected override void Destroy()
        {
            foreach (var drawEffect in subEffects)
            {
                drawEffect.Dispose();
            }
            subEffects.Clear();

            base.Destroy();
        }

        protected T ToDispose<T>(T effect) where T : DrawEffect
        {
            if (effect == null) throw new ArgumentNullException("effect");
            subEffects.Add(effect);
            return effect;
        }
    }
}