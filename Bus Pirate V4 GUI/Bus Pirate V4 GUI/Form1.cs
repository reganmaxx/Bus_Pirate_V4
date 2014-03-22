using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;
using System.Threading;
using System.Diagnostics;

namespace Bus_Pirate_V4_GUI
{
    public partial class Form1 : Form
    {
        //Serial Port
        private SerialPort _serialPort;
        private int _portBaud;

        //BP4 parameters
        int _currMode = -1;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            loadCommPorts();
        }

        private void createSerialPort(string portName)
        {
            _serialPort = serialPort1;
            _serialPort.PortName = portName;
            //_serialPort.BaudRate = 9600;
            _serialPort.Open();
            Thread.Sleep(100);
            if (_serialPort.IsOpen)
            {
                statuslbl.Text = "Serial port Connected";
                _serialPort.DataReceived += new SerialDataReceivedEventHandler(serialPortDataReceived);
            }
            else
            {
                statuslbl.Text = "Serial port Failed to open";
            }
        }

        private void loadCommPorts()
        {
            string[] commPorts = SerialPort.GetPortNames();
            serialportscombobox.Items.AddRange(commPorts);

            if (commPorts.Length > 0)
            {
                serialportscombobox.SelectedIndex = serialportscombobox.Items.Count -1;
            }
        }

        private void serialPortDataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            int bytesToRead = _serialPort.BytesToRead;
            byte[] inBuffer = new byte[bytesToRead];
            _serialPort.Read(inBuffer, 0, bytesToRead);
            handleInBuffer(inBuffer);
        }

        private void handleInBuffer(byte[] inBuffer)
        {
            //check mode
            checkCurrMode(inBuffer);
            outputToRawTxtBox(System.Text.Encoding.ASCII.GetString(inBuffer));
            Debug.Print(System.Text.Encoding.ASCII.GetString(inBuffer));
        }

        private void serialconnect_Click(object sender, EventArgs e)
        {
            createSerialPort(serialportscombobox.SelectedItem.ToString());
        }

        private void outputToRawTxtBox(string msgToSend)
        {
            if (this.InvokeRequired)
            {
                rawtxtbox.Invoke(new Action(() => rawtxtbox.Text = rawtxtbox.Text + "\n" + msgToSend));
                //rawdatalistbox.Invoke(new Action(() => rawdatalistbox.Items.Add(msgToSend)));
            }
            else
            {
            }
        }

        private void sendbtn_Click(object sender, EventArgs e)
        {
            _serialPort.WriteLine(sendtxtbox.Text);
            //_serialPort.Write(sendtxtbox.Text + "\r");
        }

        private void checkCurrMode(byte[] inBuffer)
        {
            string response = System.Text.Encoding.ASCII.GetString(inBuffer);
            byte[] checkMenu = inBuffer.Take(1).ToArray();
            string request = System.Text.Encoding.ASCII.GetString(checkMenu);
            byte[] modeBuffer = inBuffer.Skip(3).Take(3).ToArray();
            string mode = System.Text.Encoding.ASCII.GetString(modeBuffer);
            if (request == "m")
            {
                changeModeLbl("Menu");
                _currMode = 0;
            }

            
        }

        private void changeModeLbl(string mode)
        {
            if (this.InvokeRequired)
            {
                Invoke((MethodInvoker)delegate { modelbl.Text = mode; });
            }
            else
            {
                modelbl.Text = mode;
            }
        }

        private void powerSupplysOn()
        {
            if (_serialPort.IsOpen)
            {
                _serialPort.WriteLine("m");
                _serialPort.WriteLine("W");
                _serialPort.WriteLine("m");
            }
        }

    }
}
