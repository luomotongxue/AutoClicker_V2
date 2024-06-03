using System.Runtime.InteropServices;
using Timer = System.Timers.Timer;

namespace AutoClicker_V2
{
    static internal class Click
    {
        private const int INPUT_MOUSE = 0;
        private const int MOUSEEVENTF_LEFTDOWN = 0x02;
        private const int MOUSEEVENTF_LEFTUP = 0x04;
        private const uint MOUSEEVENTF_ABSOLUTE = 0x8000;
        private const int MOUSEEVENTF_RIGHTDOWN = 0x0008;
        private const int MOUSEEVENTF_RIGHTUP = 0x0010;
        public static Timer timer = new();
        private static Timer? superTimer = null;
        private static bool isRMB = false;
        public static bool isClicking = false;
        private static bool isSuperClick = false;
        private static int mouseFlagsDown;
        private static int mouseFlagsUp;

        [StructLayout(LayoutKind.Sequential)]
        private struct INPUT
        {
            public int Type;
            public MOUSEKEYBDHARDWAREINPUT Data;
        }

        [StructLayout(LayoutKind.Explicit)]
        private struct MOUSEKEYBDHARDWAREINPUT
        {
            [FieldOffset(0)]
            public MOUSEINPUT Mouse;
        }

        [StructLayout(LayoutKind.Sequential)]
        private struct MOUSEINPUT
        {
            public int X;
            public int Y;
            public uint MouseData;
            public uint Flags;
            public uint Time;
            public IntPtr ExtraInfo;
        }

        [DllImport("user32.dll")]
        private static extern uint SendInput(uint nInputs, INPUT[] pInputs, int cbSize);

        public static void SimulateClick(int x, int y,int mouseFlagsUp, int mouseFlagsDown)
        {
            INPUT[] inputs = new INPUT[2];

            if (Screen.PrimaryScreen == null)
            {
                return;
            }

            x = (x * 65535) / Screen.PrimaryScreen.Bounds.Width;
            y = (y * 65535) / Screen.PrimaryScreen.Bounds.Height;

            // 按下鼠标  
            inputs[0].Type = INPUT_MOUSE;
            inputs[0].Data.Mouse.X = (int)x;
            inputs[0].Data.Mouse.Y = (int)y;
            inputs[0].Data.Mouse.MouseData = 0;
            inputs[0].Data.Mouse.Flags = (uint)(mouseFlagsDown | MOUSEEVENTF_ABSOLUTE); // 使用绝对坐标  
            inputs[0].Data.Mouse.Time = 0;
            inputs[0].Data.Mouse.ExtraInfo = IntPtr.Zero;

            // 释放鼠标  
            inputs[1].Type = INPUT_MOUSE;
            inputs[1].Data.Mouse.X = (int)x;
            inputs[1].Data.Mouse.Y = (int)y;
            inputs[1].Data.Mouse.MouseData = 0;
            inputs[1].Data.Mouse.Flags = (uint)(mouseFlagsUp | MOUSEEVENTF_ABSOLUTE); // 使用绝对坐标  
            inputs[1].Data.Mouse.Time = 0;
            inputs[1].Data.Mouse.ExtraInfo = IntPtr.Zero;

            // 发送输入  
            SendInput((uint)inputs.Length, inputs, Marshal.SizeOf(typeof(INPUT)));
        }

        private static void ClickLoop()
        {
            SimulateClick(Cursor.Position.X, Cursor.Position.Y, mouseFlagsUp, mouseFlagsDown);
        }

        public static void StartClick(bool isRMB, bool useDelay, int value)
        {
            if (isClicking)
            {
                return;
            }

            isClicking = true;
            mouseFlagsUp = isRMB ? MOUSEEVENTF_RIGHTUP : MOUSEEVENTF_LEFTUP;
            mouseFlagsDown = isRMB ? MOUSEEVENTF_RIGHTDOWN : MOUSEEVENTF_LEFTDOWN;

            Click.isRMB = isRMB;

            // 40cps以上则使用超级连点
            if (value >= 40 && !useDelay)
            {
                // 初始化
                isSuperClick = true;
                superTimer = new();

                // 分块
                int part = (int)Math.Floor((double)(value) / 40.0);
                for (int i = 0; i < part; i++)
                {
                    // 通过重复添加Elapsed事件达到分块的效果
                    superTimer.Elapsed += Timer_Elapsed;
                }

                // 剩余的用正常的timer执行
                int remainderCPS = 0;
                if (value % 40 != 0)
                {
                    remainderCPS = value % 40;
                    timer.Interval = 1000 / remainderCPS;
                    timer.Start();
                }
                // 执行分块timer
                superTimer.Interval = 1000 / ((value - remainderCPS) / part);
                superTimer.Start();
            }
            else
            {
                timer.Interval = useDelay ? value : 1000 / value;
                timer.Start();
            }            
        }

        public static void Timer_Elapsed(object? sender, System.Timers.ElapsedEventArgs e)
        {
            SimulateClick(Cursor.Position.X, Cursor.Position.Y, mouseFlagsUp, mouseFlagsDown);
        }

        public static void StopClick()
        {
            if (isSuperClick)
            {
                isSuperClick = false;
#pragma warning disable CS8602          // 解引用可能出现空引用。
                superTimer.Stop();
#pragma warning restore CS8602          // 解引用可能出现空引用。
                timer.Stop();
                // 销毁
                superTimer = null;

                return;
            }

            timer.Stop();
            isClicking = false;          
        }
    }
}
