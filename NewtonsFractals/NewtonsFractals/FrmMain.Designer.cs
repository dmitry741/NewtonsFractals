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
            ((System.ComponentModel.ISupportInitialize) (this.pictureBox1)).BeginInit();
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
            this.btnLeft.Location = new System.Drawing.Point(717, 310);
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
            this.btnUp.Location = new System.Drawing.Point(759, 310);
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
            this.btnRight.Location = new System.Drawing.Point(843, 310);
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
            this.btnDown.Location = new System.Drawing.Point(801, 310);
            this.btnDown.Name = "btnDown";
            this.btnDown.Size = new System.Drawing.Size(36, 36);
            this.btnDown.TabIndex = 8;
            this.btnDown.UseVisualStyleBackColor = true;
            this.btnDown.Click += new System.EventHandler(this.btnDown_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(717, 352);
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
            this.cmbFractal.Location = new System.Drawing.Point(751, 99);
            this.cmbFractal.Name = "cmbFractal";
            this.cmbFractal.Size = new System.Drawing.Size(128, 21);
            this.cmbFractal.TabIndex = 10;
            this.cmbFractal.SelectedIndexChanged += new System.EventHandler(this.cmbFractal_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(757, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 19);
            this.label2.TabIndex = 12;
            this.label2.Text = "Палитра";
            // 
            // cmbPalette
            // 
            this.cmbPalette.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPalette.FormattingEnabled = true;
            this.cmbPalette.Location = new System.Drawing.Point(751, 34);
            this.cmbPalette.Name = "cmbPalette";
            this.cmbPalette.Size = new System.Drawing.Size(128, 21);
            this.cmbPalette.TabIndex = 13;
            this.cmbPalette.SelectedIndexChanged += new System.EventHandler(this.cmbPalette_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(751, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 19);
            this.label1.TabIndex = 14;
            this.label1.Text = "Фрактал";
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(891, 685);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbPalette);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbFractal);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnDown);
            this.Controls.Add(this.btnRight);
            this.Controls.Add(this.btnUp);
            this.Controls.Add(this.btnLeft);
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
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Button btnDown;
        private System.Windows.Forms.Button btnLeft;
        private System.Windows.Forms.Button btnRight;
        private System.Windows.Forms.Button btnUp;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox cmbFractal;
        private System.Windows.Forms.ComboBox cmbPalette;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblXmax;
        private System.Windows.Forms.Label lblXmin;
        private System.Windows.Forms.Label lblYmax;
        private System.Windows.Forms.Label lblYmin;
        private System.Windows.Forms.PictureBox pictureBox1;

        #endregion
    }
}


