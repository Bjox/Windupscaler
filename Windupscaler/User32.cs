using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using static Windupscaler.User32;

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

        [StructLayout(LayoutKind.Sequential)]
        internal struct Rect
        {
            public int Left;
            public int Top;
            public int Right;
            public int Bottom;
        }

        [DllImport("user32.dll", SetLastError=true)]
        internal static extern bool GetWindowRect(IntPtr hwnd, out Rect lpRect);

        [DllImport("user32.dll")]
        internal static extern bool GetClientRect(IntPtr hWnd, out Rect lpRect);

        [Flags()]
        internal enum GWL : int
        {
            GWL_WNDPROC = (-4),
            GWL_HINSTANCE = (-6),
            GWL_HWNDPARENT = (-8),
            GWL_STYLE = (-16),
            GWL_EXSTYLE = (-20),
            GWL_USERDATA = (-21),
            GWL_ID = (-12)
        }

        [Flags()]
        internal enum WindowStyleFlags : int
        {
            WS_VISIBLE = 0x10000000,
            WS_POPUP = unchecked((int)0x80000000)
        }

        [DllImport("user32.dll")]
        internal static extern int SetWindowLong(IntPtr hWnd, int nIndex, int dwNewLong);

        [DllImport("user32.dll")]
        internal static extern int GetWindowLong(IntPtr hWnd, int nIndex);

        [DllImport("user32.dll")]
        internal static extern bool AdjustWindowRect(ref Rect lpRect, uint dwStyle, bool bMenu);

        [Flags()]
        internal enum SetWindowPosFlags : uint
        {
            AsynchronousWindowPosition = 0x4000,
            DeferErase = 0x2000,
            DrawFrame = 0x0020,
            FrameChanged = 0x0020,
            HideWindow = 0x0080,
            DoNotActivate = 0x0010,
            DoNotCopyBits = 0x0100,
            IgnoreMove = 0x0002,
            DoNotChangeOwnerZOrder = 0x0200,
            DoNotRedraw = 0x0008,
            DoNotReposition = 0x0200,
            DoNotSendChangingEvent = 0x0400,
            IgnoreResize = 0x0001,
            IgnoreZOrder = 0x0004,
            ShowWindow = 0x0040,
        }

        [DllImport("user32.dll", SetLastError=true)]
        internal static extern bool SetWindowPos(IntPtr hWnd, IntPtr hWndInsertAfter, int X, int Y, int cx, int cy, SetWindowPosFlags uFlags);

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
                var stringBuilder = new StringBuilder(GetWindowTextLength(Handle));
                GetWindowText(Handle, stringBuilder, stringBuilder.MaxCapacity);
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
                return IsWindowVisible(Handle);
            }
        }

        /// <summary>
        /// The bounding rectangle (position and size) of this window.
        /// </summary>
        public Rectangle WindowRect
        {
            get
            {
                Rect rect;
                GetWindowRect(Handle, out rect);
                return new Rectangle(rect.Left, rect.Top, rect.Right - rect.Left, rect.Bottom - rect.Top);
            }
        }

        /// <summary>
        /// The size of the client area of this window.
        /// </summary>
        public Size ClientRectSize
        {
            get
            {
                Rect rect;
                GetClientRect(Handle, out rect);
                return new Size(rect.Right - rect.Left, rect.Bottom - rect.Top);
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

        public void SetPopup()
        {
            SetWindowLong(Handle, (int)GWL.GWL_STYLE, (int)(WindowStyleFlags.WS_POPUP | WindowStyleFlags.WS_VISIBLE));
        }

        /// <summary>
        /// Get all top-level windows.
        /// </summary>
        /// <returns></returns>
        public static IEnumerable<Window> GetWindows(Predicate<Window> filterPredicate)
        {
            var windows = new List<Window>();
            EnumWindows(delegate (IntPtr hwnd, IntPtr lParam)
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
