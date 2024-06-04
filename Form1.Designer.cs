namespace AutoClicker_V2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            TabControl = new MaterialSkin.Controls.MaterialTabControl();
            AutoClickPage = new TabPage();
            autoclickTitleLabel = new MaterialSkin.Controls.MaterialLabel();
            materialCard1 = new MaterialSkin.Controls.MaterialCard();
            materialCard3 = new MaterialSkin.Controls.MaterialCard();
            chooseClickTypeHotkeyButton = new MaterialSkin.Controls.MaterialButton();
            changeClickTypeHotkeyComboBox = new MaterialSkin.Controls.MaterialComboBox();
            chooseHotkeyButton = new MaterialSkin.Controls.MaterialButton();
            hotkeyComboBox = new MaterialSkin.Controls.MaterialComboBox();
            unitComboBox = new MaterialSkin.Controls.MaterialComboBox();
            delayTextBox = new MaterialSkin.Controls.MaterialTextBox2();
            materialCard2 = new MaterialSkin.Controls.MaterialCard();
            RMB_RadioButton = new MaterialSkin.Controls.MaterialRadioButton();
            LMB_RadioButton = new MaterialSkin.Controls.MaterialRadioButton();
            clickKindLabel = new MaterialSkin.Controls.MaterialLabel();
            macroPage = new TabPage();
            materialCard7 = new MaterialSkin.Controls.MaterialCard();
            macroHotkeyComboBox = new MaterialSkin.Controls.MaterialComboBox();
            macroChangeHotKeyButton = new MaterialSkin.Controls.MaterialButton();
            materialCard6 = new MaterialSkin.Controls.MaterialCard();
            macroAddButton = new MaterialSkin.Controls.MaterialButton();
            materialButton1 = new MaterialSkin.Controls.MaterialButton();
            macroUnitComboBox = new MaterialSkin.Controls.MaterialComboBox();
            macroDurationTextBox = new MaterialSkin.Controls.MaterialTextBox2();
            macroDelayTextBox = new MaterialSkin.Controls.MaterialTextBox2();
            macroActionTypeComboBox = new MaterialSkin.Controls.MaterialComboBox();
            materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            actionTipLabel = new MaterialSkin.Controls.MaterialLabel();
            materialCard5 = new MaterialSkin.Controls.MaterialCard();
            macroActionListBox = new MaterialSkin.Controls.MaterialListBox();
            materialCard4 = new MaterialSkin.Controls.MaterialCard();
            newSSFButton = new MaterialSkin.Controls.MaterialButton();
            openSSFButton = new MaterialSkin.Controls.MaterialButton();
            macroFileNameLabel = new MaterialSkin.Controls.MaterialLabel();
            ssfTipLabel2 = new MaterialSkin.Controls.MaterialLabel();
            macroTitleLabel = new MaterialSkin.Controls.MaterialLabel();
            settingsPage = new TabPage();
            materialLabel8 = new MaterialSkin.Controls.MaterialLabel();
            materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            materialCard8 = new MaterialSkin.Controls.MaterialCard();
            materialButton2 = new MaterialSkin.Controls.MaterialButton();
            materialLabel9 = new MaterialSkin.Controls.MaterialLabel();
            materialLabel7 = new MaterialSkin.Controls.MaterialLabel();
            materialLabel6 = new MaterialSkin.Controls.MaterialLabel();
            materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            langComboBox = new MaterialSkin.Controls.MaterialComboBox();
            tipsLabel1 = new MaterialSkin.Controls.MaterialLabel();
            settingsTitleLabel = new MaterialSkin.Controls.MaterialLabel();
            TabControl.SuspendLayout();
            AutoClickPage.SuspendLayout();
            materialCard1.SuspendLayout();
            materialCard3.SuspendLayout();
            materialCard2.SuspendLayout();
            macroPage.SuspendLayout();
            materialCard7.SuspendLayout();
            materialCard6.SuspendLayout();
            materialCard5.SuspendLayout();
            materialCard4.SuspendLayout();
            settingsPage.SuspendLayout();
            materialCard8.SuspendLayout();
            SuspendLayout();
            // 
            // TabControl
            // 
            TabControl.Controls.Add(AutoClickPage);
            TabControl.Controls.Add(macroPage);
            TabControl.Controls.Add(settingsPage);
            TabControl.Depth = 0;
            TabControl.Dock = DockStyle.Fill;
            TabControl.Location = new Point(3, 64);
            TabControl.MouseState = MaterialSkin.MouseState.HOVER;
            TabControl.Multiline = true;
            TabControl.Name = "TabControl";
            TabControl.SelectedIndex = 0;
            TabControl.Size = new Size(945, 653);
            TabControl.TabIndex = 0;
            // 
            // AutoClickPage
            // 
            AutoClickPage.BackColor = Color.White;
            AutoClickPage.Controls.Add(autoclickTitleLabel);
            AutoClickPage.Controls.Add(materialCard1);
            AutoClickPage.Location = new Point(4, 33);
            AutoClickPage.Name = "AutoClickPage";
            AutoClickPage.Padding = new Padding(3);
            AutoClickPage.Size = new Size(937, 616);
            AutoClickPage.TabIndex = 0;
            AutoClickPage.Text = "AutoClick";
            // 
            // autoclickTitleLabel
            // 
            autoclickTitleLabel.AutoSize = true;
            autoclickTitleLabel.Depth = 0;
            autoclickTitleLabel.Font = new Font("思源黑体 CN Regular", 24F, FontStyle.Bold, GraphicsUnit.Pixel);
            autoclickTitleLabel.FontType = MaterialSkin.MaterialSkinManager.fontType.H5;
            autoclickTitleLabel.Location = new Point(10, 14);
            autoclickTitleLabel.MouseState = MaterialSkin.MouseState.HOVER;
            autoclickTitleLabel.Name = "autoclickTitleLabel";
            autoclickTitleLabel.Size = new Size(109, 33);
            autoclickTitleLabel.TabIndex = 1;
            autoclickTitleLabel.Text = "AutoClick";
            // 
            // materialCard1
            // 
            materialCard1.BackColor = Color.FromArgb(255, 255, 255);
            materialCard1.Controls.Add(materialCard3);
            materialCard1.Controls.Add(materialCard2);
            materialCard1.Controls.Add(clickKindLabel);
            materialCard1.Depth = 0;
            materialCard1.ForeColor = Color.FromArgb(222, 0, 0, 0);
            materialCard1.Location = new Point(10, 57);
            materialCard1.Margin = new Padding(14);
            materialCard1.MouseState = MaterialSkin.MouseState.HOVER;
            materialCard1.Name = "materialCard1";
            materialCard1.Padding = new Padding(14);
            materialCard1.Size = new Size(910, 542);
            materialCard1.TabIndex = 0;
            // 
            // materialCard3
            // 
            materialCard3.BackColor = Color.FromArgb(255, 255, 255);
            materialCard3.Controls.Add(chooseClickTypeHotkeyButton);
            materialCard3.Controls.Add(changeClickTypeHotkeyComboBox);
            materialCard3.Controls.Add(chooseHotkeyButton);
            materialCard3.Controls.Add(hotkeyComboBox);
            materialCard3.Controls.Add(unitComboBox);
            materialCard3.Controls.Add(delayTextBox);
            materialCard3.Depth = 0;
            materialCard3.ForeColor = Color.FromArgb(222, 0, 0, 0);
            materialCard3.Location = new Point(7, 97);
            materialCard3.Margin = new Padding(14);
            materialCard3.MouseState = MaterialSkin.MouseState.HOVER;
            materialCard3.Name = "materialCard3";
            materialCard3.Padding = new Padding(14);
            materialCard3.Size = new Size(888, 424);
            materialCard3.TabIndex = 3;
            // 
            // chooseClickTypeHotkeyButton
            // 
            chooseClickTypeHotkeyButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            chooseClickTypeHotkeyButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            chooseClickTypeHotkeyButton.Depth = 0;
            chooseClickTypeHotkeyButton.HighEmphasis = true;
            chooseClickTypeHotkeyButton.Icon = null;
            chooseClickTypeHotkeyButton.Location = new Point(729, 358);
            chooseClickTypeHotkeyButton.Margin = new Padding(4, 6, 4, 6);
            chooseClickTypeHotkeyButton.MouseState = MaterialSkin.MouseState.HOVER;
            chooseClickTypeHotkeyButton.Name = "chooseClickTypeHotkeyButton";
            chooseClickTypeHotkeyButton.NoAccentTextColor = Color.Empty;
            chooseClickTypeHotkeyButton.Size = new Size(159, 36);
            chooseClickTypeHotkeyButton.TabIndex = 5;
            chooseClickTypeHotkeyButton.Text = "Choose a hot key";
            chooseClickTypeHotkeyButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            chooseClickTypeHotkeyButton.UseAccentColor = false;
            chooseClickTypeHotkeyButton.UseVisualStyleBackColor = true;
            chooseClickTypeHotkeyButton.Click += chooseChangeClickTypeHotkeyButton_Click;
            // 
            // changeClickTypeHotkeyComboBox
            // 
            changeClickTypeHotkeyComboBox.AutoResize = false;
            changeClickTypeHotkeyComboBox.BackColor = Color.FromArgb(255, 255, 255);
            changeClickTypeHotkeyComboBox.Depth = 0;
            changeClickTypeHotkeyComboBox.DrawMode = DrawMode.OwnerDrawVariable;
            changeClickTypeHotkeyComboBox.DropDownHeight = 174;
            changeClickTypeHotkeyComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            changeClickTypeHotkeyComboBox.DropDownWidth = 121;
            changeClickTypeHotkeyComboBox.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            changeClickTypeHotkeyComboBox.ForeColor = Color.FromArgb(222, 0, 0, 0);
            changeClickTypeHotkeyComboBox.FormattingEnabled = true;
            changeClickTypeHotkeyComboBox.Hint = "Change click type hot key";
            changeClickTypeHotkeyComboBox.IntegralHeight = false;
            changeClickTypeHotkeyComboBox.ItemHeight = 43;
            changeClickTypeHotkeyComboBox.Items.AddRange(new object[] { "F2", "Mouse side button 1", "Mouse side button 2" });
            changeClickTypeHotkeyComboBox.Location = new Point(19, 358);
            changeClickTypeHotkeyComboBox.MaxDropDownItems = 4;
            changeClickTypeHotkeyComboBox.MouseState = MaterialSkin.MouseState.OUT;
            changeClickTypeHotkeyComboBox.Name = "changeClickTypeHotkeyComboBox";
            changeClickTypeHotkeyComboBox.Size = new Size(703, 49);
            changeClickTypeHotkeyComboBox.StartIndex = 0;
            changeClickTypeHotkeyComboBox.TabIndex = 4;
            changeClickTypeHotkeyComboBox.SelectedIndexChanged += changeClickTypeHotkeyComboBox_SelectedIndexChanged;
            // 
            // chooseHotkeyButton
            // 
            chooseHotkeyButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            chooseHotkeyButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            chooseHotkeyButton.Depth = 0;
            chooseHotkeyButton.HighEmphasis = true;
            chooseHotkeyButton.Icon = null;
            chooseHotkeyButton.Location = new Point(729, 308);
            chooseHotkeyButton.Margin = new Padding(4, 6, 4, 6);
            chooseHotkeyButton.MouseState = MaterialSkin.MouseState.HOVER;
            chooseHotkeyButton.Name = "chooseHotkeyButton";
            chooseHotkeyButton.NoAccentTextColor = Color.Empty;
            chooseHotkeyButton.Size = new Size(159, 36);
            chooseHotkeyButton.TabIndex = 3;
            chooseHotkeyButton.Text = "Choose a hot key";
            chooseHotkeyButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            chooseHotkeyButton.UseAccentColor = false;
            chooseHotkeyButton.UseVisualStyleBackColor = true;
            chooseHotkeyButton.Click += chooseHotkeyButton_Click;
            // 
            // hotkeyComboBox
            // 
            hotkeyComboBox.AutoResize = false;
            hotkeyComboBox.BackColor = Color.FromArgb(255, 255, 255);
            hotkeyComboBox.Depth = 0;
            hotkeyComboBox.DrawMode = DrawMode.OwnerDrawVariable;
            hotkeyComboBox.DropDownHeight = 174;
            hotkeyComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            hotkeyComboBox.DropDownWidth = 121;
            hotkeyComboBox.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            hotkeyComboBox.ForeColor = Color.FromArgb(222, 0, 0, 0);
            hotkeyComboBox.FormattingEnabled = true;
            hotkeyComboBox.Hint = "Click hot key";
            hotkeyComboBox.IntegralHeight = false;
            hotkeyComboBox.ItemHeight = 43;
            hotkeyComboBox.Items.AddRange(new object[] { "F8", "Mouse side button 1", "Mouse side button 2" });
            hotkeyComboBox.Location = new Point(19, 295);
            hotkeyComboBox.MaxDropDownItems = 4;
            hotkeyComboBox.MouseState = MaterialSkin.MouseState.OUT;
            hotkeyComboBox.Name = "hotkeyComboBox";
            hotkeyComboBox.Size = new Size(703, 49);
            hotkeyComboBox.StartIndex = 0;
            hotkeyComboBox.TabIndex = 2;
            hotkeyComboBox.SelectedIndexChanged += hotkeyComboBox_SelectedIndexChanged;
            // 
            // unitComboBox
            // 
            unitComboBox.AutoResize = false;
            unitComboBox.BackColor = Color.FromArgb(255, 255, 255);
            unitComboBox.Depth = 0;
            unitComboBox.DrawMode = DrawMode.OwnerDrawVariable;
            unitComboBox.DropDownHeight = 174;
            unitComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            unitComboBox.DropDownWidth = 121;
            unitComboBox.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            unitComboBox.ForeColor = Color.FromArgb(222, 0, 0, 0);
            unitComboBox.FormattingEnabled = true;
            unitComboBox.IntegralHeight = false;
            unitComboBox.ItemHeight = 43;
            unitComboBox.Items.AddRange(new object[] { "CPS", "Delay(ms)" });
            unitComboBox.Location = new Point(748, 16);
            unitComboBox.MaxDropDownItems = 4;
            unitComboBox.MouseState = MaterialSkin.MouseState.OUT;
            unitComboBox.Name = "unitComboBox";
            unitComboBox.Size = new Size(123, 49);
            unitComboBox.StartIndex = 0;
            unitComboBox.TabIndex = 1;
            // 
            // delayTextBox
            // 
            delayTextBox.AnimateReadOnly = false;
            delayTextBox.AutoCompleteMode = AutoCompleteMode.None;
            delayTextBox.AutoCompleteSource = AutoCompleteSource.None;
            delayTextBox.BackgroundImageLayout = ImageLayout.None;
            delayTextBox.CharacterCasing = CharacterCasing.Normal;
            delayTextBox.Depth = 0;
            delayTextBox.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            delayTextBox.HideSelection = true;
            delayTextBox.Hint = "Input CPS/Click Delay(ms)";
            delayTextBox.LeadingIcon = null;
            delayTextBox.Location = new Point(17, 17);
            delayTextBox.MaxLength = 32767;
            delayTextBox.MouseState = MaterialSkin.MouseState.OUT;
            delayTextBox.Name = "delayTextBox";
            delayTextBox.PasswordChar = '\0';
            delayTextBox.PrefixSuffixText = null;
            delayTextBox.ReadOnly = false;
            delayTextBox.RightToLeft = RightToLeft.No;
            delayTextBox.SelectedText = "";
            delayTextBox.SelectionLength = 0;
            delayTextBox.SelectionStart = 0;
            delayTextBox.ShortcutsEnabled = true;
            delayTextBox.Size = new Size(725, 48);
            delayTextBox.TabIndex = 0;
            delayTextBox.TabStop = false;
            delayTextBox.TextAlign = HorizontalAlignment.Left;
            delayTextBox.TrailingIcon = null;
            delayTextBox.UseSystemPasswordChar = false;
            // 
            // materialCard2
            // 
            materialCard2.BackColor = Color.FromArgb(255, 255, 255);
            materialCard2.Controls.Add(RMB_RadioButton);
            materialCard2.Controls.Add(LMB_RadioButton);
            materialCard2.Depth = 0;
            materialCard2.ForeColor = Color.FromArgb(222, 0, 0, 0);
            materialCard2.Location = new Point(7, 45);
            materialCard2.Margin = new Padding(14);
            materialCard2.MouseState = MaterialSkin.MouseState.HOVER;
            materialCard2.Name = "materialCard2";
            materialCard2.Padding = new Padding(14);
            materialCard2.Size = new Size(888, 39);
            materialCard2.TabIndex = 2;
            // 
            // RMB_RadioButton
            // 
            RMB_RadioButton.AutoSize = true;
            RMB_RadioButton.Depth = 0;
            RMB_RadioButton.Location = new Point(805, 2);
            RMB_RadioButton.Margin = new Padding(0);
            RMB_RadioButton.MouseLocation = new Point(-1, -1);
            RMB_RadioButton.MouseState = MaterialSkin.MouseState.HOVER;
            RMB_RadioButton.Name = "RMB_RadioButton";
            RMB_RadioButton.Ripple = true;
            RMB_RadioButton.Size = new Size(69, 37);
            RMB_RadioButton.TabIndex = 1;
            RMB_RadioButton.TabStop = true;
            RMB_RadioButton.Text = "RMB";
            RMB_RadioButton.UseVisualStyleBackColor = true;
            // 
            // LMB_RadioButton
            // 
            LMB_RadioButton.AutoSize = true;
            LMB_RadioButton.Checked = true;
            LMB_RadioButton.Depth = 0;
            LMB_RadioButton.Location = new Point(14, 2);
            LMB_RadioButton.Margin = new Padding(0);
            LMB_RadioButton.MouseLocation = new Point(-1, -1);
            LMB_RadioButton.MouseState = MaterialSkin.MouseState.HOVER;
            LMB_RadioButton.Name = "LMB_RadioButton";
            LMB_RadioButton.Ripple = true;
            LMB_RadioButton.Size = new Size(68, 37);
            LMB_RadioButton.TabIndex = 0;
            LMB_RadioButton.TabStop = true;
            LMB_RadioButton.Text = "LMB";
            LMB_RadioButton.UseVisualStyleBackColor = true;
            // 
            // clickKindLabel
            // 
            clickKindLabel.AutoSize = true;
            clickKindLabel.Depth = 0;
            clickKindLabel.Font = new Font("思源黑体 CN Regular", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            clickKindLabel.FontType = MaterialSkin.MaterialSkinManager.fontType.Subtitle2;
            clickKindLabel.Location = new Point(17, 14);
            clickKindLabel.MouseState = MaterialSkin.MouseState.HOVER;
            clickKindLabel.Name = "clickKindLabel";
            clickKindLabel.Size = new Size(65, 19);
            clickKindLabel.TabIndex = 1;
            clickKindLabel.Text = "Click type";
            // 
            // macroPage
            // 
            macroPage.BackColor = Color.White;
            macroPage.Controls.Add(materialCard7);
            macroPage.Controls.Add(materialCard6);
            macroPage.Controls.Add(materialLabel1);
            macroPage.Controls.Add(actionTipLabel);
            macroPage.Controls.Add(materialCard5);
            macroPage.Controls.Add(materialCard4);
            macroPage.Controls.Add(ssfTipLabel2);
            macroPage.Controls.Add(macroTitleLabel);
            macroPage.Location = new Point(4, 33);
            macroPage.Name = "macroPage";
            macroPage.Padding = new Padding(3);
            macroPage.Size = new Size(937, 616);
            macroPage.TabIndex = 1;
            macroPage.Text = "Macro";
            // 
            // materialCard7
            // 
            materialCard7.BackColor = Color.FromArgb(255, 255, 255);
            materialCard7.Controls.Add(macroHotkeyComboBox);
            materialCard7.Controls.Add(macroChangeHotKeyButton);
            materialCard7.Depth = 0;
            materialCard7.ForeColor = Color.FromArgb(222, 0, 0, 0);
            materialCard7.Location = new Point(6, 483);
            materialCard7.Margin = new Padding(14);
            materialCard7.MouseState = MaterialSkin.MouseState.HOVER;
            materialCard7.Name = "materialCard7";
            materialCard7.Padding = new Padding(14);
            materialCard7.Size = new Size(917, 123);
            materialCard7.TabIndex = 9;
            // 
            // macroHotkeyComboBox
            // 
            macroHotkeyComboBox.AutoResize = false;
            macroHotkeyComboBox.BackColor = Color.FromArgb(255, 255, 255);
            macroHotkeyComboBox.Depth = 0;
            macroHotkeyComboBox.DrawMode = DrawMode.OwnerDrawVariable;
            macroHotkeyComboBox.DropDownHeight = 174;
            macroHotkeyComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            macroHotkeyComboBox.DropDownWidth = 121;
            macroHotkeyComboBox.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            macroHotkeyComboBox.ForeColor = Color.FromArgb(222, 0, 0, 0);
            macroHotkeyComboBox.FormattingEnabled = true;
            macroHotkeyComboBox.Hint = "Hot key";
            macroHotkeyComboBox.IntegralHeight = false;
            macroHotkeyComboBox.ItemHeight = 43;
            macroHotkeyComboBox.Items.AddRange(new object[] { "F8", "Mouse side button 1", "Mouse side button 2" });
            macroHotkeyComboBox.Location = new Point(19, 17);
            macroHotkeyComboBox.MaxDropDownItems = 4;
            macroHotkeyComboBox.MouseState = MaterialSkin.MouseState.OUT;
            macroHotkeyComboBox.Name = "macroHotkeyComboBox";
            macroHotkeyComboBox.Size = new Size(881, 49);
            macroHotkeyComboBox.StartIndex = 0;
            macroHotkeyComboBox.TabIndex = 7;
            // 
            // macroChangeHotKeyButton
            // 
            macroChangeHotKeyButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            macroChangeHotKeyButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            macroChangeHotKeyButton.Depth = 0;
            macroChangeHotKeyButton.FlatStyle = FlatStyle.Flat;
            macroChangeHotKeyButton.HighEmphasis = true;
            macroChangeHotKeyButton.Icon = null;
            macroChangeHotKeyButton.Location = new Point(750, 75);
            macroChangeHotKeyButton.Margin = new Padding(4, 6, 4, 6);
            macroChangeHotKeyButton.MouseState = MaterialSkin.MouseState.HOVER;
            macroChangeHotKeyButton.Name = "macroChangeHotKeyButton";
            macroChangeHotKeyButton.NoAccentTextColor = Color.Empty;
            macroChangeHotKeyButton.Size = new Size(152, 36);
            macroChangeHotKeyButton.TabIndex = 8;
            macroChangeHotKeyButton.Text = "Select a hot key";
            macroChangeHotKeyButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            macroChangeHotKeyButton.UseAccentColor = false;
            macroChangeHotKeyButton.UseVisualStyleBackColor = true;
            // 
            // materialCard6
            // 
            materialCard6.BackColor = Color.FromArgb(255, 255, 255);
            materialCard6.Controls.Add(macroAddButton);
            materialCard6.Controls.Add(materialButton1);
            materialCard6.Controls.Add(macroUnitComboBox);
            materialCard6.Controls.Add(macroDurationTextBox);
            materialCard6.Controls.Add(macroDelayTextBox);
            materialCard6.Controls.Add(macroActionTypeComboBox);
            materialCard6.Depth = 0;
            materialCard6.ForeColor = Color.FromArgb(222, 0, 0, 0);
            materialCard6.Location = new Point(606, 169);
            materialCard6.Margin = new Padding(14);
            materialCard6.MouseState = MaterialSkin.MouseState.HOVER;
            materialCard6.Name = "materialCard6";
            materialCard6.Padding = new Padding(14);
            materialCard6.Size = new Size(317, 307);
            materialCard6.TabIndex = 6;
            // 
            // macroAddButton
            // 
            macroAddButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            macroAddButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            macroAddButton.Depth = 0;
            macroAddButton.HighEmphasis = true;
            macroAddButton.Icon = null;
            macroAddButton.Location = new Point(148, 268);
            macroAddButton.Margin = new Padding(4, 6, 4, 6);
            macroAddButton.MouseState = MaterialSkin.MouseState.HOVER;
            macroAddButton.Name = "macroAddButton";
            macroAddButton.NoAccentTextColor = Color.Empty;
            macroAddButton.Size = new Size(64, 36);
            macroAddButton.TabIndex = 5;
            macroAddButton.Text = "Add";
            macroAddButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            macroAddButton.UseAccentColor = false;
            macroAddButton.UseVisualStyleBackColor = true;
            // 
            // materialButton1
            // 
            materialButton1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            materialButton1.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            materialButton1.Depth = 0;
            materialButton1.HighEmphasis = true;
            materialButton1.Icon = null;
            materialButton1.Location = new Point(220, 268);
            materialButton1.Margin = new Padding(4, 6, 4, 6);
            materialButton1.MouseState = MaterialSkin.MouseState.HOVER;
            materialButton1.Name = "materialButton1";
            materialButton1.NoAccentTextColor = Color.Empty;
            materialButton1.Size = new Size(81, 36);
            materialButton1.TabIndex = 4;
            materialButton1.Text = "Remove";
            materialButton1.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            materialButton1.UseAccentColor = false;
            materialButton1.UseVisualStyleBackColor = true;
            // 
            // macroUnitComboBox
            // 
            macroUnitComboBox.AutoResize = false;
            macroUnitComboBox.BackColor = Color.FromArgb(255, 255, 255);
            macroUnitComboBox.Depth = 0;
            macroUnitComboBox.DrawMode = DrawMode.OwnerDrawVariable;
            macroUnitComboBox.DropDownHeight = 174;
            macroUnitComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            macroUnitComboBox.DropDownWidth = 121;
            macroUnitComboBox.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            macroUnitComboBox.ForeColor = Color.FromArgb(222, 0, 0, 0);
            macroUnitComboBox.FormattingEnabled = true;
            macroUnitComboBox.IntegralHeight = false;
            macroUnitComboBox.ItemHeight = 43;
            macroUnitComboBox.Items.AddRange(new object[] { "CPS", "Delay(ms)" });
            macroUnitComboBox.Location = new Point(204, 72);
            macroUnitComboBox.MaxDropDownItems = 4;
            macroUnitComboBox.MouseState = MaterialSkin.MouseState.OUT;
            macroUnitComboBox.Name = "macroUnitComboBox";
            macroUnitComboBox.Size = new Size(96, 49);
            macroUnitComboBox.StartIndex = 0;
            macroUnitComboBox.TabIndex = 3;
            // 
            // macroDurationTextBox
            // 
            macroDurationTextBox.AnimateReadOnly = false;
            macroDurationTextBox.AutoCompleteMode = AutoCompleteMode.None;
            macroDurationTextBox.AutoCompleteSource = AutoCompleteSource.None;
            macroDurationTextBox.BackgroundImageLayout = ImageLayout.None;
            macroDurationTextBox.CharacterCasing = CharacterCasing.Normal;
            macroDurationTextBox.Depth = 0;
            macroDurationTextBox.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            macroDurationTextBox.HideSelection = true;
            macroDurationTextBox.Hint = "Duration";
            macroDurationTextBox.LeadingIcon = null;
            macroDurationTextBox.Location = new Point(17, 126);
            macroDurationTextBox.MaxLength = 32767;
            macroDurationTextBox.MouseState = MaterialSkin.MouseState.OUT;
            macroDurationTextBox.Name = "macroDurationTextBox";
            macroDurationTextBox.PasswordChar = '\0';
            macroDurationTextBox.PrefixSuffixText = null;
            macroDurationTextBox.ReadOnly = false;
            macroDurationTextBox.RightToLeft = RightToLeft.No;
            macroDurationTextBox.SelectedText = "";
            macroDurationTextBox.SelectionLength = 0;
            macroDurationTextBox.SelectionStart = 0;
            macroDurationTextBox.ShortcutsEnabled = true;
            macroDurationTextBox.Size = new Size(282, 48);
            macroDurationTextBox.TabIndex = 2;
            macroDurationTextBox.TabStop = false;
            macroDurationTextBox.TextAlign = HorizontalAlignment.Left;
            macroDurationTextBox.TrailingIcon = null;
            macroDurationTextBox.UseSystemPasswordChar = false;
            // 
            // macroDelayTextBox
            // 
            macroDelayTextBox.AnimateReadOnly = false;
            macroDelayTextBox.AutoCompleteMode = AutoCompleteMode.None;
            macroDelayTextBox.AutoCompleteSource = AutoCompleteSource.None;
            macroDelayTextBox.BackgroundImageLayout = ImageLayout.None;
            macroDelayTextBox.CharacterCasing = CharacterCasing.Normal;
            macroDelayTextBox.Depth = 0;
            macroDelayTextBox.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            macroDelayTextBox.HideSelection = true;
            macroDelayTextBox.Hint = "Input CPS/Delay(ms)";
            macroDelayTextBox.LeadingIcon = null;
            macroDelayTextBox.Location = new Point(17, 72);
            macroDelayTextBox.MaxLength = 32767;
            macroDelayTextBox.MouseState = MaterialSkin.MouseState.OUT;
            macroDelayTextBox.Name = "macroDelayTextBox";
            macroDelayTextBox.PasswordChar = '\0';
            macroDelayTextBox.PrefixSuffixText = null;
            macroDelayTextBox.ReadOnly = false;
            macroDelayTextBox.RightToLeft = RightToLeft.No;
            macroDelayTextBox.SelectedText = "";
            macroDelayTextBox.SelectionLength = 0;
            macroDelayTextBox.SelectionStart = 0;
            macroDelayTextBox.ShortcutsEnabled = true;
            macroDelayTextBox.Size = new Size(181, 48);
            macroDelayTextBox.TabIndex = 1;
            macroDelayTextBox.TabStop = false;
            macroDelayTextBox.TextAlign = HorizontalAlignment.Left;
            macroDelayTextBox.TrailingIcon = null;
            macroDelayTextBox.UseSystemPasswordChar = false;
            // 
            // macroActionTypeComboBox
            // 
            macroActionTypeComboBox.AutoResize = false;
            macroActionTypeComboBox.BackColor = Color.FromArgb(255, 255, 255);
            macroActionTypeComboBox.Depth = 0;
            macroActionTypeComboBox.DrawMode = DrawMode.OwnerDrawVariable;
            macroActionTypeComboBox.DropDownHeight = 174;
            macroActionTypeComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            macroActionTypeComboBox.DropDownWidth = 121;
            macroActionTypeComboBox.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            macroActionTypeComboBox.ForeColor = Color.FromArgb(222, 0, 0, 0);
            macroActionTypeComboBox.FormattingEnabled = true;
            macroActionTypeComboBox.Hint = "Action Type";
            macroActionTypeComboBox.IntegralHeight = false;
            macroActionTypeComboBox.ItemHeight = 43;
            macroActionTypeComboBox.Items.AddRange(new object[] { "Click", "Wait" });
            macroActionTypeComboBox.Location = new Point(17, 17);
            macroActionTypeComboBox.MaxDropDownItems = 4;
            macroActionTypeComboBox.MouseState = MaterialSkin.MouseState.OUT;
            macroActionTypeComboBox.Name = "macroActionTypeComboBox";
            macroActionTypeComboBox.Size = new Size(283, 49);
            macroActionTypeComboBox.StartIndex = 0;
            macroActionTypeComboBox.TabIndex = 0;
            macroActionTypeComboBox.SelectedIndexChanged += macroActionTypeComboBox_SelectedIndexChanged;
            // 
            // materialLabel1
            // 
            materialLabel1.AutoSize = true;
            materialLabel1.Depth = 0;
            materialLabel1.Font = new Font("思源黑体 CN Medium", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel1.Location = new Point(606, 132);
            materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel1.Name = "materialLabel1";
            materialLabel1.Size = new Size(83, 23);
            materialLabel1.TabIndex = 5;
            materialLabel1.Text = "Add action";
            // 
            // actionTipLabel
            // 
            actionTipLabel.AutoSize = true;
            actionTipLabel.Depth = 0;
            actionTipLabel.Font = new Font("思源黑体 CN Medium", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            actionTipLabel.Location = new Point(6, 132);
            actionTipLabel.MouseState = MaterialSkin.MouseState.HOVER;
            actionTipLabel.Name = "actionTipLabel";
            actionTipLabel.Size = new Size(78, 23);
            actionTipLabel.TabIndex = 4;
            actionTipLabel.Text = "Action list";
            // 
            // materialCard5
            // 
            materialCard5.BackColor = Color.FromArgb(255, 255, 255);
            materialCard5.Controls.Add(macroActionListBox);
            materialCard5.Depth = 0;
            materialCard5.ForeColor = Color.FromArgb(222, 0, 0, 0);
            materialCard5.Location = new Point(6, 169);
            materialCard5.Margin = new Padding(14);
            materialCard5.MouseState = MaterialSkin.MouseState.HOVER;
            materialCard5.Name = "materialCard5";
            materialCard5.Padding = new Padding(14);
            materialCard5.Size = new Size(591, 307);
            materialCard5.TabIndex = 3;
            // 
            // macroActionListBox
            // 
            macroActionListBox.BackColor = Color.White;
            macroActionListBox.BorderColor = Color.LightGray;
            macroActionListBox.Depth = 0;
            macroActionListBox.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            macroActionListBox.Location = new Point(14, 17);
            macroActionListBox.MouseState = MaterialSkin.MouseState.HOVER;
            macroActionListBox.Name = "macroActionListBox";
            macroActionListBox.SelectedIndex = -1;
            macroActionListBox.SelectedItem = null;
            macroActionListBox.Size = new Size(560, 287);
            macroActionListBox.TabIndex = 0;
            // 
            // materialCard4
            // 
            materialCard4.BackColor = Color.FromArgb(255, 255, 255);
            materialCard4.Controls.Add(newSSFButton);
            materialCard4.Controls.Add(openSSFButton);
            materialCard4.Controls.Add(macroFileNameLabel);
            materialCard4.Depth = 0;
            materialCard4.ForeColor = Color.FromArgb(222, 0, 0, 0);
            materialCard4.Location = new Point(6, 74);
            materialCard4.Margin = new Padding(14);
            materialCard4.MouseState = MaterialSkin.MouseState.HOVER;
            materialCard4.Name = "materialCard4";
            materialCard4.Padding = new Padding(14);
            materialCard4.Size = new Size(917, 53);
            materialCard4.TabIndex = 2;
            // 
            // newSSFButton
            // 
            newSSFButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            newSSFButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            newSSFButton.Depth = 0;
            newSSFButton.HighEmphasis = true;
            newSSFButton.Icon = null;
            newSSFButton.Location = new Point(838, 7);
            newSSFButton.Margin = new Padding(4, 6, 4, 6);
            newSSFButton.MouseState = MaterialSkin.MouseState.HOVER;
            newSSFButton.Name = "newSSFButton";
            newSSFButton.NoAccentTextColor = Color.Empty;
            newSSFButton.Size = new Size(64, 36);
            newSSFButton.TabIndex = 2;
            newSSFButton.Text = "New";
            newSSFButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            newSSFButton.UseAccentColor = false;
            newSSFButton.UseVisualStyleBackColor = true;
            newSSFButton.Click += newSSFButton_Click;
            // 
            // openSSFButton
            // 
            openSSFButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            openSSFButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            openSSFButton.Depth = 0;
            openSSFButton.HighEmphasis = true;
            openSSFButton.Icon = null;
            openSSFButton.Location = new Point(766, 7);
            openSSFButton.Margin = new Padding(4, 6, 4, 6);
            openSSFButton.MouseState = MaterialSkin.MouseState.HOVER;
            openSSFButton.Name = "openSSFButton";
            openSSFButton.NoAccentTextColor = Color.Empty;
            openSSFButton.Size = new Size(64, 36);
            openSSFButton.TabIndex = 1;
            openSSFButton.Text = "Open";
            openSSFButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            openSSFButton.UseAccentColor = false;
            openSSFButton.UseVisualStyleBackColor = true;
            openSSFButton.Click += openSSFButton_Click;
            // 
            // macroFileNameLabel
            // 
            macroFileNameLabel.AutoSize = true;
            macroFileNameLabel.Depth = 0;
            macroFileNameLabel.Font = new Font("思源黑体 CN Medium", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            macroFileNameLabel.Location = new Point(17, 14);
            macroFileNameLabel.MouseState = MaterialSkin.MouseState.HOVER;
            macroFileNameLabel.Name = "macroFileNameLabel";
            macroFileNameLabel.Size = new Size(54, 23);
            macroFileNameLabel.TabIndex = 0;
            macroFileNameLabel.Text = "(None)";
            // 
            // ssfTipLabel2
            // 
            ssfTipLabel2.AutoSize = true;
            ssfTipLabel2.Depth = 0;
            ssfTipLabel2.Font = new Font("思源黑体 CN Medium", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            ssfTipLabel2.Location = new Point(6, 42);
            ssfTipLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            ssfTipLabel2.Name = "ssfTipLabel2";
            ssfTipLabel2.Size = new Size(138, 23);
            ssfTipLabel2.TabIndex = 1;
            ssfTipLabel2.Text = "Select a script file";
            // 
            // macroTitleLabel
            // 
            macroTitleLabel.AutoSize = true;
            macroTitleLabel.Depth = 0;
            macroTitleLabel.Font = new Font("思源黑体 CN Regular", 24F, FontStyle.Bold, GraphicsUnit.Pixel);
            macroTitleLabel.FontType = MaterialSkin.MaterialSkinManager.fontType.H5;
            macroTitleLabel.Location = new Point(6, 13);
            macroTitleLabel.MouseState = MaterialSkin.MouseState.HOVER;
            macroTitleLabel.Name = "macroTitleLabel";
            macroTitleLabel.Size = new Size(70, 33);
            macroTitleLabel.TabIndex = 0;
            macroTitleLabel.Text = "Macro";
            // 
            // settingsPage
            // 
            settingsPage.BackColor = Color.White;
            settingsPage.Controls.Add(materialLabel8);
            settingsPage.Controls.Add(materialLabel2);
            settingsPage.Controls.Add(materialCard8);
            settingsPage.Controls.Add(langComboBox);
            settingsPage.Controls.Add(tipsLabel1);
            settingsPage.Controls.Add(settingsTitleLabel);
            settingsPage.Location = new Point(4, 33);
            settingsPage.Name = "settingsPage";
            settingsPage.Padding = new Padding(3);
            settingsPage.Size = new Size(937, 616);
            settingsPage.TabIndex = 2;
            settingsPage.Text = "Settings";
            // 
            // materialLabel8
            // 
            materialLabel8.AutoSize = true;
            materialLabel8.Depth = 0;
            materialLabel8.Font = new Font("思源黑体 CN Medium", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel8.Location = new Point(293, 594);
            materialLabel8.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel8.Name = "materialLabel8";
            materialLabel8.Size = new Size(321, 23);
            materialLabel8.TabIndex = 5;
            materialLabel8.Text = "©2022-2024 luomoSoft.All right reserved.";
            // 
            // materialLabel2
            // 
            materialLabel2.AutoSize = true;
            materialLabel2.Depth = 0;
            materialLabel2.Font = new Font("思源黑体 CN Medium", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel2.Location = new Point(6, 141);
            materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel2.Name = "materialLabel2";
            materialLabel2.Size = new Size(85, 23);
            materialLabel2.TabIndex = 4;
            materialLabel2.Text = "关于/About";
            // 
            // materialCard8
            // 
            materialCard8.BackColor = Color.FromArgb(255, 255, 255);
            materialCard8.Controls.Add(materialButton2);
            materialCard8.Controls.Add(materialLabel9);
            materialCard8.Controls.Add(materialLabel7);
            materialCard8.Controls.Add(materialLabel6);
            materialCard8.Controls.Add(materialLabel5);
            materialCard8.Controls.Add(materialLabel4);
            materialCard8.Controls.Add(materialLabel3);
            materialCard8.Depth = 0;
            materialCard8.ForeColor = Color.FromArgb(222, 0, 0, 0);
            materialCard8.Location = new Point(6, 174);
            materialCard8.Margin = new Padding(14);
            materialCard8.MouseState = MaterialSkin.MouseState.HOVER;
            materialCard8.Name = "materialCard8";
            materialCard8.Padding = new Padding(14);
            materialCard8.Size = new Size(925, 136);
            materialCard8.TabIndex = 3;
            // 
            // materialButton2
            // 
            materialButton2.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            materialButton2.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            materialButton2.Depth = 0;
            materialButton2.HighEmphasis = true;
            materialButton2.Icon = null;
            materialButton2.Location = new Point(828, 91);
            materialButton2.Margin = new Padding(4, 6, 4, 6);
            materialButton2.MouseState = MaterialSkin.MouseState.HOVER;
            materialButton2.Name = "materialButton2";
            materialButton2.NoAccentTextColor = Color.Empty;
            materialButton2.Size = new Size(77, 36);
            materialButton2.TabIndex = 6;
            materialButton2.Text = "前往/Go";
            materialButton2.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            materialButton2.UseAccentColor = false;
            materialButton2.UseVisualStyleBackColor = true;
            materialButton2.Click += materialButton2_Click;
            // 
            // materialLabel9
            // 
            materialLabel9.AutoSize = true;
            materialLabel9.Depth = 0;
            materialLabel9.Font = new Font("思源黑体 CN Medium", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel9.Location = new Point(17, 103);
            materialLabel9.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel9.Name = "materialLabel9";
            materialLabel9.Size = new Size(53, 23);
            materialLabel9.TabIndex = 5;
            materialLabel9.Text = "Github";
            // 
            // materialLabel7
            // 
            materialLabel7.AutoSize = true;
            materialLabel7.Depth = 0;
            materialLabel7.Font = new Font("思源黑体 CN Medium", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel7.Location = new Point(65, 71);
            materialLabel7.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel7.Name = "materialLabel7";
            materialLabel7.Size = new Size(265, 23);
            materialLabel7.TabIndex = 4;
            materialLabel7.Text = "E-mail:luomotongxue@gmail.com";
            // 
            // materialLabel6
            // 
            materialLabel6.AutoSize = true;
            materialLabel6.Depth = 0;
            materialLabel6.Font = new Font("思源黑体 CN Medium", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel6.Location = new Point(66, 52);
            materialLabel6.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel6.Name = "materialLabel6";
            materialLabel6.Size = new Size(120, 23);
            materialLabel6.TabIndex = 3;
            materialLabel6.Text = "QQ:1453325399";
            // 
            // materialLabel5
            // 
            materialLabel5.AutoSize = true;
            materialLabel5.Depth = 0;
            materialLabel5.Font = new Font("思源黑体 CN Medium", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel5.Location = new Point(17, 33);
            materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel5.Name = "materialLabel5";
            materialLabel5.Size = new Size(167, 23);
            materialLabel5.TabIndex = 2;
            materialLabel5.Text = "联系我们/Content us:\r\n";
            // 
            // materialLabel4
            // 
            materialLabel4.AutoSize = true;
            materialLabel4.Depth = 0;
            materialLabel4.Font = new Font("思源黑体 CN Medium", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel4.Location = new Point(17, 33);
            materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel4.Name = "materialLabel4";
            materialLabel4.Size = new Size(1, 0);
            materialLabel4.TabIndex = 1;
            // 
            // materialLabel3
            // 
            materialLabel3.AutoSize = true;
            materialLabel3.Depth = 0;
            materialLabel3.Font = new Font("思源黑体 CN Medium", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel3.Location = new Point(17, 14);
            materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel3.Name = "materialLabel3";
            materialLabel3.Size = new Size(161, 23);
            materialLabel3.TabIndex = 0;
            materialLabel3.Text = "作者/Author:落墨同学";
            // 
            // langComboBox
            // 
            langComboBox.AutoResize = false;
            langComboBox.BackColor = Color.FromArgb(255, 255, 255);
            langComboBox.Depth = 0;
            langComboBox.DrawMode = DrawMode.OwnerDrawVariable;
            langComboBox.DropDownHeight = 174;
            langComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            langComboBox.DropDownWidth = 121;
            langComboBox.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            langComboBox.ForeColor = Color.FromArgb(222, 0, 0, 0);
            langComboBox.FormattingEnabled = true;
            langComboBox.IntegralHeight = false;
            langComboBox.ItemHeight = 43;
            langComboBox.Items.AddRange(new object[] { "简体中文", "English" });
            langComboBox.Location = new Point(6, 78);
            langComboBox.MaxDropDownItems = 4;
            langComboBox.MouseState = MaterialSkin.MouseState.OUT;
            langComboBox.Name = "langComboBox";
            langComboBox.Size = new Size(925, 49);
            langComboBox.StartIndex = 0;
            langComboBox.TabIndex = 2;
            langComboBox.SelectedIndexChanged += langComboBox_SelectedIndexChanged;
            // 
            // tipsLabel1
            // 
            tipsLabel1.AutoSize = true;
            tipsLabel1.Depth = 0;
            tipsLabel1.Font = new Font("思源黑体 CN Medium", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            tipsLabel1.Location = new Point(6, 56);
            tipsLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            tipsLabel1.Name = "tipsLabel1";
            tipsLabel1.Size = new Size(113, 23);
            tipsLabel1.TabIndex = 1;
            tipsLabel1.Text = "语言/Language";
            // 
            // settingsTitleLabel
            // 
            settingsTitleLabel.AutoSize = true;
            settingsTitleLabel.Depth = 0;
            settingsTitleLabel.Font = new Font("思源黑体 CN Regular", 24F, FontStyle.Bold, GraphicsUnit.Pixel);
            settingsTitleLabel.FontType = MaterialSkin.MaterialSkinManager.fontType.H5;
            settingsTitleLabel.Location = new Point(6, 12);
            settingsTitleLabel.MouseState = MaterialSkin.MouseState.HOVER;
            settingsTitleLabel.Name = "settingsTitleLabel";
            settingsTitleLabel.Size = new Size(93, 33);
            settingsTitleLabel.TabIndex = 0;
            settingsTitleLabel.Text = "Settings";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(11F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(951, 720);
            Controls.Add(TabControl);
            DrawerTabControl = TabControl;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimumSize = new Size(951, 720);
            Name = "Form1";
            Text = "AutoClicker";
            TabControl.ResumeLayout(false);
            AutoClickPage.ResumeLayout(false);
            AutoClickPage.PerformLayout();
            materialCard1.ResumeLayout(false);
            materialCard1.PerformLayout();
            materialCard3.ResumeLayout(false);
            materialCard3.PerformLayout();
            materialCard2.ResumeLayout(false);
            materialCard2.PerformLayout();
            macroPage.ResumeLayout(false);
            macroPage.PerformLayout();
            materialCard7.ResumeLayout(false);
            materialCard7.PerformLayout();
            materialCard6.ResumeLayout(false);
            materialCard6.PerformLayout();
            materialCard5.ResumeLayout(false);
            materialCard4.ResumeLayout(false);
            materialCard4.PerformLayout();
            settingsPage.ResumeLayout(false);
            settingsPage.PerformLayout();
            materialCard8.ResumeLayout(false);
            materialCard8.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private MaterialSkin.Controls.MaterialTabControl TabControl;
        private TabPage AutoClickPage;
        private TabPage macroPage;
        private MaterialSkin.Controls.MaterialCard materialCard1;
        private MaterialSkin.Controls.MaterialLabel clickKindLabel;
        private MaterialSkin.Controls.MaterialLabel autoclickTitleLabel;
        private MaterialSkin.Controls.MaterialCard materialCard3;
        private MaterialSkin.Controls.MaterialCard materialCard2;
        private MaterialSkin.Controls.MaterialRadioButton LMB_RadioButton;
        private MaterialSkin.Controls.MaterialComboBox unitComboBox;
        private MaterialSkin.Controls.MaterialButton chooseHotkeyButton;
        private MaterialSkin.Controls.MaterialComboBox hotkeyComboBox;
        private TabPage settingsPage;
        private MaterialSkin.Controls.MaterialComboBox langComboBox;
        private MaterialSkin.Controls.MaterialLabel tipsLabel1;
        private MaterialSkin.Controls.MaterialLabel settingsTitleLabel;
        private MaterialSkin.Controls.MaterialCard materialCard4;
        private MaterialSkin.Controls.MaterialButton newSSFButton;
        private MaterialSkin.Controls.MaterialButton openSSFButton;
        private MaterialSkin.Controls.MaterialLabel macroFileNameLabel;
        private MaterialSkin.Controls.MaterialLabel ssfTipLabel2;
        private MaterialSkin.Controls.MaterialLabel macroTitleLabel;
        private MaterialSkin.Controls.MaterialRadioButton RMB_RadioButton;
        private MaterialSkin.Controls.MaterialTextBox2 delayTextBox;
        private MaterialSkin.Controls.MaterialLabel actionTipLabel;
        private MaterialSkin.Controls.MaterialCard materialCard5;
        private MaterialSkin.Controls.MaterialListBox macroActionListBox;
        private MaterialSkin.Controls.MaterialCard materialCard6;
        private MaterialSkin.Controls.MaterialComboBox macroActionTypeComboBox;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialButton macroAddButton;
        private MaterialSkin.Controls.MaterialButton materialButton1;
        private MaterialSkin.Controls.MaterialComboBox macroUnitComboBox;
        private MaterialSkin.Controls.MaterialTextBox2 macroDurationTextBox;
        private MaterialSkin.Controls.MaterialTextBox2 macroDelayTextBox;
        private MaterialSkin.Controls.MaterialComboBox macroHotkeyComboBox;
        private MaterialSkin.Controls.MaterialButton macroChangeHotKeyButton;
        private MaterialSkin.Controls.MaterialCard materialCard7;
        private MaterialSkin.Controls.MaterialButton chooseClickTypeHotkeyButton;
        private MaterialSkin.Controls.MaterialComboBox changeClickTypeHotkeyComboBox;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialCard materialCard8;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialLabel materialLabel7;
        private MaterialSkin.Controls.MaterialLabel materialLabel6;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
        private MaterialSkin.Controls.MaterialLabel materialLabel8;
        private MaterialSkin.Controls.MaterialButton materialButton2;
        private MaterialSkin.Controls.MaterialLabel materialLabel9;
    }
}
