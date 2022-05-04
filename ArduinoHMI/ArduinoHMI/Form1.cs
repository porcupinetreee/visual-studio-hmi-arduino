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

namespace ArduinoHMI
{
    public partial class Form1 : Form
    {
        String[] ports;
        SerialPort serialport;
        bool isConnected = false;
        public Form1()
        {
            InitializeComponent();
            getAvailableComPorts();
        }
        

        private void aGauge1_ValueInRangeChanged(object sender, AGaugeApp.AGauge.ValueInRangeChangedEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (!isConnected)
            {
                connectToArduino();
            }
            else
            {
                disconnectFromArduino();
            }

        }
        private void disconnectFromArduino()
        {
            isConnected = false;
            serialport.Close();
            button4.Text = "CONNECT";
            button4.BackColor = Color.Green;

        }

        private void connectToArduino()
        {
            try
            {
                string selectedPort = ports[0];
                int baudRate = 9600;
                serialport = new SerialPort(selectedPort, baudRate, Parity.None, 8, StopBits.One);
                serialport.Open();
                button4.Text = "DISCONNECT";
                button4.BackColor = Color.Red;
                isConnected = true;
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message, "Bağlanma Hatası");
                throw;
            }
        }


        void getAvailableComPorts()
        {
            ports = SerialPort.GetPortNames();

        }

        int b1 = 0, b2 = 0, b3 = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            b1++;
            aGauge1.Value = 40;
            if(b1 % 2 == 1)
                label1.BackColor = Color.Green;
            else
                label1.BackColor = Color.Red;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            b2++;
            aGauge1.Value = 30;
            if (b2 % 2 == 1)
                label2.BackColor = Color.Green;
            else
                label2.BackColor = Color.Red;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            b3++;
            aGauge1.Value = 10;
            if (b3 % 2 == 1)
                label3.BackColor = Color.Green;
            else
                label3.BackColor = Color.Red;
        }
    }
}
