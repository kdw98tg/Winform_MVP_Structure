using MVP_Structure.Model;
using MVP_Structure.Service;
using MVP_Structure.View.BluetoothFormView;

namespace MVP_Structure.Presenter.BluetoothForm
{
    public class BluetoothFormPresenter : IBluetoothFormPresenter
    {
        private BluetoothService bluetoothService = null;
        private IBluetoothFormView view = null;

        public BluetoothFormPresenter(BluetoothService _bluetoothService)
        {
            bluetoothService = _bluetoothService;
        }

        public void SetView(IBluetoothFormView _view)
        {
            view = _view;
        }

        public void ConnectDevice()
        {
            try
            {
                bluetoothService.ConnectDevice();
                view.ShowConnectMessage();
            }
            catch (Exception ex)
            {
                view.ShowMessageBox("연결 실패");
            }
        }

        public BluetoothDevice GetDevice()
        {
            return bluetoothService.GetDevice();
        }
    }
}
