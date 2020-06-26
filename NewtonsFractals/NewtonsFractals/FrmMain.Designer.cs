namespace NewtonsFractals
{
    partial class FrmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblYmax = new System.Windows.Forms.Label();
            this.lblYmin = new System.Windows.Forms.Label();
            this.lblXmin = new System.Windows.Forms.Label();
            this.lblXmax = new System.Windows.Forms.Label();
            this.btnLeft = new System.Windows.Forms.Button();
            this.btnUp = new System.Windows.Forms.Button();
            this.btnRight = new System.Windows.Forms.Button();
            this.btnDown = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.cmbFractal = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbPalette = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnZoomIn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnZoomOut = new System.Windows.Forms.Button();
            this.groupBoxJulia = new System.Windows.Forms.GroupBox();
            this.lblB = new System.Windows.Forms.Label();
            this.lblA = new System.Windows.Forms.Label();
            this.trackBar2 = new System.Windows.Forms.TrackBar();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.groupBoxNewton = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbRoots = new System.Windows.Forms.ComboBox();
            this.lblElapsedTime = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize) (this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBoxJulia.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize) (this.trackBar2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.trackBar1)).BeginInit();
            this.groupBoxNewton.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(27, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(640, 640);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // lblYmax
            // 
            this.lblYmax.Location = new System.Drawing.Point(673, 12);
            this.lblYmax.Name = "lblYmax";
            this.lblYmax.Size = new System.Drawing.Size(49, 18);
            this.lblYmax.TabIndex = 1;
            this.lblYmax.Text = "label1";
            // 
            // lblYmin
            // 
            this.lblYmin.Location = new System.Drawing.Point(673, 638);
            this.lblYmin.Name = "lblYmin";
            this.lblYmin.Size = new System.Drawing.Size(54, 19);
            this.lblYmin.TabIndex = 2;
            this.lblYmin.Text = "label";
            // 
            // lblXmin
            // 
            this.lblXmin.Location = new System.Drawing.Point(15, 658);
            this.lblXmin.Name = "lblXmin";
            this.lblXmin.Size = new System.Drawing.Size(72, 18);
            this.lblXmin.TabIndex = 3;
            this.lblXmin.Text = "label3";
            // 
            // lblXmax
            // 
            this.lblXmax.Location = new System.Drawing.Point(645, 659);
            this.lblXmax.Name = "lblXmax";
            this.lblXmax.Size = new System.Drawing.Size(49, 18);
            this.lblXmax.TabIndex = 4;
            this.lblXmax.Text = "label4";
            // 
            // btnLeft
            // 
            this.btnLeft.BackgroundImage = ((System.Drawing.Image) (resources.GetObject("btnLeft.BackgroundImage")));
            this.btnLeft.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnLeft.Location = new System.Drawing.Point(25, 56);
            this.btnLeft.Name = "btnLeft";
            this.btnLeft.Size = new System.Drawing.Size(36, 36);
            this.btnLeft.TabIndex = 5;
            this.btnLeft.UseVisualStyleBackColor = true;
            this.btnLeft.Click += new System.EventHandler(this.btnLeft_Click);
            // 
            // btnUp
            // 
            this.btnUp.BackgroundImage = ((System.Drawing.Image) (resources.GetObject("btnUp.BackgroundImage")));
            this.btnUp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnUp.Location = new System.Drawing.Point(67, 56);
            this.btnUp.Name = "btnUp";
            this.btnUp.Size = new System.Drawing.Size(36, 36);
            this.btnUp.TabIndex = 6;
            this.btnUp.UseVisualStyleBackColor = true;
            this.btnUp.Click += new System.EventHandler(this.btnUp_Click);
            // 
            // btnRight
            // 
            this.btnRight.BackgroundImage = ((System.Drawing.Image) (resources.GetObject("btnRight.BackgroundImage")));
            this.btnRight.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnRight.Location = new System.Drawing.Point(151, 56);
            this.btnRight.Name = "btnRight";
            this.btnRight.Size = new System.Drawing.Size(36, 36);
            this.btnRight.TabIndex = 7;
            this.btnRight.UseVisualStyleBackColor = true;
            this.btnRight.Click += new System.EventHandler(this.btnRight_Click);
            // 
            // btnDown
            // 
            this.btnDown.BackgroundImage = ((System.Drawing.Image) (resources.GetObject("btnDown.BackgroundImage")));
            this.btnDown.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnDown.Location = new System.Drawing.Point(109, 56);
            this.btnDown.Name = "btnDown";
            this.btnDown.Size = new System.Drawing.Size(36, 36);
            this.btnDown.TabIndex = 8;
            this.btnDown.UseVisualStyleBackColor = true;
            this.btnDown.Click += new System.EventHandler(this.btnDown_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(25, 98);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(162, 31);
            this.button1.TabIndex = 9;
            this.button1.Text = "Исходное положение";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cmbFractal
            // 
            this.cmbFractal.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFractal.FormattingEnabled = true;
            this.cmbFractal.Location = new System.Drawing.Point(751, 98);
            this.cmbFractal.Name = "cmbFractal";
            this.cmbFractal.Size = new System.Drawing.Size(128, 21);
            this.cmbFractal.TabIndex = 10;
            this.cmbFractal.SelectedIndexChanged += new System.EventHandler(this.cmbFractal_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(673, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 19);
            this.label2.TabIndex = 12;
            this.label2.Text = "Палитра";
            // 
            // cmbPalette
            // 
            this.cmbPalette.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPalette.FormattingEnabled = true;
            this.cmbPalette.Location = new System.Drawing.Point(751, 71);
            this.cmbPalette.Name = "cmbPalette";
            this.cmbPalette.Size = new System.Drawing.Size(128, 21);
            this.cmbPalette.TabIndex = 13;
            this.cmbPalette.SelectedIndexChanged += new System.EventHandler(this.cmbPalette_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(673, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 19);
            this.label1.TabIndex = 14;
            this.label1.Text = "Фрактал";
            // 
            // btnZoomIn
            // 
            this.btnZoomIn.Location = new System.Drawing.Point(25, 19);
            this.btnZoomIn.Name = "btnZoomIn";
            this.btnZoomIn.Size = new System.Drawing.Size(78, 31);
            this.btnZoomIn.TabIndex = 15;
            this.btnZoomIn.Text = "+";
            this.btnZoomIn.UseVisualStyleBackColor = true;
            this.btnZoomIn.Click += new System.EventHandler(this.btnZoomIn_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnZoomOut);
            this.groupBox1.Controls.Add(this.btnZoomIn);
            this.groupBox1.Controls.Add(this.btnLeft);
            this.groupBox1.Controls.Add(this.btnUp);
            this.groupBox1.Controls.Add(this.btnRight);
            this.groupBox1.Controls.Add(this.btnDown);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Location = new System.Drawing.Point(673, 420);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(206, 142);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Навигация";
            // 
            // btnZoomOut
            // 
            this.btnZoomOut.Location = new System.Drawing.Point(109, 19);
            this.btnZoomOut.Name = "btnZoomOut";
            this.btnZoomOut.Size = new System.Drawing.Size(78, 31);
            this.btnZoomOut.TabIndex = 17;
            this.btnZoomOut.Text = "-";
            this.btnZoomOut.UseVisualStyleBackColor = true;
            this.btnZoomOut.Click += new System.EventHandler(this.btnZoomOut_Click);
            // 
            // groupBoxJulia
            // 
            this.groupBoxJulia.Controls.Add(this.lblB);
            this.groupBoxJulia.Controls.Add(this.lblA);
            this.groupBoxJulia.Controls.Add(this.trackBar2);
            this.groupBoxJulia.Controls.Add(this.trackBar1);
            this.groupBoxJulia.Location = new System.Drawing.Point(678, 125);
            this.groupBoxJulia.Name = "groupBoxJulia";
            this.groupBoxJulia.Size = new System.Drawing.Size(201, 115);
            this.groupBoxJulia.TabIndex = 17;
            this.groupBoxJulia.TabStop = false;
            this.groupBoxJulia.Text = "Жулиа";
            // 
            // lblB
            // 
            this.lblB.Location = new System.Drawing.Point(6, 65);
            this.lblB.Name = "lblB";
            this.lblB.Size = new System.Drawing.Size(40, 23);
            this.lblB.TabIndex = 3;
            this.lblB.Text = "b=";
            // 
            // lblA
            // 
            this.lblA.Location = new System.Drawing.Point(6, 19);
            this.lblA.Name = "lblA";
            this.lblA.Size = new System.Drawing.Size(57, 23);
            this.lblA.TabIndex = 2;
            this.lblA.Text = "a=";
            // 
            // trackBar2
            // 
            this.trackBar2.Location = new System.Drawing.Point(60, 65);
            this.trackBar2.Maximum = 20;
            this.trackBar2.Name = "trackBar2";
            this.trackBar2.Size = new System.Drawing.Size(135, 45);
            this.trackBar2.TabIndex = 1;
            this.trackBar2.ValueChanged += new System.EventHandler(this.trackBar2_ValueChanged);
            this.trackBar2.MouseUp += new System.Windows.Forms.MouseEventHandler(this.trackBar_MouseUp);
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(60, 19);
            this.trackBar1.Maximum = 20;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(135, 45);
            this.trackBar1.TabIndex = 0;
            this.trackBar1.ValueChanged += new System.EventHandler(this.trackBar1_ValueChanged);
            this.trackBar1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.trackBar_MouseUp);
            // 
            // groupBoxNewton
            // 
            this.groupBoxNewton.Controls.Add(this.label3);
            this.groupBoxNewton.Controls.Add(this.cmbRoots);
            this.groupBoxNewton.Location = new System.Drawing.Point(678, 264);
            this.groupBoxNewton.Name = "groupBoxNewton";
            this.groupBoxNewton.Size = new System.Drawing.Size(201, 57);
            this.groupBoxNewton.TabIndex = 18;
            this.groupBoxNewton.TabStop = false;
            this.groupBoxNewton.Text = "Ньютон";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(20, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 23);
            this.label3.TabIndex = 1;
            this.label3.Text = "Число корней:";
            // 
            // cmbRoots
            // 
            this.cmbRoots.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRoots.FormattingEnabled = true;
            this.cmbRoots.Location = new System.Drawing.Point(126, 19);
            this.cmbRoots.Name = "cmbRoots";
            this.cmbRoots.Size = new System.Drawing.Size(69, 21);
            this.cmbRoots.TabIndex = 0;
            this.cmbRoots.SelectedIndexChanged += new System.EventHandler(this.cmbRoots_SelectedIndexChanged);
            // 
            // lblElapsedTime
            // 
            this.lblElapsedTime.Location = new System.Drawing.Point(673, 565);
            this.lblElapsedTime.Name = "lblElapsedTime";
            this.lblElapsedTime.Size = new System.Drawing.Size(206, 20);
            this.lblElapsedTime.TabIndex = 19;
            this.lblElapsedTime.Text = "label4";
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(891, 685);
            this.Controls.Add(this.lblElapsedTime);
            this.Controls.Add(this.groupBoxNewton);
            this.Controls.Add(this.groupBoxJulia);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbPalette);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbFractal);
            this.Controls.Add(this.lblXmax);
            this.Controls.Add(this.lblXmin);
            this.Controls.Add(this.lblYmin);
            this.Controls.Add(this.lblYmax);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FrmMain";
            this.Text = "Фракталы Жулиа, Мандельброта, Ньютона";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            ((System.ComponentModel.ISupportInitialize) (this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBoxJulia.ResumeLayout(false);
            this.groupBoxJulia.PerformLayout();
            ((System.ComponentModel.ISupportInitialize) (this.trackBar2)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.trackBar1)).EndInit();
            this.groupBoxNewton.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Button btnDown;
        private System.Windows.Forms.Button btnLeft;
        private System.Windows.Forms.Button btnRight;
        private System.Windows.Forms.Button btnUp;
        private System.Windows.Forms.Button btnZoomIn;
        private System.Windows.Forms.Button btnZoomOut;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox cmbFractal;
        private System.Windows.Forms.ComboBox cmbPalette;
        private System.Windows.Forms.ComboBox cmbRoots;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBoxJulia;
        private System.Windows.Forms.GroupBox groupBoxNewton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblA;
        private System.Windows.Forms.Label lblB;
        private System.Windows.Forms.Label lblElapsedTime;
        private System.Windows.Forms.Label lblXmax;
        private System.Windows.Forms.Label lblXmin;
        private System.Windows.Forms.Label lblYmax;
        private System.Windows.Forms.Label lblYmin;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.TrackBar trackBar2;

        #endregion
    }
}


