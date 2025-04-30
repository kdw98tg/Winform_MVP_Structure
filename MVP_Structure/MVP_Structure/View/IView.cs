namespace MVP_Structure.View
{
    public interface IView
    {
        public void ShowMessageBox(string? _text);
        public void ShowMessageBox(string? _text, string? _caption);
        public void ShowMessageBox(string? _text, string? _caption, MessageBoxButtons _buttons, MessageBoxIcon _icon);
    }
}
