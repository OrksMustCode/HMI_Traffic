namespace HMI_Traffic
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.buttonConnect = new System.Windows.Forms.Button();
            this.buttonRefresh = new System.Windows.Forms.Button();
            this.comboBoxBaud = new System.Windows.Forms.ComboBox();
            this.comboBoxPort = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.buttonTime = new System.Windows.Forms.Button();
            this.textBoxTime = new System.Windows.Forms.TextBox();
            this.labelNS = new System.Windows.Forms.Label();
            this.labelWE = new System.Windows.Forms.Label();
            this.pictureBoxWE = new System.Windows.Forms.PictureBox();
            this.pictureBoxNS = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox_PersonNorth = new System.Windows.Forms.PictureBox();
            this.pictureBox_PersonEast = new System.Windows.Forms.PictureBox();
            this.pictureBox_PersonSouth = new System.Windows.Forms.PictureBox();
            this.pictureBox_PersonWest = new System.Windows.Forms.PictureBox();
            this.pictureBox_LightEast = new System.Windows.Forms.PictureBox();
            this.pictureBox_LightWest = new System.Windows.Forms.PictureBox();
            this.pictureBox_LightNorth = new System.Windows.Forms.PictureBox();
            this.pictureBox_LightSouth = new System.Windows.Forms.PictureBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.buttonFullStop = new System.Windows.Forms.Button();
            this.buttonRestart = new System.Windows.Forms.Button();
            this.buttonManual = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonN = new System.Windows.Forms.Button();
            this.buttonS = new System.Windows.Forms.Button();
            this.buttonW = new System.Windows.Forms.Button();
            this.buttonE = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxWE)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxNS)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_PersonNorth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_PersonEast)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_PersonSouth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_PersonWest)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_LightEast)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_LightWest)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_LightNorth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_LightSouth)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.progressBar1);
            this.groupBox1.Controls.Add(this.buttonConnect);
            this.groupBox1.Controls.Add(this.buttonRefresh);
            this.groupBox1.Controls.Add(this.comboBoxBaud);
            this.groupBox1.Controls.Add(this.comboBoxPort);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Noto Sans", 13.2F, System.Drawing.FontStyle.Bold);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(24, 27);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(307, 416);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "CONTROLES DE PUERTO";
            // 
            // progressBar1
            // 
            this.progressBar1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.progressBar1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(200)))), ((int)(((byte)(0)))));
            this.progressBar1.Location = new System.Drawing.Point(21, 357);
            this.progressBar1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(260, 33);
            this.progressBar1.TabIndex = 1;
            // 
            // buttonConnect
            // 
            this.buttonConnect.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(200)))), ((int)(((byte)(0)))));
            this.buttonConnect.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonConnect.Location = new System.Drawing.Point(53, 276);
            this.buttonConnect.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonConnect.Name = "buttonConnect";
            this.buttonConnect.Size = new System.Drawing.Size(200, 50);
            this.buttonConnect.TabIndex = 4;
            this.buttonConnect.Text = "CONECTAR";
            this.buttonConnect.UseVisualStyleBackColor = false;
            this.buttonConnect.Click += new System.EventHandler(this.buttonConnect_Click);
            // 
            // buttonRefresh
            // 
            this.buttonRefresh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(0)))), ((int)(((byte)(180)))));
            this.buttonRefresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonRefresh.Location = new System.Drawing.Point(53, 194);
            this.buttonRefresh.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonRefresh.Name = "buttonRefresh";
            this.buttonRefresh.Size = new System.Drawing.Size(200, 50);
            this.buttonRefresh.TabIndex = 1;
            this.buttonRefresh.Text = "REFRESCAR";
            this.buttonRefresh.UseVisualStyleBackColor = false;
            this.buttonRefresh.Click += new System.EventHandler(this.buttonRefresh_Click);
            // 
            // comboBoxBaud
            // 
            this.comboBoxBaud.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboBoxBaud.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxBaud.Font = new System.Drawing.Font("Noto Sans", 11.25F);
            this.comboBoxBaud.FormattingEnabled = true;
            this.comboBoxBaud.Location = new System.Drawing.Point(145, 127);
            this.comboBoxBaud.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBoxBaud.Name = "comboBoxBaud";
            this.comboBoxBaud.Size = new System.Drawing.Size(136, 34);
            this.comboBoxBaud.TabIndex = 3;
            // 
            // comboBoxPort
            // 
            this.comboBoxPort.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboBoxPort.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxPort.Font = new System.Drawing.Font("Noto Sans", 11.25F);
            this.comboBoxPort.FormattingEnabled = true;
            this.comboBoxPort.Location = new System.Drawing.Point(145, 57);
            this.comboBoxPort.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBoxPort.Name = "comboBoxPort";
            this.comboBoxPort.Size = new System.Drawing.Size(136, 34);
            this.comboBoxPort.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Noto Sans", 10.2F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(12, 132);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "BAUD RATE:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Noto Sans", 10.2F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(17, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "COM PORT:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.buttonTime);
            this.groupBox2.Controls.Add(this.textBoxTime);
            this.groupBox2.Controls.Add(this.labelNS);
            this.groupBox2.Controls.Add(this.labelWE);
            this.groupBox2.Controls.Add(this.pictureBoxWE);
            this.groupBox2.Controls.Add(this.pictureBoxNS);
            this.groupBox2.Font = new System.Drawing.Font("Noto Sans", 13.2F, System.Drawing.FontStyle.Bold);
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(359, 27);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(523, 416);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "CONTROL AUTOMÁTICO";
            // 
            // buttonTime
            // 
            this.buttonTime.BackColor = System.Drawing.Color.White;
            this.buttonTime.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonTime.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.buttonTime.ForeColor = System.Drawing.Color.Black;
            this.buttonTime.Location = new System.Drawing.Point(301, 331);
            this.buttonTime.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonTime.Name = "buttonTime";
            this.buttonTime.Size = new System.Drawing.Size(159, 38);
            this.buttonTime.TabIndex = 5;
            this.buttonTime.Text = "Actualizar";
            this.buttonTime.UseVisualStyleBackColor = false;
            // 
            // textBoxTime
            // 
            this.textBoxTime.Font = new System.Drawing.Font("Noto Sans", 14.25F);
            this.textBoxTime.Location = new System.Drawing.Point(60, 329);
            this.textBoxTime.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxTime.Name = "textBoxTime";
            this.textBoxTime.Size = new System.Drawing.Size(215, 40);
            this.textBoxTime.TabIndex = 4;
            // 
            // labelNS
            // 
            this.labelNS.AutoSize = true;
            this.labelNS.Font = new System.Drawing.Font("Noto Sans", 24F, System.Drawing.FontStyle.Bold);
            this.labelNS.Location = new System.Drawing.Point(340, 41);
            this.labelNS.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelNS.Name = "labelNS";
            this.labelNS.Size = new System.Drawing.Size(70, 55);
            this.labelNS.TabIndex = 3;
            this.labelNS.Text = "00";
            // 
            // labelWE
            // 
            this.labelWE.AutoSize = true;
            this.labelWE.Font = new System.Drawing.Font("Noto Sans", 24F, System.Drawing.FontStyle.Bold);
            this.labelWE.Location = new System.Drawing.Point(112, 43);
            this.labelWE.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelWE.Name = "labelWE";
            this.labelWE.Size = new System.Drawing.Size(70, 55);
            this.labelWE.TabIndex = 2;
            this.labelWE.Text = "00";
            // 
            // pictureBoxWE
            // 
            this.pictureBoxWE.Image = global::HMI_Traffic.Properties.Resources.bidireccional;
            this.pictureBoxWE.Location = new System.Drawing.Point(60, 104);
            this.pictureBoxWE.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBoxWE.Name = "pictureBoxWE";
            this.pictureBoxWE.Size = new System.Drawing.Size(173, 160);
            this.pictureBoxWE.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxWE.TabIndex = 1;
            this.pictureBoxWE.TabStop = false;
            // 
            // pictureBoxNS
            // 
            this.pictureBoxNS.Image = global::HMI_Traffic.Properties.Resources.bidireccional;
            this.pictureBoxNS.Location = new System.Drawing.Point(287, 104);
            this.pictureBoxNS.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBoxNS.Name = "pictureBoxNS";
            this.pictureBoxNS.Size = new System.Drawing.Size(173, 160);
            this.pictureBoxNS.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxNS.TabIndex = 0;
            this.pictureBoxNS.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BackgroundImage = global::HMI_Traffic.Properties.Resources.intersection;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.pictureBox_PersonNorth);
            this.panel1.Controls.Add(this.pictureBox_PersonEast);
            this.panel1.Controls.Add(this.pictureBox_PersonSouth);
            this.panel1.Controls.Add(this.pictureBox_PersonWest);
            this.panel1.Controls.Add(this.pictureBox_LightEast);
            this.panel1.Controls.Add(this.pictureBox_LightWest);
            this.panel1.Controls.Add(this.pictureBox_LightNorth);
            this.panel1.Controls.Add(this.pictureBox_LightSouth);
            this.panel1.Location = new System.Drawing.Point(913, 25);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(599, 553);
            this.panel1.TabIndex = 1;
            // 
            // pictureBox_PersonNorth
            // 
            this.pictureBox_PersonNorth.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox_PersonNorth.Image = global::HMI_Traffic.Properties.Resources.person;
            this.pictureBox_PersonNorth.Location = new System.Drawing.Point(388, 60);
            this.pictureBox_PersonNorth.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox_PersonNorth.Name = "pictureBox_PersonNorth";
            this.pictureBox_PersonNorth.Size = new System.Drawing.Size(80, 74);
            this.pictureBox_PersonNorth.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_PersonNorth.TabIndex = 7;
            this.pictureBox_PersonNorth.TabStop = false;
            // 
            // pictureBox_PersonEast
            // 
            this.pictureBox_PersonEast.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox_PersonEast.Image = global::HMI_Traffic.Properties.Resources.person;
            this.pictureBox_PersonEast.Location = new System.Drawing.Point(449, 374);
            this.pictureBox_PersonEast.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox_PersonEast.Name = "pictureBox_PersonEast";
            this.pictureBox_PersonEast.Size = new System.Drawing.Size(80, 74);
            this.pictureBox_PersonEast.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_PersonEast.TabIndex = 6;
            this.pictureBox_PersonEast.TabStop = false;
            // 
            // pictureBox_PersonSouth
            // 
            this.pictureBox_PersonSouth.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox_PersonSouth.Image = global::HMI_Traffic.Properties.Resources.person;
            this.pictureBox_PersonSouth.Location = new System.Drawing.Point(131, 416);
            this.pictureBox_PersonSouth.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox_PersonSouth.Name = "pictureBox_PersonSouth";
            this.pictureBox_PersonSouth.Size = new System.Drawing.Size(80, 74);
            this.pictureBox_PersonSouth.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_PersonSouth.TabIndex = 5;
            this.pictureBox_PersonSouth.TabStop = false;
            // 
            // pictureBox_PersonWest
            // 
            this.pictureBox_PersonWest.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox_PersonWest.Image = global::HMI_Traffic.Properties.Resources.person;
            this.pictureBox_PersonWest.Location = new System.Drawing.Point(67, 106);
            this.pictureBox_PersonWest.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox_PersonWest.Name = "pictureBox_PersonWest";
            this.pictureBox_PersonWest.Size = new System.Drawing.Size(80, 74);
            this.pictureBox_PersonWest.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_PersonWest.TabIndex = 4;
            this.pictureBox_PersonWest.TabStop = false;
            // 
            // pictureBox_LightEast
            // 
            this.pictureBox_LightEast.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox_LightEast.Image = global::HMI_Traffic.Properties.Resources.lightOff;
            this.pictureBox_LightEast.Location = new System.Drawing.Point(349, 260);
            this.pictureBox_LightEast.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox_LightEast.Name = "pictureBox_LightEast";
            this.pictureBox_LightEast.Size = new System.Drawing.Size(120, 111);
            this.pictureBox_LightEast.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_LightEast.TabIndex = 3;
            this.pictureBox_LightEast.TabStop = false;
            // 
            // pictureBox_LightWest
            // 
            this.pictureBox_LightWest.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox_LightWest.Image = global::HMI_Traffic.Properties.Resources.lightOff;
            this.pictureBox_LightWest.Location = new System.Drawing.Point(128, 170);
            this.pictureBox_LightWest.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox_LightWest.Name = "pictureBox_LightWest";
            this.pictureBox_LightWest.Size = new System.Drawing.Size(120, 111);
            this.pictureBox_LightWest.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_LightWest.TabIndex = 3;
            this.pictureBox_LightWest.TabStop = false;
            // 
            // pictureBox_LightNorth
            // 
            this.pictureBox_LightNorth.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox_LightNorth.Image = global::HMI_Traffic.Properties.Resources.lightOff;
            this.pictureBox_LightNorth.Location = new System.Drawing.Point(284, 117);
            this.pictureBox_LightNorth.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox_LightNorth.Name = "pictureBox_LightNorth";
            this.pictureBox_LightNorth.Size = new System.Drawing.Size(120, 111);
            this.pictureBox_LightNorth.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_LightNorth.TabIndex = 3;
            this.pictureBox_LightNorth.TabStop = false;
            // 
            // pictureBox_LightSouth
            // 
            this.pictureBox_LightSouth.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox_LightSouth.Image = global::HMI_Traffic.Properties.Resources.lightOff;
            this.pictureBox_LightSouth.Location = new System.Drawing.Point(195, 324);
            this.pictureBox_LightSouth.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox_LightSouth.Name = "pictureBox_LightSouth";
            this.pictureBox_LightSouth.Size = new System.Drawing.Size(120, 111);
            this.pictureBox_LightSouth.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_LightSouth.TabIndex = 2;
            this.pictureBox_LightSouth.TabStop = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.buttonE);
            this.groupBox3.Controls.Add(this.buttonW);
            this.groupBox3.Controls.Add(this.buttonS);
            this.groupBox3.Controls.Add(this.buttonN);
            this.groupBox3.Controls.Add(this.buttonManual);
            this.groupBox3.Font = new System.Drawing.Font("Noto Sans", 13.2F, System.Drawing.FontStyle.Bold);
            this.groupBox3.ForeColor = System.Drawing.Color.White;
            this.groupBox3.Location = new System.Drawing.Point(24, 474);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(858, 338);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "CONTROL MANUAL";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.buttonRestart);
            this.groupBox4.Controls.Add(this.buttonFullStop);
            this.groupBox4.Font = new System.Drawing.Font("Noto Sans", 13.2F, System.Drawing.FontStyle.Bold);
            this.groupBox4.ForeColor = System.Drawing.Color.White;
            this.groupBox4.Location = new System.Drawing.Point(913, 605);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(599, 207);
            this.groupBox4.TabIndex = 4;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "ALTO TOTAL";
            // 
            // buttonFullStop
            // 
            this.buttonFullStop.BackColor = System.Drawing.Color.Red;
            this.buttonFullStop.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonFullStop.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonFullStop.Font = new System.Drawing.Font("Noto Sans", 16.2F, System.Drawing.FontStyle.Bold);
            this.buttonFullStop.ForeColor = System.Drawing.Color.White;
            this.buttonFullStop.Location = new System.Drawing.Point(58, 66);
            this.buttonFullStop.Name = "buttonFullStop";
            this.buttonFullStop.Size = new System.Drawing.Size(220, 92);
            this.buttonFullStop.TabIndex = 0;
            this.buttonFullStop.Text = "ALTO TOTAL";
            this.buttonFullStop.UseVisualStyleBackColor = false;
            // 
            // buttonRestart
            // 
            this.buttonRestart.BackColor = System.Drawing.Color.Blue;
            this.buttonRestart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonRestart.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonRestart.Font = new System.Drawing.Font("Noto Sans", 16.2F, System.Drawing.FontStyle.Bold);
            this.buttonRestart.ForeColor = System.Drawing.Color.White;
            this.buttonRestart.Location = new System.Drawing.Point(332, 66);
            this.buttonRestart.Name = "buttonRestart";
            this.buttonRestart.Size = new System.Drawing.Size(220, 92);
            this.buttonRestart.TabIndex = 1;
            this.buttonRestart.Text = "REINICIO";
            this.buttonRestart.UseVisualStyleBackColor = false;
            // 
            // buttonManual
            // 
            this.buttonManual.BackColor = System.Drawing.Color.DarkOrange;
            this.buttonManual.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonManual.Font = new System.Drawing.Font("Noto Sans", 13.8F, System.Drawing.FontStyle.Bold);
            this.buttonManual.Location = new System.Drawing.Point(73, 131);
            this.buttonManual.Name = "buttonManual";
            this.buttonManual.Size = new System.Drawing.Size(225, 77);
            this.buttonManual.TabIndex = 0;
            this.buttonManual.Text = "HABILITAR";
            this.buttonManual.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Noto Sans", 12F);
            this.label3.Location = new System.Drawing.Point(55, 298);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(220, 27);
            this.label3.TabIndex = 6;
            this.label3.Text = "Tiempo entre cambios";
            // 
            // buttonN
            // 
            this.buttonN.BackColor = System.Drawing.Color.White;
            this.buttonN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonN.Font = new System.Drawing.Font("Noto Sans", 48F, System.Drawing.FontStyle.Bold);
            this.buttonN.ForeColor = System.Drawing.Color.Black;
            this.buttonN.Location = new System.Drawing.Point(525, 52);
            this.buttonN.Name = "buttonN";
            this.buttonN.Size = new System.Drawing.Size(120, 120);
            this.buttonN.TabIndex = 1;
            this.buttonN.Text = "N";
            this.buttonN.UseVisualStyleBackColor = false;
            // 
            // buttonS
            // 
            this.buttonS.BackColor = System.Drawing.Color.White;
            this.buttonS.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonS.Font = new System.Drawing.Font("Noto Sans", 48F, System.Drawing.FontStyle.Bold);
            this.buttonS.ForeColor = System.Drawing.Color.Black;
            this.buttonS.Location = new System.Drawing.Point(525, 178);
            this.buttonS.Name = "buttonS";
            this.buttonS.Size = new System.Drawing.Size(120, 120);
            this.buttonS.TabIndex = 2;
            this.buttonS.Text = "S";
            this.buttonS.UseVisualStyleBackColor = false;
            // 
            // buttonW
            // 
            this.buttonW.BackColor = System.Drawing.Color.White;
            this.buttonW.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonW.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonW.Font = new System.Drawing.Font("Noto Sans", 48F, System.Drawing.FontStyle.Bold);
            this.buttonW.ForeColor = System.Drawing.Color.Black;
            this.buttonW.Location = new System.Drawing.Point(399, 112);
            this.buttonW.Name = "buttonW";
            this.buttonW.Size = new System.Drawing.Size(120, 120);
            this.buttonW.TabIndex = 3;
            this.buttonW.Text = "O";
            this.buttonW.UseVisualStyleBackColor = false;
            // 
            // buttonE
            // 
            this.buttonE.BackColor = System.Drawing.Color.White;
            this.buttonE.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonE.Font = new System.Drawing.Font("Noto Sans", 48F, System.Drawing.FontStyle.Bold);
            this.buttonE.ForeColor = System.Drawing.Color.Black;
            this.buttonE.Location = new System.Drawing.Point(651, 112);
            this.buttonE.Name = "buttonE";
            this.buttonE.Size = new System.Drawing.Size(120, 120);
            this.buttonE.TabIndex = 4;
            this.buttonE.Text = "E";
            this.buttonE.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(1540, 839);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Interfaz de Control de Tráfico";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxWE)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxNS)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_PersonNorth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_PersonEast)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_PersonSouth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_PersonWest)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_LightEast)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_LightWest)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_LightNorth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_LightSouth)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxPort;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxBaud;
        private System.Windows.Forms.Button buttonRefresh;
        private System.Windows.Forms.Button buttonConnect;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox_LightSouth;
        private System.Windows.Forms.PictureBox pictureBox_LightEast;
        private System.Windows.Forms.PictureBox pictureBox_LightWest;
        private System.Windows.Forms.PictureBox pictureBox_LightNorth;
        private System.Windows.Forms.PictureBox pictureBox_PersonWest;
        private System.Windows.Forms.PictureBox pictureBox_PersonNorth;
        private System.Windows.Forms.PictureBox pictureBox_PersonEast;
        private System.Windows.Forms.PictureBox pictureBox_PersonSouth;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.PictureBox pictureBoxNS;
        private System.Windows.Forms.PictureBox pictureBoxWE;
        private System.Windows.Forms.Label labelWE;
        private System.Windows.Forms.Label labelNS;
        private System.Windows.Forms.TextBox textBoxTime;
        private System.Windows.Forms.Button buttonTime;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button buttonFullStop;
        private System.Windows.Forms.Button buttonRestart;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonManual;
        private System.Windows.Forms.Button buttonE;
        private System.Windows.Forms.Button buttonW;
        private System.Windows.Forms.Button buttonS;
        private System.Windows.Forms.Button buttonN;
    }
}

