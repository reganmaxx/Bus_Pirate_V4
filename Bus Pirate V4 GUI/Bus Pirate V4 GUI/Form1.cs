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
            setHiZ();
        }

        private void setHiZ()
        {
            outputToBP("m");
            Thread.Sleep(5);
            outputToBP("1");
            Thread.Sleep(5);
        }

        private void outputToRawTxtBox(string msgToSend)
        {
            if (this.InvokeRequired)
            {
                rawdatarichtxtbox.Invoke(new Action (()=> rawdatarichtxtbox.AppendText(msgToSend)));
                rawdatarichtxtbox.Invoke(new Action(() => rawdatarichtxtbox.ScrollToCaret()));
            }
            else
            {
            }
        }

        private void sendbtn_Click(object sender, EventArgs e)
        {
           outputToBP(sendtxtbox.Text);
        }

        private bool outputToBP(string msg)
        {
            if (_serialPort.IsOpen)
            {
                _serialPort.WriteLine(msg);
                return true;
            }
            else
            {
                changeStatusLbl("Failed to send message to Bus Pirate");
                return false;
            }
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
                //changeModeLbl("Menu");
                //_currMode = 0;
            }

            switch (mode)
            {
                case "HiZ":
                    _currMode = 1;
                    updateMode();
                    break;
                case "1WI":
                    _currMode = 2;
                    updateMode();
                    break;
                case "UAR":
                    _currMode = 3;
                    updateMode();
                    break;

            }
        }

        private void updateMode()
        {
            switch (_currMode)
            {
                case -1:
                    changeModeLbl("Mode");
                    break;
                case 0:
                    changeModeLbl("Menu");
                    break;
                case 1://all high impedance all off
                    changeModeLbl("HiZ");
                    break;
                case 2:
                    changeModeLbl("1-Wire");
                    break;
                case 3:
                    changeModeLbl("UART");
                    break;
                case 4:
                    changeModeLbl("I2C");
                    break;
                case 5:
                    changeModeLbl("SPI");
                    break;
                case 6:
                    changeModeLbl("JTAG");
                    break;
                case 7:
                    changeModeLbl("Raw2Wire");
                    break;
                case 8:
                    changeModeLbl("Raw3Wire");
                    break;
                case 9:
                    changeModeLbl("PC Keyboard");
                    break;
                case 10:
                    changeModeLbl("MIDI");
                    break;
                case 11:
                    changeModeLbl("LCD");
                    break;
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

        private void changeStatusLbl(string label)
        {
            if (this.InvokeRequired)
            {
                Invoke((MethodInvoker)delegate { statuslbl.Text = label; });
            }
            else
            {
                statuslbl.Text = label;
            }
        }

        private void macromenubtn_Click(object sender, EventArgs e)
        {
            outputToBP("(0)");
        }

        private void powersupplychckbox_CheckedChanged(object sender, EventArgs e)
        {
            if (powersupplychckbox.Checked == true && _serialPort.IsOpen)
            {
                bool ret = outputToBP("W");
                if (!ret) powersupplychckbox.Checked = false;
            }
            else if (powersupplychckbox.Checked == false && _serialPort.IsOpen)
            {
                bool ret = outputToBP("w");
                if (!ret) powersupplychckbox.Checked = false;
            }

        }

    }
}
