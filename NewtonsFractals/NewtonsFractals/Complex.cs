using System;

namespace NewtonsFractals
{
    /// <summary>
    /// Класс комплексных чисел
    /// </summary>
    public class Complex
    {
        public Complex()
        {
            Re = Im = 0;
        }

        public Complex(double re, double im)
        {
            Re = re;
            Im = im;
        }

        public double Re { get; private set; }

        public double Im { get; private set; }

        public double Module => Math.Sqrt(Re * Re + Im * Im);
        public double ModuleInSquare => Re * Re + Im * Im;

        public static Complex operator +(Complex a, Complex b)
        {
            return new Complex(a.Re + b.Re, b.Im + b.Im);
        }
        
        public static Complex operator -(Complex a, Complex b)
        {
            return new Complex(a.Re - b.Re, b.Im - b.Im);
        }

        public static Complex operator *(Complex a, Complex b)
        {
            return new Complex(a.Re * b.Re - a.Im * b.Im, a.Im * b.Re + a.Re * b.Im);
        }

        public static Complex operator /(Complex a, Complex b)
        {
            double module2 = b.Re * b.Re + b.Im * b.Im;
            return new Complex((a.Re * b.Re + a.Im * b.Im) / module2, (a.Im * b.Re - a.Re * b.Im) / module2);
        }
    }
}