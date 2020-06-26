using System;
using System.Collections.Generic;
using System.Drawing;

namespace NewtonsFractals
{
    /// <summary>
    /// Класс получения для получения массива цветов.
    /// </summary>
    public class FractalBitmap
    {
        public int BitmapWidth { get; set; }
        public int BitmapHeight { get; set; }
        public double Xmin { get; set; }
        public double Xmax { get; set; }
        public double Ymin { get; set; }
        public double Ymax { get; set; }

        /// <summary>
        /// Заполнение массива цветов rgbValues.
        /// </summary>
        /// <param name="fractal">Объект AbstractDynamicFractal.</param>
        /// <param name="colors">Палитра (список) цветов.</param>
        /// <param name="stride">Stride изображения.</param>
        /// <param name="rgbValues">Массив цветов для заполнения. </param>
        /// <returns>Время работы в миллисекундах</returns>
        public int GetBitmap(AbstractDynamicFractal fractal, List<Color> colors, int stride, byte[] rgbValues)
        {
            System.Diagnostics.Stopwatch stopWatch = new System.Diagnostics.Stopwatch();
            stopWatch.Start();
            
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
            
            stopWatch.Stop();

            return stopWatch.Elapsed.Milliseconds;
        }
    }
}