using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;
using System.Drawing;

namespace MVP_Structure.View
{
    public partial class BaseForm : Form, IView
    {
        public BaseForm()
        {
            InitializeComponent();
        }

        public void ShowMessageBox(string? _text)
        {
            MessageBox.Show(_text);
        }

        public void ShowMessageBox(string? _text, string? _caption)
        {
            MessageBox.Show(_text, _caption);
        }

        public void ShowMessageBox(string? _text, string? _caption, MessageBoxButtons _buttons, MessageBoxIcon _icon)
        {
            MessageBox.Show(_text, _caption, _buttons, _icon);
        }

        protected void RunOnUiThread(Action _action)
        {
            if (InvokeRequired)
            {
                Invoke(() => _action);
            }
        }
    }
}
