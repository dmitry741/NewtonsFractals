using System;
using System.Linq;

namespace NewtonsFractals
{
    public class NewtonFractal : AbstractDynamicFractal
    {
        private  readonly int _n;
        private readonly Complex[] _roots;

        public NewtonFractal(int n)
        {
            _n = n;
            _roots = new Complex[_n];
            
            double angle = 2 * Math.PI / _n;

            for (int i = 0; i < _n; i++)
            {
                _roots[i] = new Complex(Math.Cos(angle * i), Math.Sin(angle * i));
            }
        }

        protected override Complex Iteration(Complex z)
        {
            Complex numerator = (_n - 1) * z^_n + 1;
            Complex denominator = _n * (z^(_n - 1));

            return numerator / denominator;
        }

        protected override bool Check(Complex z)
        {
            return _roots.Any(x => (x-z).ModuleInSquare < 0.01);
        }
    }
}