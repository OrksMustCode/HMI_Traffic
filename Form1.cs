using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HMI_Traffic
{
    public partial class Form1: Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                disableComponents();
                string[] ports = SerialPort.GetPortNames();
                comboBoxPort.DataSource = ports;
                string[] rates = { "9600", "19200", "31250", "57600", "115200" };
                comboBoxBaud.DataSource = rates;
                Image flip = pictureBox_LightNorth.Image;
                flip.RotateFlip(RotateFlipType.Rotate90FlipXY);
                pictureBox_LightNorth.Image = flip;
                Image flip2 = pictureBox_LightSouth.Image;
                flip2.RotateFlip(RotateFlipType.Rotate270FlipXY);
                pictureBox_LightSouth.Image = flip2;
                Image flip3 = pictureBoxWE.Image;
                flip3.RotateFlip(RotateFlipType.Rotate90FlipXY);
                pictureBoxWE.Image = flip3;
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                if (serialPort1.IsOpen)
                {
                    serialPort1.Close();
                }
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }

        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            string[] ports = SerialPort.GetPortNames();
            comboBoxPort.DataSource = ports;
        }

        private void buttonConnect_Click(object sender, EventArgs e)
        {
            try
            {
                if (!serialPort1.IsOpen)
                {
                    serialPort1.BaudRate = Convert.ToInt32(comboBoxBaud.Text);
                    serialPort1.PortName = comboBoxPort.Text;
                    serialPort1.Open();
                    progressBar1.Value = 100;
                    buttonConnect.Text = "DESCONECTAR";
                    buttonConnect.BackColor = Color.FromArgb(200, 0, 0);
                    buttonRefresh.Enabled = false;
                    comboBoxBaud.Enabled = false;
                    comboBoxPort.Enabled = false;
                    enableComponents();
                }
                else
                {
                    disableComponents();
                    progressBar1.Value = 0;
                    buttonConnect.Text = "CONECTAR";
                    buttonConnect.BackColor = Color.FromArgb(0, 200, 0);
                    buttonRefresh.Enabled = true;
                    comboBoxPort.Enabled = true;
                    comboBoxBaud.Enabled = true;
                    serialPort1.Close();
                }
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }

        private void disableComponents()
        {
            panel1.Visible = false;
            groupBox2.Enabled = false;
            groupBox3.Enabled = false;
            groupBox4.Enabled = false;
        }

        private void enableComponents()
        {
            panel1.Visible = true;
            groupBox2.Enabled = true;
            groupBox3.Enabled = true;
            groupBox4.Enabled = true;
            buttonN.Enabled = false;
            buttonS.Enabled = false;
            buttonE.Enabled = false;
            buttonW.Enabled = false;
        }
    }
}
