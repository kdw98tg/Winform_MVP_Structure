using MVP_Structure.Model;

namespace MVP_Structure.Service
{
    public class BluetoothService
    {
        private BluetoothDevice deviceInfo = null; //실제로는 디바이스 클래스 가져올 것임

        public void ConnectDevice()
        {
            deviceInfo = new BluetoothDevice
            {
                DeviceId = 1,
                DeviceName = "BluetoothDevice"
            };
        }

        public BluetoothDevice GetDevice()
        {
            return deviceInfo ?? throw new Exception();
        }
    }
}
