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
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox_LightEast = new System.Windows.Forms.PictureBox();
            this.pictureBox_LightWest = new System.Windows.Forms.PictureBox();
            this.pictureBox_LightNorth = new System.Windows.Forms.PictureBox();
            this.pictureBox_LightSouth = new System.Windows.Forms.PictureBox();
            this.pictureBox_PersonWest = new System.Windows.Forms.PictureBox();
            this.pictureBox_PersonSouth = new System.Windows.Forms.PictureBox();
            this.pictureBox_PersonEast = new System.Windows.Forms.PictureBox();
            this.pictureBox_PersonNorth = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_LightEast)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_LightWest)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_LightNorth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_LightSouth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_PersonWest)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_PersonSouth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_PersonEast)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_PersonNorth)).BeginInit();
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
            this.groupBox1.Location = new System.Drawing.Point(18, 22);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(230, 338);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "COM PORT CONTROLS";
            // 
            // progressBar1
            // 
            this.progressBar1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.progressBar1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(200)))), ((int)(((byte)(0)))));
            this.progressBar1.Location = new System.Drawing.Point(16, 290);
            this.progressBar1.Margin = new System.Windows.Forms.Padding(2);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(195, 27);
            this.progressBar1.TabIndex = 1;
            // 
            // buttonConnect
            // 
            this.buttonConnect.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(200)))), ((int)(((byte)(0)))));
            this.buttonConnect.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonConnect.Location = new System.Drawing.Point(40, 224);
            this.buttonConnect.Margin = new System.Windows.Forms.Padding(2);
            this.buttonConnect.Name = "buttonConnect";
            this.buttonConnect.Size = new System.Drawing.Size(150, 41);
            this.buttonConnect.TabIndex = 4;
            this.buttonConnect.Text = "CONECTAR";
            this.buttonConnect.UseVisualStyleBackColor = false;
            this.buttonConnect.Click += new System.EventHandler(this.buttonConnect_Click);
            // 
            // buttonRefresh
            // 
            this.buttonRefresh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(0)))), ((int)(((byte)(180)))));
            this.buttonRefresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonRefresh.Location = new System.Drawing.Point(40, 158);
            this.buttonRefresh.Margin = new System.Windows.Forms.Padding(2);
            this.buttonRefresh.Name = "buttonRefresh";
            this.buttonRefresh.Size = new System.Drawing.Size(150, 41);
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
            this.comboBoxBaud.Location = new System.Drawing.Point(109, 103);
            this.comboBoxBaud.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxBaud.Name = "comboBoxBaud";
            this.comboBoxBaud.Size = new System.Drawing.Size(103, 28);
            this.comboBoxBaud.TabIndex = 3;
            // 
            // comboBoxPort
            // 
            this.comboBoxPort.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboBoxPort.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxPort.Font = new System.Drawing.Font("Noto Sans", 11.25F);
            this.comboBoxPort.FormattingEnabled = true;
            this.comboBoxPort.Location = new System.Drawing.Point(109, 46);
            this.comboBoxPort.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxPort.Name = "comboBoxPort";
            this.comboBoxPort.Size = new System.Drawing.Size(103, 28);
            this.comboBoxPort.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Noto Sans", 10.2F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(9, 107);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "BAUD RATE:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Noto Sans", 10.2F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(13, 50);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "COM PORT:";
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
            this.panel1.Location = new System.Drawing.Point(685, 20);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(450, 450);
            this.panel1.TabIndex = 1;
            // 
            // pictureBox_LightEast
            // 
            this.pictureBox_LightEast.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox_LightEast.Image = global::HMI_Traffic.Properties.Resources.lightOff;
            this.pictureBox_LightEast.Location = new System.Drawing.Point(262, 211);
            this.pictureBox_LightEast.Name = "pictureBox_LightEast";
            this.pictureBox_LightEast.Size = new System.Drawing.Size(90, 90);
            this.pictureBox_LightEast.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_LightEast.TabIndex = 3;
            this.pictureBox_LightEast.TabStop = false;
            // 
            // pictureBox_LightWest
            // 
            this.pictureBox_LightWest.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox_LightWest.Image = global::HMI_Traffic.Properties.Resources.lightOff;
            this.pictureBox_LightWest.Location = new System.Drawing.Point(96, 138);
            this.pictureBox_LightWest.Name = "pictureBox_LightWest";
            this.pictureBox_LightWest.Size = new System.Drawing.Size(90, 90);
            this.pictureBox_LightWest.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_LightWest.TabIndex = 3;
            this.pictureBox_LightWest.TabStop = false;
            // 
            // pictureBox_LightNorth
            // 
            this.pictureBox_LightNorth.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox_LightNorth.Image = global::HMI_Traffic.Properties.Resources.lightOff;
            this.pictureBox_LightNorth.Location = new System.Drawing.Point(213, 95);
            this.pictureBox_LightNorth.Name = "pictureBox_LightNorth";
            this.pictureBox_LightNorth.Size = new System.Drawing.Size(90, 90);
            this.pictureBox_LightNorth.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_LightNorth.TabIndex = 3;
            this.pictureBox_LightNorth.TabStop = false;
            // 
            // pictureBox_LightSouth
            // 
            this.pictureBox_LightSouth.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox_LightSouth.Image = global::HMI_Traffic.Properties.Resources.lightOff;
            this.pictureBox_LightSouth.Location = new System.Drawing.Point(146, 263);
            this.pictureBox_LightSouth.Name = "pictureBox_LightSouth";
            this.pictureBox_LightSouth.Size = new System.Drawing.Size(90, 90);
            this.pictureBox_LightSouth.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_LightSouth.TabIndex = 2;
            this.pictureBox_LightSouth.TabStop = false;
            // 
            // pictureBox_PersonWest
            // 
            this.pictureBox_PersonWest.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox_PersonWest.Image = global::HMI_Traffic.Properties.Resources.person;
            this.pictureBox_PersonWest.Location = new System.Drawing.Point(50, 86);
            this.pictureBox_PersonWest.Name = "pictureBox_PersonWest";
            this.pictureBox_PersonWest.Size = new System.Drawing.Size(60, 60);
            this.pictureBox_PersonWest.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_PersonWest.TabIndex = 4;
            this.pictureBox_PersonWest.TabStop = false;
            // 
            // pictureBox_PersonSouth
            // 
            this.pictureBox_PersonSouth.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox_PersonSouth.Image = global::HMI_Traffic.Properties.Resources.person;
            this.pictureBox_PersonSouth.Location = new System.Drawing.Point(98, 338);
            this.pictureBox_PersonSouth.Name = "pictureBox_PersonSouth";
            this.pictureBox_PersonSouth.Size = new System.Drawing.Size(60, 60);
            this.pictureBox_PersonSouth.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_PersonSouth.TabIndex = 5;
            this.pictureBox_PersonSouth.TabStop = false;
            // 
            // pictureBox_PersonEast
            // 
            this.pictureBox_PersonEast.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox_PersonEast.Image = global::HMI_Traffic.Properties.Resources.person;
            this.pictureBox_PersonEast.Location = new System.Drawing.Point(337, 304);
            this.pictureBox_PersonEast.Name = "pictureBox_PersonEast";
            this.pictureBox_PersonEast.Size = new System.Drawing.Size(60, 60);
            this.pictureBox_PersonEast.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_PersonEast.TabIndex = 6;
            this.pictureBox_PersonEast.TabStop = false;
            // 
            // pictureBox_PersonNorth
            // 
            this.pictureBox_PersonNorth.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox_PersonNorth.Image = global::HMI_Traffic.Properties.Resources.person;
            this.pictureBox_PersonNorth.Location = new System.Drawing.Point(291, 49);
            this.pictureBox_PersonNorth.Name = "pictureBox_PersonNorth";
            this.pictureBox_PersonNorth.Size = new System.Drawing.Size(60, 60);
            this.pictureBox_PersonNorth.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_PersonNorth.TabIndex = 7;
            this.pictureBox_PersonNorth.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(1155, 682);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Interfaz de Control de Tráfico";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_LightEast)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_LightWest)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_LightNorth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_LightSouth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_PersonWest)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_PersonSouth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_PersonEast)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_PersonNorth)).EndInit();
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
    }
}

