﻿using AL.Services.Interfaces;
using NAudio.MediaFoundation;
using Sharer;
using Telegram.Bot.Types;
using System.IO.Ports;


namespace AL.Services
{
    public class InoService : IArduinoService
    {
        private SerialPort? _serialPort;

        public InoService()
        {
            ConnectViaPort();
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

        private void ConnectViaPort() 
        {
            _serialPort = new SerialPort();
            _serialPort.PortName = "COM3";
            _serialPort.BaudRate = 9600;
            _serialPort.Open();
        }
    }
}
