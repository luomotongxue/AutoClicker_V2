namespace AutoClicker_V2
{
    static class Lang
    {
        public static string autoClickPage = "";
        public static string clickKind = "";
        public static string delayTextBoxHint = "";
        public static string hotkeyComboBoxHint = "";
        public static string settingsPage = "";
        public static string changeHotkey = "";
        public static string macro = "";
        public static string mouseSideButton_1 = "";
        public static string mouseSideButton_2 = "";
        public static string changeClickTypeHotkeyComboBoxHint = "";

        public static void zh_cn()
        {
            // AutoClick Page
            autoClickPage = "连点";
            clickKind = "点击类型";
            changeClickTypeHotkeyComboBoxHint = "切换点击类型热键";

            // Macro Page
            macro = "宏";

            // Settings Page
            settingsPage = "设置";

            // Global
            delayTextBoxHint = "输入CPS/连点间隔(ms)";
            hotkeyComboBoxHint = "热键";
            changeHotkey = "选择一个热键";
            mouseSideButton_1 = "鼠标侧键 1";
            mouseSideButton_2 = "鼠标侧键 2";
        }

        public static void en_us()
        {
            // AutoClick Page
            autoClickPage = "AutoClick";
            clickKind = "Click Kind";
            changeClickTypeHotkeyComboBoxHint = "Change click type hot key";

            // Macro Page
            macro = "Macro";

            // Settings Page
            settingsPage = "Settings";
            delayTextBoxHint = "Input CPS/Click Delay(ms)";
            hotkeyComboBoxHint = "Hot key";
            
            // Global
            changeHotkey = "Choose a hot key";      
            mouseSideButton_1 = "Mouse side button 1";
            mouseSideButton_2 = "Mouse side button 2";
        }
    }
}
