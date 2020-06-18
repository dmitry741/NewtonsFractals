using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Drawing;

namespace NewtonsFractals
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }
        
        #region memebers

        Bitmap _bitmap = null;
        List<Palette> _palettes = new List<Palette>();
        private Palette _colors = null;

        #endregion
        
        #region private

        Palette CreateHotPalette()
        {
            Palette palette = new Palette();
            
            palette.AddBaseColor(Color.FromArgb(255, 0, 0));
            palette.AddBaseColor(Color.FromArgb(255, 255, 0));
            palette.AddBaseColor(Color.FromArgb(128, 128, 0));
            palette.AddBaseColor(Color.FromArgb(0, 128, 0));
            
            palette.AddBaseColor(Color.FromArgb(0, 255, 0));
            palette.AddBaseColor(Color.FromArgb(0, 255, 255));
            palette.AddBaseColor(Color.FromArgb(0, 0, 192));
            palette.AddBaseColor(Color.FromArgb(0, 0, 128));
            
            palette.CreatePalette();

            return palette;
        }
        
        Palette CreateColdPalette()
        {
            Palette palette = new Palette();
            
            palette.AddBaseColor(Color.FromArgb(0, 0, 128));
            palette.AddBaseColor(Color.FromArgb(0, 0, 192));
            palette.AddBaseColor(Color.FromArgb(0, 255, 255));
            palette.AddBaseColor(Color.FromArgb(0, 255, 0));
            
            palette.AddBaseColor(Color.FromArgb(0, 128, 0));
            palette.AddBaseColor(Color.FromArgb(128, 128, 0));
            palette.AddBaseColor(Color.FromArgb(255, 255, 0));
            palette.AddBaseColor(Color.FromArgb(255, 0, 0));
            
            palette.CreatePalette();

            return palette;
        }

        void CreatePalettes()
        {
            _palettes.Add(CreateHotPalette());
            _palettes.Add(CreateColdPalette());
        }

        void Render()
        {
            if (_bitmap == null)
                return;

            Graphics g = Graphics.FromImage(_bitmap);
            g.Clear(Color.White);

            g.DrawString("All ok", new Font("Arial", 24f, FontStyle.Regular), Brushes.Black, new Point(20, 20));

            // TODO:

            pictureBox1.Image = _bitmap;
        }

        Bitmap CreateBackground(int width, int height)
        {
            return (width > 0 || height > 0) ? new Bitmap(width, height, System.Drawing.Imaging.PixelFormat.Format24bppRgb) : null;
        }

        #endregion

        private void FrmMain_Load(object sender, EventArgs e)
        {
            pictureBox1.BackColor = Color.White;
            _bitmap = CreateBackground(pictureBox1.Width, pictureBox1.Height);
            CreatePalettes();
            _colors = _palettes[0];
        }

        private void pictureBox1_SizeChanged(object sender, EventArgs e)
        {
            _bitmap = CreateBackground(pictureBox1.Width, pictureBox1.Height);
        }

        private void FrmMain_Paint(object sender, PaintEventArgs e)
        {
            Render();
        }
    }
}