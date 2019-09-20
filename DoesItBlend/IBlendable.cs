﻿using System;
using System.Collections.Generic;
using System.Text;

namespace DoesItBlend
{
    /// <summary>
    /// Interace for items that can not be blended.
    /// </summary>
    interface IBlendable
    {
        /// <summary>
        /// Blends the object
        /// </summary>
        /// <returns>A string describing the blended object.</returns>
        string Blend();
    }
}
