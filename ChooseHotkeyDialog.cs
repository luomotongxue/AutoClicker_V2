using MaterialSkin.Controls;

namespace AutoClicker_V2
{
    public partial class ChooseHotkeyDialog : MaterialForm
    {
        private Keys _key;
        private string _keyName;

        public Keys Key
        {
            get
            {
                return _key;
            }
            private set
            {
                _key = value;
            }
        }

        public string KeyName
        {
            get
            {
                return _keyName;
            }
            set
            {
                _keyName = value;
            }
        }

        public ChooseHotkeyDialog()
        {
            InitializeComponent();
            KeyPreview = true;
        }

        private void ChooseHotkeyDialog_KeyDown(object sender, KeyEventArgs e)
        {
            Key = e.KeyCode;
            KeyName = e.KeyCode.ToString();
            hotkeyLabel.Text = e.KeyCode.ToString();
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            this.Close();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
