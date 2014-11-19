﻿// Copyright (c) 2014 Silicon Studio Corp. (http://siliconstudio.co.jp)
// This file is distributed under GPL v3. See LICENSE.md for details.
using System;

using SiliconStudio.Core;
using SiliconStudio.Core.Mathematics;
using SiliconStudio.Core.Serialization.Assets;
using SiliconStudio.Paradox.Graphics;

namespace SiliconStudio.Paradox.PostEffects
{
    /// <summary>
    /// Post effect base class.
    /// </summary>
    public abstract class PostEffectBase : ComponentBase
    {
        private readonly Texture[] inputTextures;
        private int maxInputTextureIndex;

        private DepthStencilBuffer outputDepthStencilBuffer;

        private RenderTarget outputRenderTargetView;

        private RenderTarget[] outputRenderTargetViews;

        /// <summary>
        /// Initializes a new instance of the <see cref="PostEffectBase" /> class.
        /// </summary>
        /// <param name="context">The context.</param>
        /// <param name="name">The name.</param>
        /// <exception cref="System.ArgumentNullException">context</exception>
        protected PostEffectBase(PostEffectContext context, string name = null) : base(name)
        {
            if (context == null) throw new ArgumentNullException("context");

            Context = context;
            GraphicsDevice = Context.GraphicsDevice;
            Assets = context.Services.GetSafeServiceAs<AssetManager>();
            Name = name ?? GetType().Name;
            Enabled = true;
            inputTextures = new Texture[128];
            maxInputTextureIndex = -1;
        }

        /// <summary>
        /// Gets or sets a value indicating whether this post effect is enabled.
        /// </summary>
        /// <value><c>true</c> if enabled; otherwise, <c>false</c>.</value>
        public bool Enabled { get; set; }

        /// <summary>
        /// Gets the context.
        /// </summary>
        /// <value>The context.</value>
        public PostEffectContext Context { get; private set; }

        /// <summary>
        /// Gets the <see cref="AssetManager"/>.
        /// </summary>
        /// <value>The content.</value>
        protected AssetManager Assets { get; private set; }

        /// <summary>
        /// Gets the graphics device.
        /// </summary>
        /// <value>The graphics device.</value>
        protected GraphicsDevice GraphicsDevice { get; private set; }

        /// <summary>
        /// Sets an input texture
        /// </summary>
        /// <param name="slot">The slot.</param>
        /// <param name="texture">The texture.</param>
        public void SetInput(int slot, Texture texture)
        {
            if (slot < 0 || slot >= inputTextures.Length)
                throw new ArgumentOutOfRangeException("slot", "slot must be in the range [0, 128[");

            inputTextures[slot] = texture;
            if (slot > maxInputTextureIndex)
            {
                maxInputTextureIndex = slot;
            }
        }

        /// <summary>
        /// Resets the input textures.
        /// </summary>
        public void ResetInputs()
        {
            maxInputTextureIndex = -1;
            Array.Clear(inputTextures, 0, inputTextures.Length);
        }

        /// <summary>
        /// Sets the render target output.
        /// </summary>
        /// <param name="view">The render target output view.</param>
        /// <param name="depthStencilBuffer">The depth stencil buffer.</param>
        /// <exception cref="System.ArgumentNullException">view</exception>
        public void SetOutput(RenderTarget view, DepthStencilBuffer depthStencilBuffer = null)
        {
            if (view == null) throw new ArgumentNullException("view");

            SetOutputInternal(view, depthStencilBuffer);
        }

        /// <summary>
        /// Sets the render target outputs.
        /// </summary>
        /// <param name="views">The render target output views.</param>
        public void SetOutput(params RenderTarget[] views)
        {
            if (views == null) throw new ArgumentNullException("views");

            SetOutputInternal(null, views);
        }

        /// <summary>
        /// Sets the render target outputs.
        /// </summary>
        /// <param name="depthStencilBuffer">The depth stencil buffer.</param>
        /// <param name="views">The render target output views.</param>
        /// <returns>PostEffectBase.</returns>
        /// <exception cref="System.ArgumentNullException">views</exception>
        public void SetOutput(DepthStencilBuffer depthStencilBuffer, params RenderTarget[] views)
        {
            if (views == null) throw new ArgumentNullException("views");

            SetOutputInternal(depthStencilBuffer, views);
        }

        /// <summary>
        /// Draws a full screen quad using iterating on each pass of this effect.
        /// </summary>
        public void Draw(string name = null)
        {
            if (!Enabled)
            {
                return;
            }

            PreDrawCore(name);
            DrawCore();
            PostDrawCore();
        }

        protected virtual void PreDrawCore(string name)
        {
            GraphicsDevice.BeginProfile(Color.Green, name ?? Name);

            if (outputRenderTargetView != null)
            {
                GraphicsDevice.SetRenderTarget(outputDepthStencilBuffer, outputRenderTargetView);
            }
            else if (outputRenderTargetViews != null)
            {
                GraphicsDevice.SetRenderTargets(outputDepthStencilBuffer, outputRenderTargetViews);
            }
        }

        protected virtual void PostDrawCore()
        {
            GraphicsDevice.EndProfile();
        }

        /// <summary>
        /// Draws this post effect for a specific pass, implementation dependent.
        /// </summary>
        protected virtual void DrawCore()
        {

        }

        protected virtual void SetOutputInternal(RenderTarget view, DepthStencilBuffer depthStencilBuffer)
        {
            outputDepthStencilBuffer = depthStencilBuffer;
            outputRenderTargetView = view;
            outputRenderTargetViews = null;
        }

        protected virtual void SetOutputInternal(DepthStencilBuffer depthStencilBuffer, params RenderTarget[] views)
        {
            outputDepthStencilBuffer = depthStencilBuffer;
            outputRenderTargetView = null;
            outputRenderTargetViews = views;
        }

        protected int GetInputCount()
        {
            return maxInputTextureIndex + 1;
        }

        protected Texture GetInput(int index)
        {
            if (index < 0 || index > maxInputTextureIndex)
            {
                throw new ArgumentOutOfRangeException("index", string.Format("Invald texture input index [{0}]. Max value is [{1}]", index, maxInputTextureIndex));
            }
            return inputTextures[index];
        }

        protected Texture GetSafeInput(int index)
        {
            var input = GetInput(index);
            if (input == null)
            {
                throw new InvalidOperationException(string.Format("Expecting texture input on slot [{0}]", index));
            }

            return input;
        }

        protected int GetOutputCount()
        {
            return outputRenderTargetView != null ? 1 : outputRenderTargetViews != null ? outputRenderTargetViews.Length : 0;
        }

        protected RenderTarget GetOutput(int index)
        {
            if (index < 0)
            {
                throw new ArgumentOutOfRangeException("index", string.Format("Invald texture outputindex [{0}] cannot be negative for effect [{1}]", index, Name));
            }

            return outputRenderTargetView ?? (outputRenderTargetViews != null ? outputRenderTargetViews[index] : null);
        }

        protected RenderTarget GetSafeOutput(int index)
        {
            var output = GetOutput(index);
            if (output == null)
            {
                throw new InvalidOperationException(string.Format("Expecting texture output on slot [{0}]", index));
            }

            return output;
        }


        public override string ToString()
        {
            return string.Format("Effect {0}", Name);
        }
    }
}