using MVP_Structure.Model;
using MVP_Structure.Presenter.MainForm;
using MVP_Structure.View;
using MVP_Structure.View.MainFormView;

namespace MVP_Structure
{
    public partial class MainForm : BaseForm, IMainFormView
    {
        private IMainFormPresenter presenter = null;
        private int cnt = 2;

        public MainForm()
        {
            InitializeComponent();
        }

        public void Init(IMainFormPresenter _presenter)
        {
            presenter = _presenter;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            presenter.InitUserListView();
        }

        private void buttonBluetoothOption_Click(object sender, EventArgs e)
        {
            ShowBluetoothForm();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            User user = new User
            {
                UserId = cnt++,
                UserName = textBoxUserName.Text,
                UserAge = int.TryParse(textBoxUserAge.Text, out int age) ? age : -1
            };
            presenter.InsertUser(user);
        }

        public void AddUserToListView(User _userList)
        {
            string[] item =
            {
                _userList.UserId.ToString(),
                _userList.UserName,
                _userList.UserAge.ToString(),
            };
            ListViewItem listViewItem = new ListViewItem(item);

            listViewUser.Items.Add(listViewItem);
        }

        private void ShowBluetoothForm()
        {
            BluetoothForm bluetoothForm = new BluetoothForm(DisplayBluetoothDeviceName);
            bluetoothForm.ShowDialog();
        }

        private void DisplayBluetoothDeviceName(BluetoothDevice _device)
        {
            labelBluetoothDeviceName.Text = _device.DeviceName;
        }
    }
}