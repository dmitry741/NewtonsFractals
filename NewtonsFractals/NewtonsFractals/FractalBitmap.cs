using System.Collections.Generic;
using System.Drawing;

namespace NewtonsFractals
{
    public class FractalBitmap
    {
        public FractalBitmap(int width, int height)
        {
            _bitmapWidth = width;
            _bitmapHeight = height;
        }

        #region === members ===
        
        private readonly int _bitmapWidth;
        private readonly int _bitmapHeight;
        
        #endregion
        
        public double Xmin { get; set; }
        public double Xmax { get; set; }
        public double Ymin { get; set; }
        public double Ymax { get; set; }

        public byte[] GetBitmap(AbstractDynamicFractal fractal, List<Color> colors)
        {
            fractal.MaxIterationCount = colors.Count;
            
            double kx = (Xmax - Xmin) / (_bitmapWidth - 1);
            double ky = (Ymin - Ymax) / (_bitmapHeight - 1);
            double re, im;

            for (int i = 0; i < _bitmapWidth; i++)
            {
                re = kx * i + Xmin;
                
                for (int j = 0; j < _bitmapHeight; j++)
                {
                    im = ky * j + Ymax;
                    fractal.Start = new Complex(re, im);
                    int index = fractal.GetIteration();
                    
                    // TODO:
                }
            }
            return default;
        }
    }
}