using System;
using System.Collections.Generic;
using System.Drawing;

namespace NewtonsFractals
{
    public class FractalBitmap
    {
        public int BitmapWidth { get; set; }
        public int BitmapHeight { get; set; }
        public double Xmin { get; set; }
        public double Xmax { get; set; }
        public double Ymin { get; set; }
        public double Ymax { get; set; }

        public void GetBitmap(AbstractDynamicFractal fractal, List<Color> colors, int stride, byte[] rgbValues)
        {
            fractal.MaxIterationCount = colors.Count;
            Array.Clear(rgbValues, 0, rgbValues.Length);
            
            double kx = (Xmax - Xmin) / (BitmapWidth - 1);
            double ky = (Ymin - Ymax) / (BitmapHeight - 1);

            for (int x = 0; x < BitmapWidth; x++)
            {
                double re = kx * x + Xmin;
                
                for (int y = 0; y < BitmapHeight; y++)
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