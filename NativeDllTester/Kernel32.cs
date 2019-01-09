using System;
using System.Runtime.InteropServices;

namespace NativeDllTester
{
    /// <summary>
    /// Taken from https://github.com/mellinoe/nativelibraryloader/blob/master/NativeLibraryLoader/Kernel32.cs
    /// </summary>
    internal static class Kernel32
    {
        [DllImport("kernel32", SetLastError = true)]
        public static extern IntPtr LoadLibrary(string fileName);

        [DllImport("kernel32")]
        public static extern IntPtr GetProcAddress(IntPtr module, string procName);

        [DllImport("kernel32")]
        public static extern int FreeLibrary(IntPtr module);
    }
}
