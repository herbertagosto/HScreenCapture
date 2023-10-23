using System;
using System.Runtime.InteropServices;

namespace HScreenCapture.Libs
{
    class WindowHandle
    {
        // find window with class name and main title
        [DllImport("user32.dll")]
        private static extern IntPtr FindWindow(string windowClassName, string windowMainTitle);
        public static IntPtr GetHandle(string windowClassName, string windowMainTitle)
        {
            return FindWindow(windowClassName, windowMainTitle);
        }

        // set window in front
        [DllImport("User32.dll", SetLastError = true)]
        public static extern void SwitchToThisWindow(IntPtr hWnd, bool fAltTab);
    }
}
