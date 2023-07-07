using AL.Services.Interfaces;
using NAudio.MediaFoundation;
using Sharer;
using System.IO.Ports;
using Telegram.Bot.Types;

namespace AL.Services
{
    public class ArduinoService : IArduinoService
    {
        private bool _flag = true;

        private SerialPort? _serialPort;

        public void Main()
        {
            ConnectViaPort();
            Demo();
        }

        private void Demo()
        {
            Write("1");
            Thread.Sleep(2000);
            Write("0");
            Thread.Sleep(2000);
            Write("1");
            Thread.Sleep(2000);
            Write("0");
            Thread.Sleep(2000);
            Write("1");
            Thread.Sleep(2000);
            Write("0");
            Thread.Sleep(2000);
        }

        // ledPin is by default 13
        public void Write(string message, string? ledPin = null) 
        {
            if (_serialPort != null) 
            {
                _serialPort.Write(message);
            }
        }

        public string ReadExisting() 
        {
            var message = "";
            if (_serialPort != null)
            {
                message = _serialPort.ReadExisting();
                Console.WriteLine(message);
            }
            return message;
        }

        private void InnitConnect()
        {
            var connection = new SharerConnection("COM3", 9600);
            connection.Connect();
            while (_flag) 
            {
                //Thread.Sleep(1000);
                
                var result = connection.Call("Sum", 10, 12);
            }
        }

        private void ConnectViaPort() 
        {
            _serialPort = new SerialPort();
            _serialPort.PortName = "COM3";
            _serialPort.BaudRate = 9600;
            _serialPort.Open();
            //while (true)
            //{
            //    string msg = _serialPort.ReadExisting();
            //    Console.WriteLine(msg);
            //    Thread.Sleep(2000);
            //}
        }
    }
}
