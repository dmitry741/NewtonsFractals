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

            //Graphics g = Graphics.FromImage(_bitmap);
            //g.Clear(Color.White);

            Rectangle rect = new Rectangle(0, 0, _bitmap.Width, _bitmap.Height);
            System.Drawing.Imaging.BitmapData bmpData = _bitmap.LockBits(rect, System.Drawing.Imaging.ImageLockMode.ReadWrite, System.Drawing.Imaging.PixelFormat.Format24bppRgb);

            int stride = bmpData.Stride;
            int bytes = Math.Abs(stride) * _bitmap.Height;
            byte[] rgbValues = new byte[bytes];

            FractalBitmap fbi = new FractalBitmap(_bitmap.Width, _bitmap.Height)
            {
                Xmin = -1.5,
                Xmax = 1.5,
                Ymin = -1.5,
                Ymax = 1.5
            };
            
            AbstractDynamicFractal fractal = new JuliaFractal(new Complex(-0.22, -0.74));
            //AbstractDynamicFractal fractal = new MandelbrotFractal();
            //AbstractDynamicFractal fractal = new NewtonFractal(3);

            fbi.GetBitmap(fractal, _colors.Colors, stride, rgbValues);

            System.Runtime.InteropServices.Marshal.Copy(rgbValues, 0, bmpData.Scan0, bytes);
            _bitmap.UnlockBits(bmpData);

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
            _colors = _palettes[1];
        }

        private void pictureBox1_SizeChanged(object sender, EventArgs e)
        {
            _bitmap = CreateBackground(pictureBox1.Width, pictureBox1.Height);
        }

        private void FrmMain_Paint(object sender, PaintEventArgs e)
        {
            Render();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }
    }
}