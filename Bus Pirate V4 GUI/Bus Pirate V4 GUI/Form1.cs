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

        //BP4 parameters
        int _currMode = -1;

        //voltmeter
        double _currentvoltage;
        bool _voltReq = false;

        //Frequency
        bool _freqReq = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            loadCommPorts();
            baudcombobox.SelectedIndex = 1;
        }

        private void createSerialPort(string portName)
        {
            _serialPort = serialPort1;
            _serialPort.PortName = portName;
            _serialPort.BaudRate = Convert.ToInt32(baudcombobox.SelectedItem.ToString());
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
            serialportscombobox.Items.Clear();
            serialportscombobox.Items.AddRange(commPorts);

            if (commPorts.Length > 0)
            {
                serialportscombobox.SelectedIndex = serialportscombobox.Items.Count -1;
            }
        }

        private void serialPortDataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            int bytesToRead = _serialPort.BytesToRead;
            Debug.Print(bytesToRead.ToString());
            byte[] inBuffer = new byte[bytesToRead];
            _serialPort.Read(inBuffer, 0, bytesToRead);

            handleInBuffer(inBuffer);
        }

        private void handleInBuffer(byte[] inBuffer)
        {
            checkCurrMode(inBuffer);
            if (System.Text.Encoding.ASCII.GetString(inBuffer).Contains('\b') && _voltReq)//continuously reading voltage
            {
                if (_currMode == 12)
                {
                    string data = System.Text.Encoding.ASCII.GetString(inBuffer);
                    data = removeUnwantedCharacters(data);
                    if (data[0] == 'D')
                    {
                        string voltage = data.Substring(data.IndexOf(":") + 2, 5);
                        if (voltage[4] == 'V')
                        {
                            _currentvoltage = Convert.ToDouble(voltage.Substring(0, voltage.IndexOf('V')));
                        }
                        voltstxtbox.Invoke(new Action(() => voltstxtbox.Text = _currentvoltage.ToString()));
                    }
                    else
                    {
                        while (data.Contains('V'))
                        {
                            if (data[0] == 'V') data = data.Substring(1, data.Length - 1);
                            _currentvoltage = Convert.ToDouble(data.Substring(0, data.IndexOf('V')));
                            voltstxtbox.Invoke(new Action(() => voltstxtbox.Text = _currentvoltage.ToString()));
                            data = data.Substring(data.IndexOf('V') + 1, data.Length - 5);
                            int length = data.Length;
                        }
                    }
                }
            }
            else if (System.Text.Encoding.ASCII.GetString(inBuffer).Contains("Hz") && _freqReq)//reading frequency
            {
                outputToRawTxtBox(System.Text.Encoding.ASCII.GetString(inBuffer));
                string data = System.Text.Encoding.ASCII.GetString(inBuffer);
                data = data.Substring(0, data.IndexOf('\r'));
                freqtxtbox.Invoke(new Action (()=> freqtxtbox.Text = data));
                _freqReq = false;
            }
            else if (System.Text.Encoding.ASCII.GetString(inBuffer)[0] == 'd' && _voltReq)//single voltage read
            {
                outputToRawTxtBox(System.Text.Encoding.ASCII.GetString(inBuffer));
                string data = System.Text.Encoding.ASCII.GetString(inBuffer);
                data = data.Substring(data.IndexOf(":")+1, 5);
                voltstxtbox.Invoke(new Action(() => voltstxtbox.Text = data));
                _voltReq = false;
            }
            else//all others
            {
                //check mode
                outputToRawTxtBox(System.Text.Encoding.ASCII.GetString(inBuffer));
                //Debug.Print(System.Text.Encoding.ASCII.GetString(inBuffer));
            }
        }

        private string removeUnwantedCharacters(string message)
        {
            while (message.Contains('\b'))
            {
                message = message.Remove(message.IndexOf('\b'),1);
            }
            return message;
        }


        private void serialconnect_Click(object sender, EventArgs e)
        {
            if (serialconnect.Text == "Connect")
            {
                createSerialPort(serialportscombobox.SelectedItem.ToString());
                setHiZ();
                serialconnect.Text = "Disconnect";
                refreshbtn.Enabled = false;
            }
            else
            {
                _serialPort.Close();
                serialconnect.Text = "Connect";
                refreshbtn.Enabled = true;
            }

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
                rawdatarichtxtbox.AppendText(msgToSend);
                rawdatarichtxtbox.ScrollToCaret();
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
                try
                {
                    _serialPort.WriteLine(msg);
                    return true;
                }
                catch
                {
                    changeStatusLbl("Failed to send message to Bus Pirate");
                    return false;
                }
            }
            else
            {
                changeStatusLbl("Failed to send message to Bus Pirate");
                return false;
            }
        }

        private void checkCurrMode(byte[] inBuffer)
        {
            if (inBuffer.Length > 4)
            {
                string response = System.Text.Encoding.ASCII.GetString(inBuffer);
                string mode = response.Substring(response.Length - 4, 3);
                if (mode == "-WI") mode = response.Substring(response.Length - 5, 3);
                //byte[] checkMenu = inBuffer.Take(1).ToArray();
                //string request = System.Text.Encoding.ASCII.GetString(checkMenu);
                //byte[] modeBuffer = inBuffer.Skip(3).Take(3).ToArray();
                //string mode = System.Text.Encoding.ASCII.GetString(modeBuffer);

                switch (mode)
                {
                    case "HiZ":
                        _currMode = 1;
                        updateMode();
                        break;
                    case "1-W":
                        _currMode = 2;
                        updateMode();
                        break;
                    case "UAR":
                        _currMode = 3;
                        updateMode();
                        break;
                    case "I2C":
                        _currMode = 4;
                        updateMode();
                        break;
                    case "SPI":
                        _currMode = 5;
                        updateMode();
                        break;
                    case "JTA":
                        _currMode = 6;
                        updateMode();
                        break;
                    case "2-W":
                        _currMode = 7;
                        updateMode();
                        break;
                    case "3-W":
                        _currMode = 8;
                        updateMode();
                        break;
                    case "LCD":
                        _currMode = 11;
                        updateMode();
                        break;
                    case "DIO":
                        _currMode = 13;
                        updateMode();
                        break;
                }
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
                    changeModeLbl("2-Wire");
                    break;
                case 8:
                    changeModeLbl("3-Wire");
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
                case 12:
                    changeModeLbl("Voltmeter");
                    break;
                case 13:
                    changeModeLbl("DIO");
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

        private void refreshbtn_Click(object sender, EventArgs e)
        {
            loadCommPorts();
        }

        private void resetbtn_Click(object sender, EventArgs e)
        {
            outputToBP("#");
        }

        private void selftestbtn_Click(object sender, EventArgs e)
        {
            outputToBP("~");
        }

        private void versionbtn_Click(object sender, EventArgs e)
        {
            outputToBP("i");
        }

        private void menubtn_Click(object sender, EventArgs e)
        {
            outputToBP("m");
        }

        private void voltmeterchckbox_CheckedChanged(object sender, EventArgs e)
        {
            if (voltmeterchckbox.Checked == true)
            {
                _voltReq = true;
                _currMode = 12;
                outputToBP("D");
                updateMode();
                //disable all other controls
            }
            else
            {
                _serialPort.DiscardInBuffer();
                _voltReq = false;
                _currMode = 0;
                outputToBP(" ");
                Thread.Sleep(100);
                outputToBP("m");
                updateMode();
                //enable all other controls
            }
            
        }

        private void auxcombobox_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (auxcombobox.SelectedIndex)
            {
                case 0:
                    outputToBP("a");
                    break;
                case 1:
                    outputToBP("A");
                    break;
                case 2:
                    outputToBP("@");
                    break;
            }
        }

        private void adconeshotbtn_Click(object sender, EventArgs e)
        {
            outputToBP("d");
            _voltReq = true;
        }

        private void freqbtn_Click(object sender, EventArgs e)
        {
            outputToBP("f");
            _freqReq = true;
        }

        private void formatcombobox_SelectedIndexChanged(object sender, EventArgs e)
        {
            outputToBP("o");
            Thread.Sleep(100);
            switch (formatcombobox.SelectedIndex)
            {
                case 0://hex
                    outputToBP("1");
                    break;
                case 1://dec
                    outputToBP("2");
                    break;
                case 2://bin
                    outputToBP("3");
                    break;
                case 3://raw
                    outputToBP("4");
                    break;
            }
        }

        private void pwmchckbox_CheckedChanged(object sender, EventArgs e)
        {
            if (pwmchckbox.Checked)
            {
                outputToBP("g");
            }
            else
            {
                outputToBP("g");
            }
        }

        private void helpbtn_Click(object sender, EventArgs e)
        {
            help help = new help();
            help.Show();
        }

        private void macrobtn1_Click(object sender, EventArgs e)
        {
            outputToBP("1");
        }

        private void macro2btn_Click(object sender, EventArgs e)
        {
            outputToBP("2");
        }

        private void macrobtn3_Click(object sender, EventArgs e)
        {
            outputToBP("3");
        }

        private void macrobtn4_Click(object sender, EventArgs e)
        {
            outputToBP("4");
        }

        private void macrobtn5_Click(object sender, EventArgs e)
        {
            outputToBP("5");
        }




    }
}
