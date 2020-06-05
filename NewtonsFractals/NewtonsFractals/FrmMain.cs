using System;
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

        #endregion
        
        #region private

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