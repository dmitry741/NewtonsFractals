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
    }
}