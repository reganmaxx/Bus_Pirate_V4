using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO.Ports;
using System.Threading;
using System.Diagnostics;

namespace AINT304FireEventDemo
{
    class Communications
    {
        private SerialPort _serialPort;

        public event FireHitReceivedEventHandler FireHitReceived;

        public Communications(SerialPort serialPort)
        {
            _serialPort = serialPort;
            _serialPort.DataReceived += new SerialDataReceivedEventHandler(SerialPortDataReceived);
        }

        void SerialPortDataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            Thread.Sleep(100);
            if (_serialPort.IsOpen)
            {
                int bytesToRead = _serialPort.BytesToRead;
                byte[] buffer = new byte[bytesToRead];
                _serialPort.Read(buffer, 0, bytesToRead);
                
                //string msg = Encoding.ASCII.GetString(buffer);
                //Debug.Print(msg);
                
                HandleBuffer(buffer);
            }
        }

        private void HandleBuffer(byte[] buffer)
        {
            if (FireHitReceived != null)
            {
                FireHitReceivedEventArgs data = new FireHitReceivedEventArgs(buffer);
                FireHitReceived(data);
            }
        }
    }

    public delegate void FireHitReceivedEventHandler(FireHitReceivedEventArgs data);

    public class FireHitReceivedEventArgs : EventArgs
    {
        public byte[] Data { get; private set; }
        
        public FireHitReceivedEventArgs(byte[] data)
        {
            Data = data;
        }
    }
}
