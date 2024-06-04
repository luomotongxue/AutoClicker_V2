using MaterialSkin.Controls;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Timers;
using static AutoClicker_V2.MouseHook;

namespace AutoClicker_V2
{
    public partial class Form1 : MaterialForm
    {
        private const int WM_HOTKEY = 0x0312;
        // �ȼ���Ψһ��ʶ����
        private int clickHotkeyId = 1;
        private int clickTypeHotkeyId = 2;
        // snackbar������չʾ��Ϣ��
        private MaterialSnackBar snackBar = new();
        // �Ƿ�ʹ���ȼ���
        private static bool isRMB = false;
        // �����ȼ���Ĭ��ΪF8��
        private Keys clickHotkey = Keys.F8;
        // �л���������ȼ���Ĭ��ΪF2��
        private Keys clickTypeHotkey = Keys.F2;
        // �����ݼ���ʶ����0Ϊ��ʹ�ã�1Ϊ���1��2Ϊ���2��
        private int xButton = 0;
        private int clickTypeXButton = 0;
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

            if (!RegisterHotKey(Handle, clickTypeHotkeyId, 0, (uint)clickTypeHotkey))
            {
                snackBar.Text = "�����޷�ע���ȼ������������Ϊ�ȼ���ռ�á�";
                snackBar.Show(this);
            }

            AutoClicker_V2.Click.timer.Elapsed += AutoClicker_V2.Click.Timer_Elapsed;
            AutoClicker_V2.Click.timer.AutoReset = true;

            // Ĭ��Ϊ��������
            updateLang("zh_cn");
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
            changeClickTypeHotkeyComboBox.Hint = Lang.changeClickTypeHotkeyComboBoxHint;
            chooseClickTypeHotkeyButton.Text = Lang.changeHotkey;
            changeClickTypeHotkeyComboBox.Items[1] = Lang.mouseSideButton_1;
            changeClickTypeHotkeyComboBox.Items[2] = Lang.mouseSideButton_2;

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
                else if ((int)m.WParam == clickTypeHotkeyId)
                {
                    ChangeClickType();
                }
            }
        }

        // ���ӻص�����  
        public static IntPtr HookCallback(int nCode, IntPtr wParam, IntPtr lParam)
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
                    if (((mouseData & XBUTTON1) != 0 && _instance.xButton == 1) || ((mouseData & XBUTTON2) != 0 && _instance.xButton == 2))
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

                    if (((mouseData & XBUTTON1) != 0 && _instance.clickTypeXButton == 1) || ((mouseData & XBUTTON2) != 0 && _instance.clickTypeXButton == 2))
                    {
                        _instance.ChangeClickType();
                    }
#pragma warning restore CS8602 // �����ÿ��ܳ��ֿ����á�
                }

                // ������һ������  
                return CallNextHookEx(_hookID, nCode, wParam, lParam);
            }
            return IntPtr.Zero; // ���nCodeС��0������Ҫ����CallNextHookEx 
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

        private void chooseChangeClickTypeHotkeyButton_Click(object sender, EventArgs e)
        {
            ChooseHotkeyDialog chooseHotkeyDialog = new ChooseHotkeyDialog();

            if (chooseHotkeyDialog.ShowDialog() == DialogResult.OK)
            {
                clickTypeHotkey = chooseHotkeyDialog.Key;
                changeClickTypeHotkeyComboBox.Items[0] = chooseHotkeyDialog.KeyName;
            }
        }

        private void changeClickTypeHotkeyComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (changeClickTypeHotkeyComboBox.SelectedIndex == 0)
            {
                if (!RegisterHotKey(Handle, clickTypeHotkeyId, 0, (uint)clickTypeHotkey))
                {
                    snackBar.Text = "�����޷�ע���ȼ������������Ϊ�ȼ���ռ�á�";
                    snackBar.Show(this);
                }
                clickTypeXButton = 0;
            }
            else if (changeClickTypeHotkeyComboBox.SelectedIndex == 1)
            {
                if (xButton == 0)
                {
                    SetHook();
                }
                clickTypeXButton = 1;
            }
            else if (changeClickTypeHotkeyComboBox.SelectedIndex == 2)
            {
                if (xButton == 1)
                {
                    SetHook();
                }
                clickTypeXButton = 2;
            }
        }

        private void ChangeClickType()
        {
            if (AutoClicker_V2.Click.isClicking)
            {
                // restart autoclick
                AutoClicker_V2.Click.StopClick();
                AutoClicker_V2.Click.StartClick(isRMB, useDelay, value);
            }

            bool temp = LMB_RadioButton.Checked;
            LMB_RadioButton.Checked = !LMB_RadioButton.Checked;
            RMB_RadioButton.Checked = temp;

            isRMB = !isRMB;
        }

        private void materialButton2_Click(object sender, EventArgs e)
        {
            string command = "start https://github.com/luomotongxue/AutoClicker";

            using (var process = new Process())
            {
                process.StartInfo.FileName = "cmd.exe";
                process.StartInfo.UseShellExecute = false;
                process.StartInfo.RedirectStandardInput = true;
                process.StartInfo.RedirectStandardOutput = true;
                process.StartInfo.RedirectStandardError = true;
                process.StartInfo.CreateNoWindow = true;

                process.Start();
                process.StandardInput.AutoFlush = true;
                process.StandardInput.WriteLine(command + "&exit");

                process.WaitForExit();
                process.Close();
            }
        }
    }
}