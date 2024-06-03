using MaterialSkin.Controls;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Timers;

namespace AutoClicker_V2
{
    public partial class Form1 : MaterialForm
    {
        private const int WM_HOTKEY = 0x0312;
        // �ȼ���Ψһ��ʶ����
        private int clickHotkeyId = 1; 
        // snackbar������չʾ��Ϣ��
        private MaterialSnackBar snackBar = new();
        // �Ƿ�ʹ���ȼ���
        private static bool isRMB = false;
        // �����ȼ���Ĭ��ΪF8��
        private Keys clickHotkey = Keys.F8;
        private const int WH_MOUSE_LL = 14;
        private const int WM_XBUTTONDOWN = 0x020B;
        // ͨ�����ڱ�ʾ���Ķ��ⰴť1��
        private const int XBUTTON1 = 0x0001;
        // ͨ�����ڱ�ʾ���Ķ��ⰴť2��
        private const int XBUTTON2 = 0x0002; 
        private static LowLevelMouseProc _proc = HookCallback;
        private static IntPtr _hookID = IntPtr.Zero;
        // �����ݼ���ʶ����0Ϊ��ʹ�ã�1Ϊ���1��2Ϊ���2��
        private int xButton = 0;
        // �Ƿ��Լ������λ��
        private bool useDelay = false;
        // ���/CPS ֵ��
        private int value = 0;
        // ���ڴ洢ʵ�������㾲̬�������á�
        private static Form1? _instance;
        // ���ļ�����
        private string macroFileName = "";

        // �����Ҫ�� ע��/ע�� �ȼ�������
        [DllImport("user32.dll")]
        private static extern bool RegisterHotKey(IntPtr hWnd, int id, uint fsModifiers, uint vk);

        [DllImport("user32.dll")]
        private static extern bool UnregisterHotKey(IntPtr hWnd, int id);

        public Form1()
        {
            InitializeComponent();

            // ��ֵʵ��������
            _instance = this;
            if (!RegisterHotKey(Handle, clickHotkeyId, 0, (uint)clickHotkey))
            {
                snackBar.Text = "�����޷�ע���ȼ������������Ϊ�ȼ���ռ�á�";
                snackBar.Show(this);
            }

            AutoClicker_V2.Click.timer.Elapsed += AutoClicker_V2.Click.Timer_Elapsed;
            AutoClicker_V2.Click.timer.AutoReset = true;

            // Ĭ��Ϊ��������
            updateLang("zh_cn");
        }

        // �����Ҫ��Windows API����  
        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        private static extern IntPtr SetWindowsHookEx(int idHook, LowLevelMouseProc lpfn, IntPtr hMod, uint dwThreadId);

        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        private static extern bool UnhookWindowsHookEx(IntPtr hhk);

        [DllImport("kernel32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        private static extern IntPtr GetModuleHandle(string lpModuleName);

        // ������깳�ӻص���ί��  
        public delegate IntPtr LowLevelMouseProc(int nCode, IntPtr wParam, IntPtr lParam);

        // ������깳�ӽṹ��  
        [StructLayout(LayoutKind.Sequential)]
        private struct MSLLHOOKSTRUCT
        {
            public Point pt;
            public uint mouseData;
            public uint flags;
            public uint time;
            public IntPtr dwExtraInfo;
        }

        // ���ӻص�����  
        private static IntPtr HookCallback(int nCode, IntPtr wParam, IntPtr lParam)
        {
            if (nCode >= 0)
            {
                // ����Ƿ��ǲ���¼�  
                if (wParam == (IntPtr)WM_XBUTTONDOWN)
                {
                    // ��lParamת��ΪMSLLHOOKSTRUCT�ṹ  
#pragma warning disable CS8605 // ȡ��װ�����Ϊ null ��ֵ��
                    MSLLHOOKSTRUCT hookStruct = (MSLLHOOKSTRUCT)Marshal.PtrToStructure(lParam, typeof(MSLLHOOKSTRUCT));
#pragma warning restore CS8605 // ȡ��װ�����Ϊ null ��ֵ��

                    // ������ĸ����������  
                    int mouseData = (int)(hookStruct.mouseData >> 16); // ��ȡ��16λ����ȡ������������  
#pragma warning disable CS8602 // �����ÿ��ܳ��ֿ����á�
                    if ((mouseData & XBUTTON1) != 0 && _instance.xButton == 1)
                    {
                        if (AutoClicker_V2.Click.isClicking)
                        {
                            _instance.StopClick();
                        }
                        else
                        {
                            _instance.StartClick();
                        }
                    }
                    else if ((mouseData & XBUTTON2) != 0 && _instance.xButton == 2)
                    {
                        if (AutoClicker_V2.Click.isClicking)
                        {
                            _instance.StopClick();
                        }
                        else
                        {
                            _instance.StartClick();
                        }
                    }
#pragma warning restore CS8602 // �����ÿ��ܳ��ֿ����á�
                }

                // ������һ������  
                return CallNextHookEx(_hookID, nCode, wParam, lParam);
            }
            return IntPtr.Zero; // ���nCodeС��0������Ҫ����CallNextHookEx 
        }

        // ����Windows��Ϣ����  
        private static class WindowsMessages
        {
            public const int WM_XBUTTONDOWN = 0x020B;
            public const int WM_XBUTTONUP = 0x020C;
            // ... ������Ϣ����  
        }

        // ��������־����  
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
            XBUTTON1 = 0x0080, // ͨ���ǲ��1
            XBUTTON2 = 0x0100, // ͨ���ǲ��2  
        }

        // ����CallNextHookEx����  
        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        private static extern IntPtr CallNextHookEx(IntPtr hhk, int nCode, IntPtr wParam, IntPtr lParam);

        // ��װ����  
        public static void SetHook()
        {
            if (_hookID == IntPtr.Zero)
            {
#pragma warning disable CS8602 // �����ÿ��ܳ��ֿ����á�
                _hookID = SetWindowsHookEx(WH_MOUSE_LL, _proc, GetModuleHandle(Process.GetCurrentProcess().MainModule.ModuleName), 0);
#pragma warning restore CS8602 // �����ÿ��ܳ��ֿ����á�

                // ��鹳���Ƿ����óɹ�  
                if (_hookID == IntPtr.Zero)
                {
                    int errorCode = Marshal.GetLastWin32Error();
                    throw new Win32Exception(errorCode);
                }
            }
        }

        // ж�ع���  
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

        private void updateLang(string lang)
        {
            if (lang == "zh_cn")
            {
                Lang.zh_cn();
            }
            else if (lang == "en_us")
            {
                Lang.en_us();
            }

            // ����
            // AutoClick Page
            autoclickTitleLabel.Text = Lang.autoClickPage;
            AutoClickPage.Text = Lang.autoClickPage;
            clickKindLabel.Text = Lang.clickKind;
            delayTextBox.Hint = Lang.delayTextBoxHint;
            hotkeyComboBox.Hint = Lang.hotkeyComboBoxHint;
            chooseHotkeyButton.Text = Lang.changeHotkey;
            hotkeyComboBox.Items[1] = Lang.mouseSideButton_1;
            hotkeyComboBox.Items[2] = Lang.mouseSideButton_2;

            // Macro Page
            macroPage.Text = Lang.macro;

            // Settings Page
            settingsPage.Text = Lang.settingsPage;
            settingsTitleLabel.Text = Lang.settingsPage;
        }

        private void langComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (langComboBox.SelectedIndex == 0)
            {
                updateLang("zh_cn");
            }
            else if (langComboBox.SelectedIndex == 1)
            {
                updateLang("en_us");
            }
        }

        protected override void WndProc(ref Message m)
        {
            base.WndProc(ref m);

            if (m.Msg == WM_HOTKEY)
            {
                if ((int)m.WParam == clickHotkeyId)
                {
                    if (AutoClicker_V2.Click.isClicking)
                    {
                        StopClick();
                    }
                    else
                    {
                        StartClick();
                    }
                }
            }
        }

        private void StartClick()
        {
            snackBar.Hide();

            if ((!int.TryParse(delayTextBox.Text, out value)) || value < 0 || value > 10000)
            {
                snackBar.Text = "��������Ч�����֣�";
                snackBar.Show(this);
                return;
            }
            isRMB = RMB_RadioButton.Checked ? true : false;
            useDelay = unitComboBox.SelectedIndex == 1 ? true : false;
            this.Invoke(new Action(() =>
            {
                AutoClicker_V2.Click.StartClick(isRMB, useDelay, value);
            }));

            
            Hide();
        }

        private void StopClick()
        {
            AutoClicker_V2.Click.StopClick();
            Show();
        }

        private void chooseHotkeyButton_Click(object sender, EventArgs e)
        {
            ChooseHotkeyDialog chooseHotkeyDialog = new();
            chooseHotkeyDialog.ShowDialog(this);
            if (chooseHotkeyDialog.DialogResult == DialogResult.OK)
            {
                // ȡ��ע��֮ǰ���ȼ�
                UnregisterHotKey(Handle, clickHotkeyId);

                // ע�����ȼ�
                clickHotkey = chooseHotkeyDialog.Key;
                RegisterHotKey(Handle, clickHotkeyId, 0, (uint)clickHotkey);
                hotkeyComboBox.Items[0] = clickHotkey;
            }
        }

        private void hotkeyComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            UnregisterHotKey(Handle, clickHotkeyId);
            if (hotkeyComboBox.SelectedIndex == 0)
            {
                RegisterHotKey(Handle, clickHotkeyId, 0, (uint)clickHotkey);
                RemoveHook();
                // ��ʹ�ò��
                xButton = 0;
            }
            else if (hotkeyComboBox.SelectedIndex == 1)
            {
                SetHook();
                // ʹ�ò��1
                xButton = 1;
            }
            else if (hotkeyComboBox.SelectedIndex == 2)
            {
                SetHook();
                // ʹ�ò��2
                xButton = 2;
            }
        }

        // SSF��Select script file����д
        private void openSSFButton_Click(object sender, EventArgs e)
        {
            using OpenFileDialog openFileDialog = new OpenFileDialog();

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                macroFileName = openFileDialog.FileName;
                macroFileNameLabel.Text = macroFileName;

                string[] lines = File.ReadAllLines(macroFileName);
                foreach (string line in lines)
                {
                    macroActionListBox.AddItem(line);
                }
            }
        }

        private void newSSFButton_Click(object sender, EventArgs e)
        {
            using SaveFileDialog saveFileDialog = new SaveFileDialog();

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                macroFileName = saveFileDialog.FileName;
                macroFileNameLabel.Text = macroFileName;
            }
        }

        private void macroActionTypeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (macroActionTypeComboBox.SelectedIndex == 0)
            {
                macroDelayTextBox.Enabled = true;
                macroUnitComboBox.Enabled = true;
            }
            else if (macroActionTypeComboBox.SelectedIndex == 1)
            {
                macroDelayTextBox.Enabled = false;
                macroUnitComboBox.Enabled = false;
            }
        }
    }
}