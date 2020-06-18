using System;
using System.Collections.Generic;
using System.Drawing;

namespace NewtonsFractals
{
    public class Palette
    {
        private List<Color> _baseColors;
        private List<Color> _palette;

        public void AddBaseColor(Color color)
        {
            _baseColors.Add(color);
        }
        
        void CreatePalette()
        {
            const int c_gradientCount = 8;
            _palette.Clear();

            for (int i = 0; i < _baseColors.Count - 1; i++)
            {
                for (int j = 0; j < c_gradientCount; j++)
                {
                    _palette.Add(GetGradientColor(j, _baseColors[i], _baseColors[i + 1], c_gradientCount));
                }
            }

            _palette.Add( _baseColors[_baseColors.Count - 1] );
        }
        
        Color GetGradientColor(int iteration, Color color1, Color color2, int gradientCount)
        {
            double r1 = color1.R;
            double g1 = color1.G;
            double b1 = color1.B;

            double r2 = color2.R;
            double g2 = color2.G;
            double b2 = color2.B;

            double k = Convert.ToDouble(iteration) / Convert.ToDouble(gradientCount);

            double r = k * (r2 - r1) + r1;
            double g = k * (g2 - g1) + g1;
            double b = k * (b2 - b1) + b1;

            return Color.FromArgb(Convert.ToInt32(r), Convert.ToInt32(g), Convert.ToInt32(b));
        }                
    }
}