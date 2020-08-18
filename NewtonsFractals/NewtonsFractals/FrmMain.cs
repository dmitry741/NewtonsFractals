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

        private const double cXmin = -1.75;
        private const double cXmax = 1.75;
        private const double cYmin = -1.75;
        private const double cYmax = 1.75;
        
        private double _xmin = cXmin;
        private double _xmax = cXmax;
        private double _ymin = cYmin;
        private double _ymax = cYmax;

        private int _zoom = 0;
        private bool _blockEventHandler = false;
        private int _timeSpan;

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

        Bitmap GetFractal()
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

            _timeSpan = fbi.GetBitmap(Fractal, _colors.Colors, stride, _rgbValues);

            System.Runtime.InteropServices.Marshal.Copy(_rgbValues, 0, bmpData.Scan0, bytes);
            _bitmap.UnlockBits(bmpData);

            return _bitmap;
        }

        void UpdateFractal()
        {
            pictureBox1.Image = GetFractal();
            lblElapsedTime.Text = string.Format("Время построения: {0} мс", _timeSpan);
        }

        void UpdateEdges()
        {
            const int cSigns = 2;

            lblXmin.Text = Math.Round(_xmin, cSigns).ToString();
            lblXmax.Text = Math.Round(_xmax, cSigns).ToString();
            lblYmin.Text = Math.Round(_ymin, cSigns).ToString();
            lblYmax.Text = Math.Round(_ymax, cSigns).ToString();
        }

        AbstractDynamicFractal Fractal
        {
            get
            {
                AbstractDynamicFractal fractal;

                if (cmbFractal.SelectedIndex == 0)
                {
                    var a = 2.0 / (trackBar1.Maximum - trackBar1.Minimum) * (trackBar1.Value - trackBar1.Minimum) - 1;
                    var b = 2.0 / (trackBar2.Maximum - trackBar2.Minimum) * (trackBar2.Value - trackBar2.Minimum) - 1;

                    fractal = new JuliaFractal(new Complex(a, b));
                }
                else if (cmbFractal.SelectedIndex == 1)
                {
                    fractal = new MandelbrotFractal();
                }
                else
                {
                    fractal = new NewtonFractal((int)cmbRoots.Items[cmbRoots.SelectedIndex]);
                }

                return fractal;
            }
        }

        #endregion

        private void FrmMain_Load(object sender, EventArgs e)
        {
            _bitmap = CreateBackground(pictureBox1.Width, pictureBox1.Height);
            if (_bitmap != null)
            {
                Rectangle rect = new Rectangle(0, 0, _bitmap.Width, _bitmap.Height);
                System.Drawing.Imaging.BitmapData bmpData = _bitmap.LockBits(rect, 
                System.Drawing.Imaging.ImageLockMode.ReadWrite, 
                System.Drawing.Imaging.PixelFormat.Format24bppRgb);
                int stride = bmpData.Stride;
                int bytes = Math.Abs(stride) * _bitmap.Height;
                _rgbValues = new byte[bytes];
                _bitmap.UnlockBits(bmpData);
            }
            
            CreatePalettes();

            _blockEventHandler = true;
            
            cmbPalette.Items.Add("Синяя");
            cmbPalette.Items.Add("Оранжевая");
            cmbPalette.SelectedIndex = 0;

            cmbFractal.Items.Add("Жюлиа");
            cmbFractal.Items.Add("Мандельброт");
            cmbFractal.Items.Add("Ньютон");
            cmbFractal.SelectedIndex = 0;

            double a = -0.2;
            double b = -0.7;

            trackBar1.Value = Convert.ToInt32((trackBar1.Maximum - trackBar1.Minimum) / 2.0 * (a + 1) + trackBar1.Minimum);
            trackBar2.Value = Convert.ToInt32((trackBar1.Maximum - trackBar1.Minimum) / 2.0 * (b + 1) + trackBar1.Minimum);

            lblA.Text = string.Format("a={0}", Math.Round(a, 2));
            lblB.Text = string.Format("b={0}", Math.Round(b, 2));

            groupBoxNewton.Location = groupBoxJulia.Location;
            groupBoxNewton.Visible = false;

            for (int i = 3; i <= 6; i++)
            {
                cmbRoots.Items.Add(i);
            }
            cmbRoots.SelectedIndex = 0;
            
            _blockEventHandler = false;
            
            _colors = _palettes[0];
            UpdateFractal();
            UpdateEdges();
        }

        private void btnLeft_Click(object sender, EventArgs e)
        {
            double s = (_xmax - _xmin) / cStep;
            _xmax -= s;
            _xmin -= s;
            
            UpdateFractal();
            UpdateEdges();
        }

        private void btnRight_Click(object sender, EventArgs e)
        {
            double s = (_xmax - _xmin) / cStep;
            _xmax += s;
            _xmin += s;
            
            UpdateFractal();
            UpdateEdges();
        }

        private void btnUp_Click(object sender, EventArgs e)
        {
            double s = (_ymax - _ymin) / cStep;
            _ymax += s;
            _ymin += s;
            
            UpdateFractal();
            UpdateEdges();
        }

        private void btnDown_Click(object sender, EventArgs e)
        {
            double s = (_ymax - _ymin) / cStep;
            _ymax -= s;
            _ymin -= s;
            
            UpdateFractal();
            UpdateEdges();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            _xmin = cXmin;
            _xmax = cXmax;
            _ymin = cYmin;
            _ymax = cYmax;

            _zoom = 0;
            
            UpdateFractal();
            UpdateEdges();
        }

        private void cmbPalette_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (_blockEventHandler)
                return;
            
            _colors = _palettes[cmbPalette.SelectedIndex];
            UpdateFractal();
        }

        private void cmbFractal_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (_blockEventHandler)
                return;

            _xmin = cXmin;
            _xmax = cXmax;
            _ymin = cYmin;
            _ymax = cYmax;

            _zoom = 0;

            if (cmbFractal.SelectedIndex == 0) // Жулиа
            {
                groupBoxJulia.Visible = true;
                groupBoxNewton.Visible = false;
            }
            else if (cmbFractal.SelectedIndex == 1) // Мандельброт 
            {
                groupBoxJulia.Visible = false;
                groupBoxNewton.Visible = false;
            }
            else // Ньютон
            {
                groupBoxJulia.Visible = false;
                groupBoxNewton.Visible = true;
            }

            UpdateFractal();
            UpdateEdges();
        }

        private void btnZoomIn_Click(object sender, EventArgs e)
        {
            if (_zoom >= 0)
            {
                if (_xmax - _xmin < 0.1 || _ymax - _ymin < 0.1)
                    return;
                
                double dx = (_xmax - _xmin) / cStep;
                double dy = (_ymax - _ymin) / cStep;

                _xmin += dx;
                _xmax -= dx;
                _ymin += dy;
                _ymax -= dy;

                _zoom++;
            }
            else
            {
                double xmax = ((cStep + 1) * _xmax + _xmin) / (cStep + 2);
                double xmin = ((cStep + 1) * _xmin + _xmax) / (cStep + 2);
                double ymax = ((cStep + 1) * _ymax + _ymin) / (cStep + 2);
                double ymin = ((cStep + 1) * _ymin + _ymax) / (cStep + 2);

                _xmin = xmin;
                _xmax = xmax;
                _ymin = ymin;
                _ymax = ymax;

                _zoom--;
            }
            
            UpdateFractal();
            UpdateEdges();
        }

        private void btnZoomOut_Click(object sender, EventArgs e)
        {
            if (_zoom <= 0)
            {
                double dx = (_xmax - _xmin) / cStep;
                double dy = (_ymax - _ymin) / cStep;

                _xmin -= dx;
                _xmax += dx;
                _ymin -= dy;
                _ymax += dy;
                
                _zoom--;
            }
            else
            {
                double xmax = ((cStep - 1) * _xmax - _xmin) / (cStep - 2);
                double xmin = ((cStep - 1) * _xmin - _xmax) / (cStep - 2);
                double ymax = ((cStep - 1) * _ymax - _ymin) / (cStep - 2);
                double ymin = ((cStep - 1) * _ymin - _ymax) / (cStep - 2);

                _xmin = xmin;
                _xmax = xmax;
                _ymin = ymin;
                _ymax = ymax;
                
                _zoom++;
            }
            
            UpdateFractal();
            UpdateEdges();
        }

        private void trackBar1_ValueChanged(object sender, EventArgs e)
        {
            double a = 2.0 / (trackBar1.Maximum - trackBar1.Minimum) * (trackBar1.Value - trackBar1.Minimum) - 1; 
            lblA.Text = string.Format("a={0}", Math.Round(a, 2));
        }
        
        private void trackBar2_ValueChanged(object sender, EventArgs e)
        {
            double b = 2.0 / (trackBar2.Maximum - trackBar2.Minimum) * (trackBar2.Value - trackBar2.Minimum) - 1; 
            lblB.Text = string.Format("b={0}", Math.Round(b, 2));
        }

        private void trackBar_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                UpdateFractal();
            }
        }

        private void cmbRoots_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (_blockEventHandler)
                return;
            
            UpdateFractal();
            UpdateEdges();
        }
    }
}