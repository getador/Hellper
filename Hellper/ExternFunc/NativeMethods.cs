﻿using System.Runtime.InteropServices;
using System.Security;
namespace Hellper.ExternFunc
{
    [SuppressUnmanagedCodeSecurity]
    public static class NativeMethods
    {
        [DllImport("shlwapi.dll", CharSet = CharSet.Unicode)]
        public static extern int StrCmpLogicalW(string psz1, string psz2);
    }
}