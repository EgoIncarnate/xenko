﻿// <auto-generated>
// Do not edit this file yourself!
//
// This code was generated by Paradox Shader Mixin Code Generator.
// To generate it yourself, please install SiliconStudio.Paradox.VisualStudio.Package .vsix
// and re-save the associated .pdxfx.
// </auto-generated>

using System;
using SiliconStudio.Core;
using SiliconStudio.Paradox.Rendering;
using SiliconStudio.Paradox.Rendering.Skyboxes;
using SiliconStudio.Paradox.Graphics;
using SiliconStudio.Paradox.Shaders;
using SiliconStudio.Core.Mathematics;
using Buffer = SiliconStudio.Paradox.Graphics.Buffer;

using SiliconStudio.Paradox.Rendering.Data;
using SiliconStudio.Paradox.Rendering.Materials;
namespace SiliconStudio.Paradox.Rendering.Skyboxes
{
    internal static partial class ShaderMixins
    {
        internal partial class SkyboxEffect  : IShaderMixinBuilder
        {
            public void Generate(ShaderMixinSource mixin, ShaderMixinContext context)
            {
                context.Mixin(mixin, "SkyboxShader");
                if (context.GetParam(SkyboxKeys.Shader) != null)
                {

                    {
                        var __subMixin = new ShaderMixinSource() { Parent = mixin };
                        context.PushComposition(mixin, "skyboxColor", __subMixin);
                        context.Mixin(__subMixin, context.GetParam(SkyboxKeys.Shader));
                        context.PopComposition();
                    }
                }
            }

            [ModuleInitializer]
            internal static void __Initialize__()

            {
                ShaderMixinManager.Register("SkyboxEffect", new SkyboxEffect());
            }
        }
    }
}
