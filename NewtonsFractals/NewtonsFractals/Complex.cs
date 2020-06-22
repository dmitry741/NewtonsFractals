using System;

namespace NewtonsFractals
{
    /// <summary>
    /// Класс комплексных чисел
    /// </summary>
    public class Complex
    {
        public Complex(double re, double im)
        {
            Re = re;
            Im = im;
        }

        /// <summary>
        /// Реальная часть комплексного числа.
        /// </summary>
        public double Re { get; private set; }

        /// <summary>
        /// Мнимая часть комплекстного числа.
        /// </summary>
        public double Im { get; private set; }

        /// <summary>
        /// Модуль комплексного числа.
        /// </summary>
        public double Module => Math.Sqrt(Re * Re + Im * Im);
        
        /// <summary>
        /// Квадрат модуля комплексного числа.
        /// </summary>
        public double ModuleInSquare => Re * Re + Im * Im;

        public static Complex operator +(Complex a, Complex b)
        {
            return new Complex(a.Re + b.Re, a.Im + b.Im);
        }
        
        public static Complex operator +(Complex a, double b)
        {
            return new Complex(a.Re + b, a.Im);
        }
        
        public static Complex operator -(Complex a, Complex b)
        {
            return new Complex(a.Re - b.Re, a.Im - b.Im);
        }

        public static Complex operator *(Complex a, Complex b)
        {
            return new Complex(a.Re * b.Re - a.Im * b.Im, a.Im * b.Re + a.Re * b.Im);
        }
        
        public static Complex operator *(double a, Complex b)
        {
            return new Complex(b.Re * a, b.Im * a);
        }

        public static Complex operator /(Complex a, Complex b)
        {
            double m2 = b.ModuleInSquare;
            return new Complex((a.Re * b.Re + a.Im * b.Im) / m2, (a.Im * b.Re - a.Re * b.Im) / m2);
        }
        
        public static Complex operator ^(Complex a, int power)
        {
            Complex result = new Complex(1, 0);

            for (int i = 0; i < power; i++)
            {
                result *= a;
            }

            return result;
        }
    }
}