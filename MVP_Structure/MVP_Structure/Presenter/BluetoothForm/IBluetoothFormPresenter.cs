using MVP_Structure.Model;
using MVP_Structure.View.BluetoothFormView;

namespace MVP_Structure.Presenter.BluetoothForm
{
    public interface IBluetoothFormPresenter
    {
        public void ConnectDevice();
        public BluetoothDevice GetDevice();
        public void SetView(IBluetoothFormView _view);
    }
}
