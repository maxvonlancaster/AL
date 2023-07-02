using NAudio.MediaFoundation;
using Sharer;

namespace AL.Services
{
    public class ArduinoService
    {
        private bool _flag = true;

        public void Main() 
        {
            InnitConnect();
        }

        private void InnitConnect()
        {
            var connection = new SharerConnection("COM3", 9600);
            while (_flag) 
            {
                Thread.Sleep(1000);
                connection.Connect();
                var result = connection.Call("Sum", 10, 12);
            }
            
        }
    }
}
