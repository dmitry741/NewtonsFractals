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

        private Bitmap _bitmap = null;
        private byte[] _rgbValues = null;
        readonly List<Palette> _palettes = new List<Palette>();
        private Palette _colors = null;

        private const double cStep = 10;

        private const double cXmin = -1.5;
        private const double cXmax = 1.5;
        private const double cYmin = -1.5;
        private const double cYmax = 1.5;
        
        private double _xmin = cXmin;
        private double _xmax = cXmax;
        private double _ymin = cYmin;
        private double _ymax = cYmax;

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
            _palettes.Add(CreateColdPalette());
            _palettes.Add(CreateHotPalette());
        }

        Bitmap CreateBackground(int width, int height)
        {
            return (width > 0 || height > 0) ? new Bitmap(width, height, System.Drawing.Imaging.PixelFormat.Format24bppRgb) : null;
        }

        Bitmap UpdateBitmap()
        {
            Rectangle rect = new Rectangle(0, 0, _bitmap.Width, _bitmap.Height);
            System.Drawing.Imaging.BitmapData bmpData = _bitmap.LockBits(rect, System.Drawing.Imaging.ImageLockMode.ReadWrite, System.Drawing.Imaging.PixelFormat.Format24bppRgb);

            int stride = bmpData.Stride;
            int bytes = Math.Abs(stride) * _bitmap.Height;
            
            FractalBitmap fbi = new FractalBitmap()
            {
                BitmapWidth = _bitmap.Width,
                BitmapHeight = _bitmap.Height,
                Xmin = _xmin,
                Xmax = _xmax,
                Ymin = _ymin,
                Ymax = _ymax
            };
            
            AbstractDynamicFractal fractal = new JuliaFractal(new Complex(-0.22, -0.74));
            //AbstractDynamicFractal fractal = new MandelbrotFractal();
            //AbstractDynamicFractal fractal = new NewtonFractal(5);

            fbi.GetBitmap(fractal, _colors.Colors, stride, _rgbValues);

            System.Runtime.InteropServices.Marshal.Copy(_rgbValues, 0, bmpData.Scan0, bytes);
            _bitmap.UnlockBits(bmpData);

            return _bitmap;
        }

        void UpdateEdges()
        {
            const int cSigns = 2;

            lblXmin.Text = Math.Round(_xmin, cSigns).ToString();
            lblXmax.Text = Math.Round(_xmax, cSigns).ToString();
            lblYmin.Text = Math.Round(_ymin, cSigns).ToString();
            lblYmax.Text = Math.Round(_ymax, cSigns).ToString();
        }

        #endregion

        private void FrmMain_Load(object sender, EventArgs e)
        {
            _bitmap = CreateBackground(pictureBox1.Width, pictureBox1.Height);
            if (_bitmap != null)
            {
                Rectangle rect = new Rectangle(0, 0, _bitmap.Width, _bitmap.Height);
                System.Drawing.Imaging.BitmapData bmpData = _bitmap.LockBits(rect, System.Drawing.Imaging.ImageLockMode.ReadWrite, System.Drawing.Imaging.PixelFormat.Format24bppRgb);
                int stride = bmpData.Stride;
                int bytes = Math.Abs(stride) * _bitmap.Height;
                _rgbValues = new byte[bytes];
                _bitmap.UnlockBits(bmpData);
            }
            
            CreatePalettes();
            _colors = _palettes[0];

            pictureBox1.Image = UpdateBitmap();
            UpdateEdges();
        }

        private void btnLeft_Click(object sender, EventArgs e)
        {
            double s = (_xmax - _xmin) / cStep;
            _xmax -= s;
            _xmin -= s;
            
            pictureBox1.Image = UpdateBitmap();
            UpdateEdges();
        }

        private void btnRight_Click(object sender, EventArgs e)
        {
            double s = (_xmax - _xmin) / cStep;
            _xmax += s;
            _xmin += s;
            
            pictureBox1.Image = UpdateBitmap();
            UpdateEdges();
        }
    }
}