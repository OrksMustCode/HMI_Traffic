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
                Image flip3 = pictureBoxWE.Image;
                flip3.RotateFlip(RotateFlipType.Rotate90FlipXY);
                pictureBoxWE.Image = flip3;
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }

        public class Globals
        {
            private static int _seconds = 30;
            public static int Seconds
            {
                get
                {
                    return _seconds;
                }
                set
                {
                    _seconds = value;
                }
            }

            private static bool _ns = false;
            public static bool Ns
            {
                get
                {
                    return _ns;
                }
                set
                {
                    _ns = value;
                }
            }

            private static bool _we = false;
            public static bool We
            {
                get
                {
                    return _we;
                }
                set
                {
                    _we = value;
                }
            }

            private static int _timer = 10;
            public static int Timer
            {
                get
                {
                    return _timer;
                }
                set
                {
                    _timer = value;
                }
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
            timerSeconds.Enabled = false;
            turnOffLights();
            pictureBox_LightWest.Image = Properties.Resources.lightOff;
            pictureBox_LightEast.Image = Properties.Resources.lightOff;
            pictureBox_LightNorth.Image = Properties.Resources.lightOff;
            pictureBox_LightSouth.Image = Properties.Resources.lightOff;
            labelWE.Text = "--";
            labelNS.Text = "--";
            Globals.Seconds = Globals.Timer;
            Globals.Ns = false;
            Globals.We = false;
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
            buttonRestart.Enabled = false;
            timerSeconds.Enabled = true;
            labelNS.Text = "0";
            turnOffLights();
            pictureBox_LightWest.Image = Properties.Resources.green;
            serialPort1.WriteLine("$WGon");
            pictureBox_LightEast.Image = Properties.Resources.green;
            serialPort1.WriteLine("$EGon");
            pictureBox_LightNorth.Image = Properties.Resources.red;
            serialPort1.WriteLine("$NRon");
            Image flip = pictureBox_LightNorth.Image;
            flip.RotateFlip(RotateFlipType.Rotate90FlipXY);
            pictureBox_LightNorth.Image = flip;
            pictureBox_LightSouth.Image = Properties.Resources.red;
            serialPort1.WriteLine("$SRon");
            flip = pictureBox_LightSouth.Image;
            flip.RotateFlip(RotateFlipType.Rotate270FlipXY);
            pictureBox_LightSouth.Image = flip;
            timerSeconds.Enabled = true;
            Globals.Seconds = Globals.Timer;
            int timeSet = Globals.Seconds;
            labelWE.Text = Convert.ToString(timeSet);
            Globals.We = true;
        }

        private void timerSeconds_Tick(object sender, EventArgs e)
        {
            if (Globals.Seconds == Globals.Timer)
            {
                turnOffLights();
            }
            Globals.Seconds = Globals.Seconds - 1;
            if (Globals.Seconds == 0)
            {
                pictureBox_LightWest.Image = Properties.Resources.yellow;
                serialPort1.WriteLine("$WYon");
                pictureBox_LightEast.Image = Properties.Resources.yellow;
                serialPort1.WriteLine("$EYon");
                pictureBox_LightNorth.Image = Properties.Resources.yellow;
                serialPort1.WriteLine("$NYon");
                Image flip = pictureBox_LightNorth.Image;
                flip.RotateFlip(RotateFlipType.Rotate90FlipXY);
                pictureBox_LightNorth.Image = flip;
                pictureBox_LightSouth.Image = Properties.Resources.yellow;
                serialPort1.WriteLine("$SYon");
                flip = pictureBox_LightSouth.Image;
                flip.RotateFlip(RotateFlipType.Rotate270FlipXY);
                pictureBox_LightSouth.Image = flip;
            }
            if ( Globals.Seconds < 0 )
            {
                Globals.Seconds = Globals.Timer;
                if (Globals.We == true)
                {
                    Globals.We = false;
                    Globals.Ns = true;
                }
                else
                {
                    Globals.We = true;
                    Globals.Ns = false;
                }
            }
            int timeSet = Globals.Seconds;
            if (Globals.We == true)
            {
                labelWE.Text = Convert.ToString(timeSet);
                if (Globals.Seconds != 0)
                {
                    //turnOffLights();
                    pictureBox_LightWest.Image = Properties.Resources.green;
                    serialPort1.WriteLine("WGon");
                    pictureBox_LightEast.Image = Properties.Resources.green;
                    serialPort1.WriteLine("EGon");
                    pictureBox_LightNorth.Image = Properties.Resources.red;
                    serialPort1.WriteLine("NRon");
                    Image flip = pictureBox_LightNorth.Image;
                    flip.RotateFlip(RotateFlipType.Rotate90FlipXY);
                    pictureBox_LightNorth.Image = flip;
                    pictureBox_LightSouth.Image = Properties.Resources.red;
                    serialPort1.WriteLine("SRon");
                    flip = pictureBox_LightSouth.Image;
                    flip.RotateFlip(RotateFlipType.Rotate270FlipXY);
                    pictureBox_LightSouth.Image = flip;
                }
            }
            else if (Globals.Ns == true)
            {
                labelNS.Text = Convert.ToString(timeSet);
                if (Globals.Seconds != 0)
                {
                    //turnOffLights();
                    serialPort1.WriteLine("WRon");
                    serialPort1.WriteLine("ERon");
                    serialPort1.WriteLine("NGon");
                    serialPort1.WriteLine("SGon");
                    pictureBox_LightWest.Image = Properties.Resources.red;
                    pictureBox_LightEast.Image = Properties.Resources.red;
                    pictureBox_LightNorth.Image = Properties.Resources.green;
                    Image flip = pictureBox_LightNorth.Image;
                    flip.RotateFlip(RotateFlipType.Rotate90FlipXY);
                    pictureBox_LightNorth.Image = flip;
                    pictureBox_LightSouth.Image = Properties.Resources.green;
                    flip = pictureBox_LightSouth.Image;
                    flip.RotateFlip(RotateFlipType.Rotate270FlipXY);
                    pictureBox_LightSouth.Image = flip;
                }
            }
        }

        private void buttonTime_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBoxTime.Text != "")
                {
                    String newTime = textBoxTime.Text;
                    Globals.Timer = int.Parse(newTime);
                    textBoxTime.Text = "";
                }
                else
                {
                    MessageBox.Show("Introduce un valor en el campo de Ciclo (segundos)", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }

        private void buttonFullStop_Click(object sender, EventArgs e)
        {
            groupBox2.Enabled = false;
            groupBox3.Enabled = false;
            timerSeconds.Enabled = false;
            turnOffLights();
            serialPort1.WriteLine("WRon");
            serialPort1.WriteLine("ERon");
            serialPort1.WriteLine("NRon");
            serialPort1.WriteLine("SRon");
            pictureBox_LightWest.Image = Properties.Resources.red;
            pictureBox_LightEast.Image = Properties.Resources.red;
            pictureBox_LightNorth.Image = Properties.Resources.red;
            Image flip = pictureBox_LightNorth.Image;
            flip.RotateFlip(RotateFlipType.Rotate90FlipXY);
            pictureBox_LightNorth.Image = flip;
            pictureBox_LightSouth.Image = Properties.Resources.red;
            flip = pictureBox_LightSouth.Image;
            flip.RotateFlip(RotateFlipType.Rotate270FlipXY);
            pictureBox_LightSouth.Image = flip;
            Globals.We = false;
            Globals.Ns = false;
            buttonRestart.Enabled = true;
            buttonFullStop.Enabled = false;
        }

        private void buttonRestart_Click(object sender, EventArgs e)
        {
            restart();
        }

        private void restart()
        {
            enableComponents();
            buttonRestart.Enabled = false;
            buttonFullStop.Enabled = true;
            labelNS.Text = "0";
        }

        private void buttonManual_Click(object sender, EventArgs e)
        {
            if (buttonManual.Text == "HABILITAR")
            {
                groupBox2.Enabled = false;
                labelNS.Text = "--";
                labelWE.Text = "--";
                groupBox4.Enabled = false;
                timerSeconds.Enabled = false;
                buttonManual.Text = "DESACTIVAR";
                buttonManual.BackColor = Color.Purple;
                buttonN.Enabled = true;
                buttonN.ForeColor = Color.White;
                buttonN.BackColor = Color.Red;
                buttonS.Enabled = true;
                buttonS.ForeColor = Color.White;
                buttonS.BackColor = Color.Red;
                buttonW.Enabled = true;
                buttonW.ForeColor = Color.White;
                buttonW.BackColor = Color.Red;
                buttonE.Enabled = true;
                buttonE.ForeColor = Color.White;
                buttonE.BackColor = Color.Red;
                turnOffLights();
                serialPort1.WriteLine("$WRon");
                serialPort1.WriteLine("$ERon");
                serialPort1.WriteLine("$NRon");
                serialPort1.WriteLine("$SRon");
                pictureBox_LightWest.Image = Properties.Resources.red;
                pictureBox_LightEast.Image = Properties.Resources.red;
                pictureBox_LightNorth.Image = Properties.Resources.red;
                Image flip = pictureBox_LightNorth.Image;
                flip.RotateFlip(RotateFlipType.Rotate90FlipXY);
                pictureBox_LightNorth.Image = flip;
                pictureBox_LightSouth.Image = Properties.Resources.red;
                flip = pictureBox_LightSouth.Image;
                flip.RotateFlip(RotateFlipType.Rotate270FlipXY);
                pictureBox_LightSouth.Image = flip;
            }
            else
            {
                restart();
                buttonManual.Text = "HABILITAR";
                buttonManual.BackColor = Color.DarkOrange;
                buttonN.ForeColor = Color.Black;
                buttonN.BackColor = Color.White;
                buttonS.ForeColor = Color.Black;
                buttonS.BackColor = Color.White;
                buttonE.ForeColor = Color.Black;
                buttonE.BackColor = Color.White;
                buttonW.ForeColor = Color.Black;
                buttonW.BackColor = Color.White;
            }
        }

        private void buttonN_Click(object sender, EventArgs e)
        {
            if (buttonN.BackColor == Color.Red)
            {
                buttonN.BackColor = Color.Green;
                serialPort1.WriteLine("$NRoff");
                serialPort1.WriteLine("$NYoff");
                serialPort1.WriteLine("$NGon");
                pictureBox_LightNorth.Image = Properties.Resources.green;
                Image flip = pictureBox_LightNorth.Image;
                flip.RotateFlip(RotateFlipType.Rotate90FlipXY);
                pictureBox_LightNorth.Image = flip;
            }
            else
            {
                buttonN.BackColor = Color.Red;
                serialPort1.WriteLine("$NRon");
                serialPort1.WriteLine("$NYoff");
                serialPort1.WriteLine("$NGoff");
                pictureBox_LightNorth.Image = Properties.Resources.red;
                Image flip = pictureBox_LightNorth.Image;
                flip.RotateFlip(RotateFlipType.Rotate90FlipXY);
                pictureBox_LightNorth.Image = flip;
            }
        }

        private void buttonS_Click(object sender, EventArgs e)
        {
            if (buttonS.BackColor == Color.Red)
            {
                buttonS.BackColor = Color.Green;
                serialPort1.WriteLine("$SRoff");
                serialPort1.WriteLine("$SYoff");
                serialPort1.WriteLine("$SGon");
                pictureBox_LightSouth.Image = Properties.Resources.green;
                Image flip = pictureBox_LightSouth.Image;
                flip.RotateFlip(RotateFlipType.Rotate270FlipXY);
                pictureBox_LightSouth.Image = flip;
            }
            else
            {
                buttonS.BackColor = Color.Red;
                serialPort1.WriteLine("$SRon");
                serialPort1.WriteLine("$SYoff");
                serialPort1.WriteLine("$SGoff");
                pictureBox_LightSouth.Image = Properties.Resources.red;
                Image flip = pictureBox_LightSouth.Image;
                flip.RotateFlip(RotateFlipType.Rotate270FlipXY);
                pictureBox_LightSouth.Image = flip;
            }
        }

        private void buttonW_Click(object sender, EventArgs e)
        {
            if (buttonW.BackColor == Color.Red)
            {
                buttonW.BackColor = Color.Green;
                serialPort1.WriteLine("$WRoff");
                serialPort1.WriteLine("$WYoff");
                serialPort1.WriteLine("$WGon");
                pictureBox_LightWest.Image = Properties.Resources.green;
            }
            else
            {
                buttonW.BackColor = Color.Red;
                serialPort1.WriteLine("$WRon");
                serialPort1.WriteLine("$WYoff");
                serialPort1.WriteLine("$WGoff");
                pictureBox_LightWest.Image = Properties.Resources.red;
            }
        }

        private void buttonE_Click(object sender, EventArgs e)
        {
            if (buttonE.BackColor == Color.Red)
            {
                buttonE.BackColor = Color.Green;
                serialPort1.WriteLine("$ERoff");
                serialPort1.WriteLine("$EYoff");
                serialPort1.WriteLine("$EGon");
                pictureBox_LightEast.Image = Properties.Resources.green;
            }
            else
            {
                buttonE.BackColor = Color.Red;
                serialPort1.WriteLine("$ERon");
                serialPort1.WriteLine("$EYoff");
                serialPort1.WriteLine("$EGoff");
                pictureBox_LightEast.Image = Properties.Resources.red;
            }
        }

        private void turnOffLights()
        {
            if (serialPort1.IsOpen)
            {
                serialPort1.WriteLine("$WRoff");
                serialPort1.WriteLine("$WYoff");
                serialPort1.WriteLine("$WGoff");
                serialPort1.WriteLine("$ERoff");
                serialPort1.WriteLine("$EYoff");
                serialPort1.WriteLine("$EGoff");
                serialPort1.WriteLine("$NRoff");
                serialPort1.WriteLine("$NYoff");
                serialPort1.WriteLine("$NGoff");
                serialPort1.WriteLine("$SRoff");
                serialPort1.WriteLine("$SYoff");
                serialPort1.WriteLine("$SGoff");
            }
        }
    }
}
