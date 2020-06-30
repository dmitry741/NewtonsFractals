using System;
using System.Collections.Generic;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Threading.Tasks;

namespace NewtonsFractals
{
    /// <summary>
    /// Класс для заполнения массива пикселей.
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
        /// Заполнение массива изображения с учетом асинхронности.
        /// </summary>
        /// <param name="xmin">Минимальное значение X.</param>
        /// <param name="xmax">Максимальное значение X.</param>
        /// <param name="ymin">Минимальное значение Y.</param>
        /// <param name="ymax">Максимальное значение Y.</param>
        /// <param name="width">Ширина изображения.</param>
        /// <param name="height">Высота изображения.</param>
        /// <param name="fractal">Фрактал.</param>
        /// <param name="start">Стартовое значение по оси Y.</param>
        /// <param name="stop">Конечное значение по оси Y.</param>
        /// <param name="rgbValues">Массив ппикселей для изображения.</param>
        /// <param name="colors">Список цветов.</param>
        /// <param name="stride">Stride изображения.</param>
        static void FillArray(double xmin, double xmax, double ymin, double ymax, int width, int height,
            AbstractDynamicFractal fractal, int start, int stop, byte[] rgbValues, List<Color> colors, int stride)
        {
            fractal.MaxIterationCount = colors.Count;
            
            double kx = (xmax - xmin) / (width - 1);
            double ky = (ymin - ymax) / (height - 1);

            for (int x = 0; x < width; x++)
            {
                double re = kx * x + xmin;
                
                for (int y = start; y <= stop; y++)
                {
                    double im = ky * y + ymax;
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

        /// <summary>
        /// Асинхронный метод для заполнения пикселей изображения.
        /// </summary>
        /// <param name="fractal">Объект AbstractDynamicFractal.</param>
        /// <param name="colors">Палитра (список) цветов.</param>
        /// <param name="stride">Stride изображения.</param>
        /// <param name="rgbValues">Массив цветов для заполнения.</param>
        private void GetAllAsync(AbstractDynamicFractal fractal, List<Color> colors, int stride, byte[] rgbValues)
        {
            var tasks = new List<Task>();

            tasks.Add(Task.Run(()=>FillArray(Xmin, Xmax, Ymin, Ymax, BitmapWidth, BitmapHeight, fractal.Copy(), 
                 0,
                 BitmapHeight / 4,
                rgbValues, colors, stride)));
            
            tasks.Add(Task.Run(()=>FillArray(Xmin, Xmax, Ymin, Ymax, BitmapWidth, BitmapHeight, fractal.Copy(), 
                BitmapHeight / 4 + 1,
                BitmapHeight / 2,
                rgbValues, colors, stride)));
            
            tasks.Add(Task.Run(()=>FillArray(Xmin, Xmax, Ymin, Ymax, BitmapWidth, BitmapHeight, fractal.Copy(), 
                BitmapHeight / 2 + 1,
                3 * BitmapHeight / 4,
                rgbValues, colors, stride)));
            
            tasks.Add(Task.Run(()=>FillArray(Xmin, Xmax, Ymin, Ymax, BitmapWidth, BitmapHeight, fractal.Copy(), 
                3 * BitmapHeight / 4 + 1,
                BitmapHeight - 1,
                rgbValues, colors, stride)));

            Task.WaitAll(tasks.ToArray());
        }

        /// <summary>
        /// Заполнение массива цветов rgbValues.
        /// </summary>
        /// <param name="fractal">Объект AbstractDynamicFractal.</param>
        /// <param name="colors">Палитра (список) цветов.</param>
        /// <param name="stride">Stride изображения.</param>
        /// <param name="rgbValues">Массив цветов для заполнения. </param>
        /// <returns>Время работы в миллисекундах.</returns>
        public int GetBitmap(AbstractDynamicFractal fractal, List<Color> colors, int stride, byte[] rgbValues)
        {
            Array.Clear(rgbValues, 0, rgbValues.Length);
            System.Diagnostics.Stopwatch stopWatch = new System.Diagnostics.Stopwatch();
            stopWatch.Start();
            GetAllAsync(fractal, colors, stride, rgbValues);
            stopWatch.Stop();

            return stopWatch.Elapsed.Seconds * 1000 + stopWatch.Elapsed.Milliseconds;
        }
    }
}