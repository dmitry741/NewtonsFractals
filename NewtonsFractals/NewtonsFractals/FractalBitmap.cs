using System;
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

        public void GetBitmap(AbstractDynamicFractal fractal, List<Color> colors, int stride, byte[] rgbValues)
        {
            fractal.MaxIterationCount = colors.Count;
            Array.Clear(rgbValues, 0, rgbValues.Length);
            
            double kx = (Xmax - Xmin) / (_bitmapWidth - 1);
            double ky = (Ymin - Ymax) / (_bitmapHeight - 1);

            for (int x = 0; x < _bitmapWidth; x++)
            {
                double re = kx * x + Xmin;
                
                for (int y = 0; y < _bitmapHeight; y++)
                {
                    double im = ky * y + Ymax;
                    fractal.Start = new Complex(re, im);
                    
                    int index = fractal.GetIteration();
                    
                    if (index < 0)
                        continue;
                   
                    rgbValues[y * stride + x * 3 + 0] = colors[index].B;
                    rgbValues[y * stride + x * 3 + 1] = colors[index].G;
                    rgbValues[y * stride + x * 3 + 2] = colors[index].R;
                }
            }
        }
    }
}