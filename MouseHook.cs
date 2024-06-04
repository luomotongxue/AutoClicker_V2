using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace AutoClicker_V2
{
    internal static class MouseHook
    {
        public const int WH_MOUSE_LL = 14;
        public const int WM_XBUTTONDOWN = 0x020B;
        // 通常用于表示鼠标的额外按钮1。
        public const int XBUTTON1 = 0x0001;
        // 通常用于表示鼠标的额外按钮2。
        public const int XBUTTON2 = 0x0002;
        
        public static IntPtr _hookID = IntPtr.Zero;

        // 导入必要的Windows API函数  
        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern IntPtr SetWindowsHookEx(int idHook, LowLevelMouseProc lpfn, IntPtr hMod, uint dwThreadId);

        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        private static extern bool UnhookWindowsHookEx(IntPtr hhk);

        [DllImport("kernel32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        private static extern IntPtr GetModuleHandle(string lpModuleName);

        // 定义鼠标钩子回调的委托  
        public delegate IntPtr LowLevelMouseProc(int nCode, IntPtr wParam, IntPtr lParam);

        // 定义鼠标钩子结构体  
        [StructLayout(LayoutKind.Sequential)]
        public struct MSLLHOOKSTRUCT
        {
            public Point pt;
            public uint mouseData;
            public uint flags;
            public uint time;
            public IntPtr dwExtraInfo;
        }

        

        // 定义Windows消息常量  
        private static class WindowsMessages
        {
            public const int WM_XBUTTONDOWN = 0x020B;
            public const int WM_XBUTTONUP = 0x020C;
            // ... 其他消息常量  
        }

        // 定义鼠标标志常量  
        [Flags]
        private enum MouseFlags : uint
        {
            None = 0x0000,
            LeftDown = 0x0001,
            LeftUp = 0x0002,
            RightDown = 0x0004,
            RightUp = 0x0008,
            MiddleDown = 0x0020,
            MiddleUp = 0x0040,
            XBUTTON1 = 0x0080, // 通常是侧键1
            XBUTTON2 = 0x0100, // 通常是侧键2  
        }

        // 导入CallNextHookEx函数  
        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern IntPtr CallNextHookEx(IntPtr hhk, int nCode, IntPtr wParam, IntPtr lParam);

        // 安装钩子  
        public static void SetHook()
        {
            if (_hookID == IntPtr.Zero)
            {
#pragma warning disable CS8602 // 解引用可能出现空引用。
                _hookID = SetWindowsHookEx(WH_MOUSE_LL, Form1Helpers._proc, GetModuleHandle(Process.GetCurrentProcess().MainModule.ModuleName), 0);
#pragma warning restore CS8602 // 解引用可能出现空引用。

                // 检查钩子是否设置成功  
                if (_hookID == IntPtr.Zero)
                {
                    int errorCode = Marshal.GetLastWin32Error();
                    throw new Win32Exception(errorCode);
                }
            }
        }

        // 卸载钩子  
        public static void RemoveHook()
        {
            if (_hookID != IntPtr.Zero)
            {
                bool result = UnhookWindowsHookEx(_hookID);
                _hookID = IntPtr.Zero;

                if (!result)
                {
                    int errorCode = Marshal.GetLastWin32Error();
                    throw new Win32Exception(errorCode);
                }
            }
        }
    }
}
