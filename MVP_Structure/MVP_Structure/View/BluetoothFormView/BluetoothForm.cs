using MVP_Structure.Model;
using MVP_Structure.View.BluetoothFormView;
using MVP_Structure.Presenter.BluetoothForm;

namespace MVP_Structure.View
{
    public partial class BluetoothForm : BaseForm, IBluetoothFormView
    {
        private IBluetoothFormPresenter presenter = null;
        private Action<BluetoothDevice> onDeviceConnected = null;

        public BluetoothForm(Action<BluetoothDevice> _onDeviceConnected)
        {
            InitializeComponent();
            presenter = new BluetoothFormPresenter(new Service.BluetoothService());
            presenter.SetView(this);
            onDeviceConnected = _onDeviceConnected;
        }

        private void buttonConnect_Click(object sender, EventArgs e)
        {
            presenter.ConnectDevice();
            BluetoothDevice device = presenter.GetDevice();
            onDeviceConnected?.Invoke(device);
        }

        public void ShowConnectMessage()
        {
            MessageBox.Show("연결완료!");
        }
    }
}
