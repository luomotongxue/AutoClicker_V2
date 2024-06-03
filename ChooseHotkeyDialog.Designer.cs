namespace AutoClicker_V2
{
    partial class ChooseHotkeyDialog
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            hotkeyLabel = new MaterialSkin.Controls.MaterialLabel();
            cancelButton = new MaterialSkin.Controls.MaterialButton();
            okButton = new MaterialSkin.Controls.MaterialButton();
            SuspendLayout();
            // 
            // hotkeyLabel
            // 
            hotkeyLabel.AutoSize = true;
            hotkeyLabel.Depth = 0;
            hotkeyLabel.Font = new Font("Roboto Light", 60F, FontStyle.Regular, GraphicsUnit.Pixel);
            hotkeyLabel.FontType = MaterialSkin.MaterialSkinManager.fontType.H2;
            hotkeyLabel.Location = new Point(206, 191);
            hotkeyLabel.MouseState = MaterialSkin.MouseState.HOVER;
            hotkeyLabel.Name = "hotkeyLabel";
            hotkeyLabel.Size = new Size(142, 72);
            hotkeyLabel.TabIndex = 0;
            hotkeyLabel.Text = "None";
            // 
            // cancelButton
            // 
            cancelButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            cancelButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            cancelButton.Depth = 0;
            cancelButton.HighEmphasis = true;
            cancelButton.Icon = null;
            cancelButton.Location = new Point(451, 405);
            cancelButton.Margin = new Padding(4, 6, 4, 6);
            cancelButton.MouseState = MaterialSkin.MouseState.HOVER;
            cancelButton.Name = "cancelButton";
            cancelButton.NoAccentTextColor = Color.Empty;
            cancelButton.Size = new Size(115, 36);
            cancelButton.TabIndex = 1;
            cancelButton.Text = "取消/Cancel";
            cancelButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            cancelButton.UseAccentColor = false;
            cancelButton.UseVisualStyleBackColor = true;
            cancelButton.Click += cancelButton_Click;
            // 
            // okButton
            // 
            okButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            okButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            okButton.Depth = 0;
            okButton.HighEmphasis = true;
            okButton.Icon = null;
            okButton.Location = new Point(364, 405);
            okButton.Margin = new Padding(4, 6, 4, 6);
            okButton.MouseState = MaterialSkin.MouseState.HOVER;
            okButton.Name = "okButton";
            okButton.NoAccentTextColor = Color.Empty;
            okButton.Size = new Size(79, 36);
            okButton.TabIndex = 2;
            okButton.Text = "确定/Ok";
            okButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            okButton.UseAccentColor = false;
            okButton.UseVisualStyleBackColor = true;
            okButton.Click += okButton_Click;
            // 
            // ChooseHotkeyDialog
            // 
            AutoScaleDimensions = new SizeF(11F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(573, 450);
            Controls.Add(okButton);
            Controls.Add(cancelButton);
            Controls.Add(hotkeyLabel);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "ChooseHotkeyDialog";
            Text = "Choose a hot key/选择热键";
            KeyDown += ChooseHotkeyDialog_KeyDown;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel hotkeyLabel;
        private MaterialSkin.Controls.MaterialButton cancelButton;
        private MaterialSkin.Controls.MaterialButton okButton;
    }
}