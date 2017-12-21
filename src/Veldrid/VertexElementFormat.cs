﻿namespace Veldrid
{
    /// <summary>
    /// The format of an individual vertex element.
    /// </summary>
    public enum VertexElementFormat : byte
    {
        /// <summary>
        /// One 32-bit floating point value.
        /// </summary>
        Float1,
        /// <summary>
        /// Two 32-bit floating point values.
        /// </summary>
        Float2,
        /// <summary>
        /// Three 32-bit floating point values.
        /// </summary>
        Float3,
        /// <summary>
        /// Four 32-bit floating point values.
        /// </summary>
        Float4,
        /// <summary>
        /// Two 8-bit unsigned normalized integers.
        /// </summary>
        Byte2_UNorm,
        /// <summary>
        /// Two 8-bit unisgned integers.
        /// </summary>
        Byte2_UInt,
        /// <summary>
        /// Four 8-bit unsigned normalized integers.
        /// </summary>
        Byte4_UNorm,
        /// <summary>
        /// Four 8-bit unsigned integers.
        /// </summary>
        Byte4_UInt,
    }
}