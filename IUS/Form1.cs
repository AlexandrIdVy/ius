using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.IO.Ports;
using System.Text.RegularExpressions;

namespace IUS
{
    public partial class Form1 : Form
    {
        private SerialPort serialport = new SerialPort();

        string pathInfo = "Info.txt";
        string pathVolts = "Volts.txt";
        string pathCoefficient = "Coefficient.txt";
        string pathLog = "Log.txt";
        bool data;

        public Form1()
        {
            InitializeComponent();
            
            serialport.DataReceived += new SerialDataReceivedEventHandler(port_DataReceived);

            label3.Text = "Ом" + "\u002f" + "\u25fb";
            label4.Text = "Ом" + "\u00B7" + "см";
        }

        private void Form1_Load(object sender, EventArgs e)
        {            
            if (serialport.IsOpen) {
                labelcom.Text = "Порт открыт";                
            }            
            else
            {
                if (SerialPort.GetPortNames().ToList().Contains(Convert.ToString(File.ReadAllLines(pathInfo, Encoding.UTF8).First())))
                {
                    serialport.PortName = Convert.ToString(File.ReadAllLines(pathInfo, Encoding.UTF8).First());
                    serialport.BaudRate = 9600;
                    serialport.DataBits = 8;
                    serialport.StopBits = StopBits.One;
                    serialport.Parity = Parity.None;
                    serialport.Handshake = Handshake.None;
                    serialport.ReceivedBytesThreshold = 8;
                    serialport.WriteBufferSize = 20;
                    serialport.ReadBufferSize = 20;
                    serialport.ReadTimeout = -1;
                    serialport.WriteTimeout = -1;
                    serialport.DtrEnable = false;
                    serialport.Open();
                    serialport.RtsEnable = true;
                    System.Threading.Thread.Sleep(100);
                    labelcom.Text = "Порт открыт";

                    if (Convert.ToInt32(File.ReadAllLines(pathVolts, Encoding.UTF8).First()) == 1)
                    {                        
                        radio1.Checked = true;
                    }
                    else if (Convert.ToInt32(File.ReadAllLines(pathVolts, Encoding.UTF8).First()) == 500)
                    {
                        radio500.Checked = true;
                    }
                    else if (Convert.ToInt32(File.ReadAllLines(pathVolts, Encoding.UTF8).First()) == 150)
                    {
                        radio150.Checked = true;
                    }

                    Coef.Text = Convert.ToString(File.ReadAllLines(pathCoefficient, Encoding.UTF8).First());
                }
                else
                {
                    labelcom.Text = "Порт не существует";
                    radio1.Enabled = false;
                    radio150.Enabled = false;
                    radio500.Enabled = false;
                    buttonCoef.Enabled = false;
                    buttonCurr.Enabled = false;                    
                    buttonr.Enabled = false;
                    buttonRS.Enabled = false;
                }
                
            }
        }
        private void Current(string msg)
        {
            Curr.Invoke(new EventHandler(delegate
            {
                Curr.AppendText(msg);                

                if (Curr.Text.Length > 5)
                {
                    data = false;
                    System.Threading.Thread.Sleep(400);
                    serialport.WriteLine("#080" + (char)0x0D);
                }
            })
            );
        }
        private void Voltage(string msg)
        {
            Volta.Invoke(new EventHandler(delegate { Volta.AppendText(msg); }));
        }

        private void port_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            this.Invoke(new EventHandler(AddRecieveCurr));            
        }
        private void AddRecieveCurr(object s, EventArgs e)
        {            
            System.Threading.Thread.Sleep(400);            
            byte[] dataR = new byte[serialport.BytesToRead];
            serialport.Read(dataR, 0, dataR.Length);
            
            if (data)
            {
                for (int i = 5; i < dataR.Length; i += 1)
                {
                    Current(((char)dataR[i]).ToString());
                }
            }
            else
            {
                for (int i = 2; i < dataR.Length; i += 1)
                {
                    Voltage(((char)dataR[i]).ToString());
                }
            }
            serialport.DiscardInBuffer();
        }

        private void TextBoxCoef_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8 && number != 44)
            {
                e.Handled = true;
            }
        }

        private void TextBoxCurr_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8 && number != 44)
            {
                e.Handled = true;
            }
        }

        private void TextBoxhigh_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8 && number != 44)
            {
                e.Handled = true;
            }
        }  

        private void ButtonCurr_Click(object sender, EventArgs e)
        {
            if (textBoxCurr.Text == "")
            {
                MessageBox.Show("Значение не введено!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.DialogResult = DialogResult.None;
            }
            else
            {
                Curr.Text = "";
                Volta.Text = "";
                labelRS.Text = "";
                high.Text = "";
                labelr.Text = "";

                data = true;

                double part = Convert.ToDouble(textBoxCurr.Text);
                string s = string.Format("{0:f3}", part);
                s = s.PadLeft(6, '0');
                s = s.Replace(',', '.');
                s = "#0A0" + s;

                serialport.WriteLine(s + (char)0x0D);
                System.Threading.Thread.Sleep(400);
                serialport.WriteLine("$0A80" + (char)0x0D);
            }            
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {            
            if (serialport.IsOpen)
            {
                serialport.DiscardOutBuffer();
                serialport.DiscardInBuffer();

                serialport.Close();
            }
        }   
        
        private void Radio150_Click(object sender, EventArgs e)
        {
            Curr.Text = "";
            Volta.Text = "";
            data = false;
            File.WriteAllText(pathVolts, "150");
            serialport.WriteLine("%08080C0680" + (char)0x0D);
            System.Threading.Thread.Sleep(400);
            serialport.WriteLine("#080" + (char)0x0D);
        }

        private void Radio500_Click(object sender, EventArgs e)
        {
            Curr.Text = "";
            Volta.Text = "";
            data = false;
            File.WriteAllText(pathVolts, "500");
            serialport.WriteLine("%08080B0680" + (char)0x0D);
            System.Threading.Thread.Sleep(400);
            serialport.WriteLine("#080" + (char)0x0D);
        }

        private void Radio1_Click(object sender, EventArgs e)
        {
            Curr.Text = "";
            Volta.Text = "";
            data = false;
            File.WriteAllText(pathVolts, "1");
            serialport.WriteLine("%08080A0680" + (char)0x0D);
            System.Threading.Thread.Sleep(400);
            serialport.WriteLine("#080" + (char)0x0D);
        }

        private void ButtonRS_Click(object sender, EventArgs e)
        {
            if (Curr.Text == "" || textBoxCurr.Text == "")
            {
                MessageBox.Show("Значение не введено!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.DialogResult = DialogResult.None;
            }
            else
            {
                string U = Volta.Text;
                U = U.Replace('.', ',');
                string I = Curr.Text;
                I = I.Replace('.', ',');
                double RS = Convert.ToDouble(U) / Convert.ToDouble(I) * Convert.ToDouble(Coef.Text);
                labelRS.Text = string.Format("{0:f2}", RS);

                Story();
            }
        }

        private void Buttonr_Click(object sender, EventArgs e)
        {
            if (high.Text == "" || Curr.Text == "" || textBoxCurr.Text == "")
            {
                MessageBox.Show("Значение не введено!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.DialogResult = DialogResult.None;
            }
            else
            {
                double d = Convert.ToDouble(high.Text);
                d = d / 10000;
                string U = Volta.Text;
                U = U.Replace('.', ',');
                string I = Curr.Text;
                I = I.Replace('.', ',');
                double r = Convert.ToDouble(U) / Convert.ToDouble(I) * d;
                labelr.Text = string.Format("{0:#.##E+00}", r);

                Story();
            }            
        }

        private void ButtonCoef_Click(object sender, EventArgs e)
        {
            if (Coef.Text == "")
            {
                MessageBox.Show("Значение не введено!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.DialogResult = DialogResult.None;
            }
            else
            {
                File.WriteAllText(pathCoefficient, Coef.Text);               
            }
        }

        private void Story()
        {
            if (History.Lines.Length == 1000)
            {
                History.Clear();
            }
            else
            {
                History.Text += "----------------------" + DateTime.Now.ToString() + "----------------------" + "\r\n";
                History.Text += "" + "\r\n";
                History.Text += "Поверхностное сопротивление: " + labelRS.Text + " Ом" + "\u002f" + "\u25fb" + "\r\n";
                History.Text += "Удельное сопротивление: " + labelr.Text + " Ом" + "\u00B7" + "см" + "\r\n";
                History.Text += "................................................................................." + "\r\n";
                History.Text += "Толщина слоя: " + high.Text + " мкм" + "\r\n";
                History.Text += "Коэффициент: " + Coef.Text + "\r\n";
                History.Text += "Уставка значения тока: " + textBoxCurr.Text + " мА" + "\r\n";
                History.Text += "Фактическое значение тока: " + Regex.Replace(Curr.Text, @"[\r\n]", "") + " мА" + "\r\n";
                History.Text += "Измеренное напряжение: " + Regex.Replace(Volta.Text, @"[\r\n]", "") + " мВ" + "\r\n";
                History.Text += "" + "\r\n";
                History.SelectionStart = History.TextLength;
                History.ScrollToCaret();

                File.AppendAllText(pathLog, 
                    DateTime.Now.ToString() + ";" +
                    labelRS.Text + ";" +
                    labelr.Text + ";" +
                    high.Text + ";" +
                    Coef.Text + ";" +
                    textBoxCurr.Text + ";" +
                    Regex.Replace(Curr.Text, @"[\r\n]", "") + ";" +
                    Regex.Replace(Volta.Text, @"[\r\n]", "") + "\r\n");
            }
        } 
    }
}
