using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Windupscaler
{
    internal static class User32
    {
        internal delegate bool EnumWindowsProc(IntPtr hWnd, IntPtr lParam);

        [DllImport("user32.dll")]
        [return: MarshalAs(UnmanagedType.Bool)]
        internal static extern bool EnumWindows(EnumWindowsProc lpEnumFunc, IntPtr lParam);

        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        internal static extern int GetWindowText(IntPtr hWnd, StringBuilder lpString, int nMaxCount);

        [DllImport("user32.dll", SetLastError = true, CharSet = CharSet.Auto)]
        internal static extern int GetWindowTextLength(IntPtr hWnd);

        [DllImport("user32.dll")]
        [return: MarshalAs(UnmanagedType.Bool)]
        internal static extern bool IsWindowVisible(IntPtr hWnd);

        [DllImport("user32.dll", SetLastError = true)]
        internal static extern bool MoveWindow(IntPtr hWnd, int X, int Y, int nWidth, int nHeight, bool bRepaint);

    }

    public partial class Window
    {
        /// <summary>
        /// The handle for this window.
        /// </summary>
        public IntPtr Handle { get; private set; }

        public Window(IntPtr handle)
        {
            this.Handle = handle;
        }

        /// <summary>
        /// The title of this window.
        /// </summary>
        public string Title
        {
            get
            {
                var stringBuilder = new StringBuilder(User32.GetWindowTextLength(Handle));
                User32.GetWindowText(Handle, stringBuilder, stringBuilder.MaxCapacity);
                return stringBuilder.ToString();
            }
        }

        /// <summary>
        /// If this window is visible.
        /// </summary>
        public bool IsVisible
        {
            get
            {
                return User32.IsWindowVisible(Handle);
            }
        }

        /// <summary>
        /// Move and resize this window.
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <param name="width"></param>
        /// <param name="height"></param>
        /// <param name="repaint"></param>
        /// <returns></returns>
        public bool MoveWindow(int x, int y, int width, int height, bool repaint)
        {
            return User32.MoveWindow(Handle, x, y, width, height, repaint);
        }

        /// <summary>
        /// Get all top-level windows.
        /// </summary>
        /// <returns></returns>
        public static IEnumerable<Window> GetWindows(Predicate<Window> filterPredicate)
        {
            var windows = new List<Window>();
            User32.EnumWindows(delegate (IntPtr hwnd, IntPtr lParam)
            {
                var window = new Window(hwnd);
                if (filterPredicate(window))
                {
                    windows.Add(window);
                }
                return true;
            }, new IntPtr(1));
            return windows;
        }
    }


}
