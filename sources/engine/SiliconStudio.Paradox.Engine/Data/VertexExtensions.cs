﻿// Copyright (c) 2014 Silicon Studio Corp. (http://siliconstudio.co.jp)
// This file is distributed under GPL v3. See LICENSE.md for details.
using System;
using System.Linq;
using System.Runtime.InteropServices;
using SiliconStudio.Paradox.Effects.Data;
using SiliconStudio.Core;
using SiliconStudio.Paradox.Effects;
using SiliconStudio.Paradox.Graphics.Data;

namespace SiliconStudio.Paradox.Extensions
{
    public static class VertexExtensions
    {
        /// <summary>
        /// Extracts a selection of vertices from a vertex buffer stored in this mesh data.
        /// </summary>
        /// <param name="meshData">The mesh data.</param>
        /// <param name="vertexElementToExtract">The declaration to extract (e.g. "POSITION0"...etc.) </param>
        public static T[] GetVertexBufferData<T>(this MeshDraw meshData, params string[] vertexElementToExtract) where T : struct
        {
            var declaration = meshData.VertexBuffers[0].Declaration;

            var offsets = declaration.EnumerateWithOffsets().Where(vertexElementOffset => vertexElementToExtract.Contains(vertexElementOffset.VertexElement.SemanticAsText)).ToList();

            int expectedSize = offsets.Sum(vertexElementWithOffset => vertexElementWithOffset.Size);

            var count = meshData.VertexBuffers[0].Count;

            int outputSize = expectedSize * count;

            int checkSize = (int)(outputSize / Utilities.SizeOf<T>()) * Utilities.SizeOf<T>();
            if (checkSize != outputSize)
                throw new ArgumentException(string.Format("Size of T is not a multiple of totalSize {0}", outputSize));

            var output = new T[outputSize / Utilities.SizeOf<T>()];

            var handleOutput = GCHandle.Alloc(output, GCHandleType.Pinned);
            var ptrOutput = handleOutput.AddrOfPinnedObject();

            var handleInput = GCHandle.Alloc(meshData.VertexBuffers[0].Buffer.GetSerializationData().Content, GCHandleType.Pinned);
            var ptrInput = handleInput.AddrOfPinnedObject();

            for(int i = 0; i < count; i++)
            {
                foreach (var vertexElementWithOffset in offsets)
                {
                    Utilities.CopyMemory(ptrOutput, ptrInput + vertexElementWithOffset.Offset, vertexElementWithOffset.Size);
                    ptrOutput = ptrOutput + vertexElementWithOffset.Size;
                }
                ptrInput += declaration.VertexStride;
            }

            handleInput.Free();
            handleOutput.Free();
            return output;
        }
    }
}
