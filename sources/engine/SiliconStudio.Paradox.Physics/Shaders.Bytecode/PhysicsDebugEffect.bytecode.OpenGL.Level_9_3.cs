﻿#if SILICONSTUDIO_PARADOX_GRAPHICS_API_OPENGLCORE
//------------------------------------------------------------------------------
// <auto-generated>
//     Paradox Effect Compiler File Generated:
//     Effect [PhysicsDebugEffect]
//
//     Command Line: C:\Users\giova_000\Paradox\paradox\sources\engine\SiliconStudio.Paradox.Physics\Shaders.Bytecode\..\..\..\..\Bin\Windows-Direct3D11\SiliconStudio.Assets.CompilerApp.exe --platform=Windows --profile=Windows --output-path=C:\Users\giova_000\Paradox\paradox\sources\engine\SiliconStudio.Paradox.Physics\Shaders.Bytecode\obj\app_data --build-path=C:\Users\giova_000\Paradox\paradox\sources\engine\SiliconStudio.Paradox.Physics\Shaders.Bytecode\obj\build_app_data --package-file=Physics.pdxpkg
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SiliconStudio.Paradox.Physics 
{
    public partial class PhysicsDebugEffect
    {
        private static readonly byte[] binaryBytecode = new byte[] {
1, 192, 254, 239, 0, 2, 0, 0, 0, 18, 80, 104, 121, 115, 105, 99, 115, 68, 101, 98, 117, 103, 69, 102, 102, 101, 99, 116, 1, 28, 221, 253, 235, 183, 220, 136, 149, 147, 95, 203, 121, 110, 88, 107, 51, 10, 83, 104, 97, 100, 101, 114, 66, 97, 115, 101, 1, 106, 12, 112, 201, 155, 82, 245, 182, 
20, 34, 125, 144, 52, 118, 27, 28, 0, 0, 2, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 34, 83, 104, 97, 100, 101, 114, 66, 97, 115, 101, 46, 80, 97, 114, 97, 100, 111, 120, 70, 108, 105, 112, 82, 101, 110, 100, 101, 114, 116, 97, 114, 103, 101, 116, 0, 0, 0, 0, 0, 23, 80, 97, 
114, 97, 100, 111, 120, 70, 108, 105, 112, 82, 101, 110, 100, 101, 114, 116, 97, 114, 103, 101, 116, 0, 0, 0, 0, 3, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 1, 0, 0, 0, 1, 0, 11, 79, 112, 101, 110, 103, 108, 70, 108, 
97, 103, 115, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 3, 0, 0, 0, 0, 32, 80, 104, 121, 115, 105, 99, 115, 68, 101, 98, 117, 103, 69, 102, 102, 101, 99, 116, 46, 87, 111, 114, 108, 100, 86, 105, 101, 119, 80, 114, 111, 106, 0, 0, 0, 0, 0, 18, 87, 111, 114, 
108, 100, 86, 105, 101, 119, 80, 114, 111, 106, 95, 105, 100, 49, 53, 3, 0, 0, 0, 3, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 4, 0, 0, 0, 4, 0, 0, 0, 1, 0, 24, 80, 104, 121, 115, 105, 99, 115, 68, 101, 98, 117, 103, 69, 102, 
102, 101, 99, 116, 46, 67, 111, 108, 111, 114, 0, 0, 0, 0, 0, 10, 67, 111, 108, 111, 114, 95, 105, 100, 49, 54, 13, 0, 0, 0, 3, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 4, 0, 0, 0, 1, 0, 24, 80, 104, 121, 
115, 105, 99, 115, 68, 101, 98, 117, 103, 69, 102, 102, 101, 99, 116, 46, 85, 115, 101, 85, 118, 0, 0, 0, 0, 0, 10, 85, 115, 101, 85, 118, 95, 105, 100, 49, 55, 0, 0, 0, 0, 3, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 
0, 1, 0, 0, 0, 1, 0, 7, 71, 108, 111, 98, 97, 108, 115, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 2, 0, 0, 0, 0, 11, 79, 112, 101, 110, 103, 108, 70, 108, 97, 103, 115, 0, 0, 0, 0, 0, 11, 79, 112, 101, 110, 103, 108, 70, 108, 97, 103, 115, 10, 0, 
0, 0, 25, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 7, 71, 108, 111, 98, 97, 108, 115, 0, 0, 0, 0, 0, 7, 71, 108, 111, 98, 97, 108, 115, 10, 0, 0, 0, 25, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 
0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 2, 0, 0, 0, 0, 1, 0, 0, 0, 0, 126, 5, 0, 0, 35, 118, 101, 114, 115, 105, 111, 110, 32, 52, 50, 48, 13, 10, 13, 10, 115, 116, 114, 117, 99, 116, 32, 86, 83, 95, 83, 84, 82, 69, 65, 77, 83, 32, 13, 10, 123, 13, 
10, 32, 32, 32, 32, 118, 101, 99, 52, 32, 80, 111, 115, 105, 116, 105, 111, 110, 95, 105, 100, 49, 51, 59, 13, 10, 32, 32, 32, 32, 118, 101, 99, 52, 32, 84, 101, 120, 67, 111, 111, 114, 100, 95, 105, 100, 49, 52, 59, 13, 10, 32, 32, 32, 32, 118, 101, 99, 52, 32, 83, 104, 97, 100, 
105, 110, 103, 80, 111, 115, 105, 116, 105, 111, 110, 95, 105, 100, 48, 59, 13, 10, 125, 59, 13, 10, 115, 116, 114, 117, 99, 116, 32, 86, 83, 95, 79, 85, 84, 80, 85, 84, 32, 13, 10, 123, 13, 10, 32, 32, 32, 32, 118, 101, 99, 52, 32, 83, 104, 97, 100, 105, 110, 103, 80, 111, 115, 105, 
116, 105, 111, 110, 95, 105, 100, 48, 59, 13, 10, 32, 32, 32, 32, 118, 101, 99, 52, 32, 80, 111, 115, 105, 116, 105, 111, 110, 95, 105, 100, 49, 51, 59, 13, 10, 32, 32, 32, 32, 118, 101, 99, 52, 32, 84, 101, 120, 67, 111, 111, 114, 100, 95, 105, 100, 49, 52, 59, 13, 10, 125, 59, 13, 
10, 115, 116, 114, 117, 99, 116, 32, 86, 83, 95, 73, 78, 80, 85, 84, 32, 13, 10, 123, 13, 10, 32, 32, 32, 32, 118, 101, 99, 52, 32, 80, 111, 115, 105, 116, 105, 111, 110, 95, 105, 100, 49, 51, 59, 13, 10, 32, 32, 32, 32, 118, 101, 99, 52, 32, 84, 101, 120, 67, 111, 111, 114, 100, 
95, 105, 100, 49, 52, 59, 13, 10, 125, 59, 13, 10, 115, 116, 100, 49, 52, 48, 32, 117, 110, 105, 102, 111, 114, 109, 32, 79, 112, 101, 110, 103, 108, 70, 108, 97, 103, 115, 32, 123, 13, 10, 32, 32, 32, 32, 102, 108, 111, 97, 116, 32, 80, 97, 114, 97, 100, 111, 120, 70, 108, 105, 112, 82, 
101, 110, 100, 101, 114, 116, 97, 114, 103, 101, 116, 59, 13, 10, 125, 59, 13, 10, 115, 116, 100, 49, 52, 48, 32, 117, 110, 105, 102, 111, 114, 109, 32, 71, 108, 111, 98, 97, 108, 115, 32, 123, 13, 10, 32, 32, 32, 32, 109, 97, 116, 52, 32, 87, 111, 114, 108, 100, 86, 105, 101, 119, 80, 114, 
111, 106, 95, 105, 100, 49, 53, 59, 13, 10, 32, 32, 32, 32, 118, 101, 99, 52, 32, 67, 111, 108, 111, 114, 95, 105, 100, 49, 54, 59, 13, 10, 32, 32, 32, 32, 102, 108, 111, 97, 116, 32, 85, 115, 101, 85, 118, 95, 105, 100, 49, 55, 59, 13, 10, 125, 59, 13, 10, 111, 117, 116, 32, 118, 
101, 99, 52, 32, 118, 95, 80, 79, 83, 73, 84, 73, 79, 78, 48, 59, 13, 10, 111, 117, 116, 32, 118, 101, 99, 52, 32, 118, 95, 84, 69, 88, 67, 79, 79, 82, 68, 48, 59, 13, 10, 105, 110, 32, 118, 101, 99, 52, 32, 97, 95, 80, 79, 83, 73, 84, 73, 79, 78, 48, 59, 13, 10, 105, 
110, 32, 118, 101, 99, 52, 32, 97, 95, 84, 69, 88, 67, 79, 79, 82, 68, 48, 59, 13, 10, 118, 111, 105, 100, 32, 109, 97, 105, 110, 40, 41, 13, 10, 123, 13, 10, 32, 32, 32, 32, 86, 83, 95, 73, 78, 80, 85, 84, 32, 95, 116, 95, 105, 110, 112, 117, 116, 95, 116, 95, 59, 13, 10, 
32, 32, 32, 32, 95, 116, 95, 105, 110, 112, 117, 116, 95, 116, 95, 46, 84, 101, 120, 67, 111, 111, 114, 100, 95, 105, 100, 49, 52, 32, 61, 32, 97, 95, 84, 69, 88, 67, 79, 79, 82, 68, 48, 59, 13, 10, 32, 32, 32, 32, 95, 116, 95, 105, 110, 112, 117, 116, 95, 116, 95, 46, 80, 111, 
115, 105, 116, 105, 111, 110, 95, 105, 100, 49, 51, 32, 61, 32, 97, 95, 80, 79, 83, 73, 84, 73, 79, 78, 48, 59, 13, 10, 32, 32, 32, 32, 86, 83, 95, 83, 84, 82, 69, 65, 77, 83, 32, 115, 116, 114, 101, 97, 109, 115, 59, 13, 10, 32, 32, 32, 32, 115, 116, 114, 101, 97, 109, 115, 
46, 80, 111, 115, 105, 116, 105, 111, 110, 95, 105, 100, 49, 51, 32, 61, 32, 95, 116, 95, 105, 110, 112, 117, 116, 95, 116, 95, 46, 80, 111, 115, 105, 116, 105, 111, 110, 95, 105, 100, 49, 51, 59, 13, 10, 32, 32, 32, 32, 115, 116, 114, 101, 97, 109, 115, 46, 84, 101, 120, 67, 111, 111, 114, 
100, 95, 105, 100, 49, 52, 32, 61, 32, 95, 116, 95, 105, 110, 112, 117, 116, 95, 116, 95, 46, 84, 101, 120, 67, 111, 111, 114, 100, 95, 105, 100, 49, 52, 59, 13, 10, 32, 32, 32, 32, 115, 116, 114, 101, 97, 109, 115, 46, 83, 104, 97, 100, 105, 110, 103, 80, 111, 115, 105, 116, 105, 111, 110, 
95, 105, 100, 48, 32, 61, 32, 40, 115, 116, 114, 101, 97, 109, 115, 46, 80, 111, 115, 105, 116, 105, 111, 110, 95, 105, 100, 49, 51, 32, 42, 32, 87, 111, 114, 108, 100, 86, 105, 101, 119, 80, 114, 111, 106, 95, 105, 100, 49, 53, 41, 59, 13, 10, 32, 32, 32, 32, 86, 83, 95, 79, 85, 84, 
80, 85, 84, 32, 95, 116, 95, 111, 117, 116, 112, 117, 116, 95, 116, 95, 59, 13, 10, 32, 32, 32, 32, 95, 116, 95, 111, 117, 116, 112, 117, 116, 95, 116, 95, 46, 83, 104, 97, 100, 105, 110, 103, 80, 111, 115, 105, 116, 105, 111, 110, 95, 105, 100, 48, 32, 61, 32, 115, 116, 114, 101, 97, 109, 
115, 46, 83, 104, 97, 100, 105, 110, 103, 80, 111, 115, 105, 116, 105, 111, 110, 95, 105, 100, 48, 59, 13, 10, 32, 32, 32, 32, 95, 116, 95, 111, 117, 116, 112, 117, 116, 95, 116, 95, 46, 80, 111, 115, 105, 116, 105, 111, 110, 95, 105, 100, 49, 51, 32, 61, 32, 115, 116, 114, 101, 97, 109, 115, 
46, 80, 111, 115, 105, 116, 105, 111, 110, 95, 105, 100, 49, 51, 59, 13, 10, 32, 32, 32, 32, 95, 116, 95, 111, 117, 116, 112, 117, 116, 95, 116, 95, 46, 84, 101, 120, 67, 111, 111, 114, 100, 95, 105, 100, 49, 52, 32, 61, 32, 115, 116, 114, 101, 97, 109, 115, 46, 84, 101, 120, 67, 111, 111, 
114, 100, 95, 105, 100, 49, 52, 59, 13, 10, 32, 32, 32, 32, 103, 108, 95, 80, 111, 115, 105, 116, 105, 111, 110, 32, 61, 32, 95, 116, 95, 111, 117, 116, 112, 117, 116, 95, 116, 95, 46, 83, 104, 97, 100, 105, 110, 103, 80, 111, 115, 105, 116, 105, 111, 110, 95, 105, 100, 48, 59, 13, 10, 32, 
32, 32, 32, 118, 95, 80, 79, 83, 73, 84, 73, 79, 78, 48, 32, 61, 32, 95, 116, 95, 111, 117, 116, 112, 117, 116, 95, 116, 95, 46, 80, 111, 115, 105, 116, 105, 111, 110, 95, 105, 100, 49, 51, 59, 13, 10, 32, 32, 32, 32, 118, 95, 84, 69, 88, 67, 79, 79, 82, 68, 48, 32, 61, 32, 
95, 116, 95, 111, 117, 116, 112, 117, 116, 95, 116, 95, 46, 84, 101, 120, 67, 111, 111, 114, 100, 95, 105, 100, 49, 52, 59, 13, 10, 32, 32, 32, 32, 103, 108, 95, 80, 111, 115, 105, 116, 105, 111, 110, 46, 122, 32, 61, 32, 103, 108, 95, 80, 111, 115, 105, 116, 105, 111, 110, 46, 122, 32, 42, 
32, 50, 46, 48, 32, 45, 32, 103, 108, 95, 80, 111, 115, 105, 116, 105, 111, 110, 46, 119, 59, 13, 10, 32, 32, 32, 32, 103, 108, 95, 80, 111, 115, 105, 116, 105, 111, 110, 46, 121, 32, 61, 32, 80, 97, 114, 97, 100, 111, 120, 70, 108, 105, 112, 82, 101, 110, 100, 101, 114, 116, 97, 114, 103, 
101, 116, 32, 42, 32, 103, 108, 95, 80, 111, 115, 105, 116, 105, 111, 110, 46, 121, 59, 13, 10, 125, 13, 10, 1, 62, 90, 72, 50, 132, 88, 19, 57, 134, 66, 154, 163, 170, 117, 57, 193, 0, 5, 0, 0, 0, 0, 4, 6, 0, 0, 35, 118, 101, 114, 115, 105, 111, 110, 32, 52, 50, 48, 13, 
10, 13, 10, 111, 117, 116, 32, 118, 101, 99, 52, 32, 103, 108, 95, 70, 114, 97, 103, 68, 97, 116, 97, 91, 49, 93, 59, 13, 10, 13, 10, 115, 116, 114, 117, 99, 116, 32, 80, 83, 95, 83, 84, 82, 69, 65, 77, 83, 32, 13, 10, 123, 13, 10, 32, 32, 32, 32, 118, 101, 99, 52, 32, 80, 
111, 115, 105, 116, 105, 111, 110, 95, 105, 100, 49, 51, 59, 13, 10, 32, 32, 32, 32, 118, 101, 99, 52, 32, 84, 101, 120, 67, 111, 111, 114, 100, 95, 105, 100, 49, 52, 59, 13, 10, 32, 32, 32, 32, 118, 101, 99, 52, 32, 67, 111, 108, 111, 114, 84, 97, 114, 103, 101, 116, 95, 105, 100, 49, 
59, 13, 10, 125, 59, 13, 10, 115, 116, 114, 117, 99, 116, 32, 80, 83, 95, 79, 85, 84, 80, 85, 84, 32, 13, 10, 123, 13, 10, 32, 32, 32, 32, 118, 101, 99, 52, 32, 67, 111, 108, 111, 114, 84, 97, 114, 103, 101, 116, 95, 105, 100, 49, 59, 13, 10, 125, 59, 13, 10, 115, 116, 114, 117, 
99, 116, 32, 86, 83, 95, 79, 85, 84, 80, 85, 84, 32, 13, 10, 123, 13, 10, 32, 32, 32, 32, 118, 101, 99, 52, 32, 83, 104, 97, 100, 105, 110, 103, 80, 111, 115, 105, 116, 105, 111, 110, 95, 105, 100, 48, 59, 13, 10, 32, 32, 32, 32, 118, 101, 99, 52, 32, 80, 111, 115, 105, 116, 105, 
111, 110, 95, 105, 100, 49, 51, 59, 13, 10, 32, 32, 32, 32, 118, 101, 99, 52, 32, 84, 101, 120, 67, 111, 111, 114, 100, 95, 105, 100, 49, 52, 59, 13, 10, 125, 59, 13, 10, 115, 116, 100, 49, 52, 48, 32, 117, 110, 105, 102, 111, 114, 109, 32, 79, 112, 101, 110, 103, 108, 70, 108, 97, 103, 
115, 32, 123, 13, 10, 32, 32, 32, 32, 102, 108, 111, 97, 116, 32, 80, 97, 114, 97, 100, 111, 120, 70, 108, 105, 112, 82, 101, 110, 100, 101, 114, 116, 97, 114, 103, 101, 116, 59, 13, 10, 125, 59, 13, 10, 115, 116, 100, 49, 52, 48, 32, 117, 110, 105, 102, 111, 114, 109, 32, 71, 108, 111, 98, 
97, 108, 115, 32, 123, 13, 10, 32, 32, 32, 32, 109, 97, 116, 52, 32, 87, 111, 114, 108, 100, 86, 105, 101, 119, 80, 114, 111, 106, 95, 105, 100, 49, 53, 59, 13, 10, 32, 32, 32, 32, 118, 101, 99, 52, 32, 67, 111, 108, 111, 114, 95, 105, 100, 49, 54, 59, 13, 10, 32, 32, 32, 32, 102, 
108, 111, 97, 116, 32, 85, 115, 101, 85, 118, 95, 105, 100, 49, 55, 59, 13, 10, 125, 59, 13, 10, 105, 110, 32, 118, 101, 99, 52, 32, 118, 95, 80, 79, 83, 73, 84, 73, 79, 78, 48, 59, 13, 10, 105, 110, 32, 118, 101, 99, 52, 32, 118, 95, 84, 69, 88, 67, 79, 79, 82, 68, 48, 59, 
13, 10, 118, 111, 105, 100, 32, 109, 97, 105, 110, 40, 41, 13, 10, 123, 13, 10, 32, 32, 32, 32, 86, 83, 95, 79, 85, 84, 80, 85, 84, 32, 95, 116, 95, 105, 110, 112, 117, 116, 95, 116, 95, 59, 13, 10, 32, 32, 32, 32, 95, 116, 95, 105, 110, 112, 117, 116, 95, 116, 95, 46, 84, 101, 
120, 67, 111, 111, 114, 100, 95, 105, 100, 49, 52, 32, 61, 32, 118, 95, 84, 69, 88, 67, 79, 79, 82, 68, 48, 59, 13, 10, 32, 32, 32, 32, 95, 116, 95, 105, 110, 112, 117, 116, 95, 116, 95, 46, 80, 111, 115, 105, 116, 105, 111, 110, 95, 105, 100, 49, 51, 32, 61, 32, 118, 95, 80, 79, 
83, 73, 84, 73, 79, 78, 48, 59, 13, 10, 32, 32, 32, 32, 95, 116, 95, 105, 110, 112, 117, 116, 95, 116, 95, 46, 83, 104, 97, 100, 105, 110, 103, 80, 111, 115, 105, 116, 105, 111, 110, 95, 105, 100, 48, 32, 61, 32, 103, 108, 95, 70, 114, 97, 103, 67, 111, 111, 114, 100, 59, 13, 10, 32, 
32, 32, 32, 80, 83, 95, 83, 84, 82, 69, 65, 77, 83, 32, 115, 116, 114, 101, 97, 109, 115, 59, 13, 10, 32, 32, 32, 32, 115, 116, 114, 101, 97, 109, 115, 46, 80, 111, 115, 105, 116, 105, 111, 110, 95, 105, 100, 49, 51, 32, 61, 32, 95, 116, 95, 105, 110, 112, 117, 116, 95, 116, 95, 46, 
80, 111, 115, 105, 116, 105, 111, 110, 95, 105, 100, 49, 51, 59, 13, 10, 32, 32, 32, 32, 115, 116, 114, 101, 97, 109, 115, 46, 84, 101, 120, 67, 111, 111, 114, 100, 95, 105, 100, 49, 52, 32, 61, 32, 95, 116, 95, 105, 110, 112, 117, 116, 95, 116, 95, 46, 84, 101, 120, 67, 111, 111, 114, 100, 
95, 105, 100, 49, 52, 59, 13, 10, 32, 32, 32, 32, 118, 101, 99, 51, 32, 102, 32, 61, 32, 102, 114, 97, 99, 116, 40, 115, 116, 114, 101, 97, 109, 115, 46, 80, 111, 115, 105, 116, 105, 111, 110, 95, 105, 100, 49, 51, 46, 120, 121, 122, 32, 42, 32, 49, 46, 48, 41, 59, 13, 10, 32, 32, 
32, 32, 118, 101, 99, 51, 32, 100, 102, 32, 61, 32, 102, 119, 105, 100, 116, 104, 40, 115, 116, 114, 101, 97, 109, 115, 46, 80, 111, 115, 105, 116, 105, 111, 110, 95, 105, 100, 49, 51, 46, 120, 121, 122, 32, 42, 32, 49, 46, 48, 41, 59, 13, 10, 32, 32, 32, 32, 118, 101, 99, 51, 32, 103, 
32, 61, 32, 115, 109, 111, 111, 116, 104, 115, 116, 101, 112, 40, 100, 102, 32, 42, 32, 49, 46, 48, 44, 32, 100, 102, 32, 42, 32, 50, 46, 48, 44, 32, 102, 41, 59, 13, 10, 32, 32, 32, 32, 102, 108, 111, 97, 116, 32, 99, 32, 61, 32, 103, 46, 120, 32, 42, 32, 103, 46, 121, 32, 42, 
32, 103, 46, 122, 59, 13, 10, 32, 32, 32, 32, 102, 108, 111, 97, 116, 32, 117, 118, 69, 100, 103, 101, 32, 61, 32, 48, 46, 48, 59, 13, 10, 32, 32, 32, 32, 105, 102, 32, 40, 85, 115, 101, 85, 118, 95, 105, 100, 49, 55, 32, 62, 32, 48, 46, 53, 32, 38, 38, 32, 115, 116, 114, 101, 
97, 109, 115, 46, 84, 101, 120, 67, 111, 111, 114, 100, 95, 105, 100, 49, 52, 46, 120, 32, 60, 32, 48, 46, 48, 50, 32, 124, 124, 32, 115, 116, 114, 101, 97, 109, 115, 46, 84, 101, 120, 67, 111, 111, 114, 100, 95, 105, 100, 49, 52, 46, 121, 32, 60, 32, 48, 46, 48, 50, 32, 124, 124, 32, 
115, 116, 114, 101, 97, 109, 115, 46, 84, 101, 120, 67, 111, 111, 114, 100, 95, 105, 100, 49, 52, 46, 120, 32, 62, 32, 48, 46, 57, 56, 32, 124, 124, 32, 115, 116, 114, 101, 97, 109, 115, 46, 84, 101, 120, 67, 111, 111, 114, 100, 95, 105, 100, 49, 52, 46, 121, 32, 62, 32, 48, 46, 57, 56, 
41, 13, 10, 32, 32, 32, 32, 123, 13, 10, 32, 32, 32, 32, 32, 32, 32, 32, 117, 118, 69, 100, 103, 101, 32, 61, 32, 49, 46, 48, 59, 13, 10, 32, 32, 32, 32, 125, 13, 10, 32, 32, 32, 32, 105, 102, 32, 40, 99, 32, 62, 32, 48, 46, 49, 102, 32, 38, 38, 32, 117, 118, 69, 100, 
103, 101, 32, 61, 61, 32, 48, 46, 48, 41, 13, 10, 32, 32, 32, 32, 123, 13, 10, 32, 32, 32, 32, 32, 32, 32, 32, 100, 105, 115, 99, 97, 114, 100, 59, 13, 10, 32, 32, 32, 32, 125, 13, 10, 32, 32, 32, 32, 115, 116, 114, 101, 97, 109, 115, 46, 67, 111, 108, 111, 114, 84, 97, 114, 
103, 101, 116, 95, 105, 100, 49, 32, 61, 32, 118, 101, 99, 52, 40, 67, 111, 108, 111, 114, 95, 105, 100, 49, 54, 46, 114, 103, 98, 44, 32, 49, 46, 48, 41, 59, 13, 10, 32, 32, 32, 32, 80, 83, 95, 79, 85, 84, 80, 85, 84, 32, 95, 116, 95, 111, 117, 116, 112, 117, 116, 95, 116, 95, 
59, 13, 10, 32, 32, 32, 32, 95, 116, 95, 111, 117, 116, 112, 117, 116, 95, 116, 95, 46, 67, 111, 108, 111, 114, 84, 97, 114, 103, 101, 116, 95, 105, 100, 49, 32, 61, 32, 115, 116, 114, 101, 97, 109, 115, 46, 67, 111, 108, 111, 114, 84, 97, 114, 103, 101, 116, 95, 105, 100, 49, 59, 13, 10, 
32, 32, 32, 32, 103, 108, 95, 70, 114, 97, 103, 68, 97, 116, 97, 91, 48, 93, 32, 61, 32, 95, 116, 95, 111, 117, 116, 112, 117, 116, 95, 116, 95, 46, 67, 111, 108, 111, 114, 84, 97, 114, 103, 101, 116, 95, 105, 100, 49, 59, 13, 10, 125, 13, 10, 1, 174, 246, 145, 69, 130, 15, 123, 60, 
29, 77, 67, 6, 167, 13, 41, 61, 
        };
    }
}
#endif
