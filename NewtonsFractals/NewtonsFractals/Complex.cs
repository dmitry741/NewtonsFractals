namespace NewtonsFractals
{
    /// <summary>
    /// Класс комплексных чисел
    /// </summary>
    public class Complex
    {
        private double _re;
        private double _im;

        public Complex()
        {
            _re = _im = 0;
        }

        public Complex(double re, double im)
        {
            _re = re;
            _im = im;
        }

        public double Re => _re;
        public double Im => _im;

        public static Complex operator +(Complex a, Complex b)
        {
            return new Complex(a.Re + b.Re, b.Im + b.Im);
        }
        
        public static  Complex operator-(Complex a, Complex b)
        {
            return new Complex(a.Re - b.Re, b.Im - b.Im);
        }
    }
}