﻿using System;

namespace Cloo
{
    public enum ComputeMemoryFlags: long
    {
        ReadWrite = ( 1 << 0 ),
        WriteOnly = ( 1 << 1 ),
        ReadOnly = ( 1 << 2 ),
        UseHostPtr = ( 1 << 3 ),
        AllocHostPtr = ( 1 << 4 ),
        CopyHostPtr = ( 1 << 5 )
    }
}