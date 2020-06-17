namespace NewtonsFractals
{
    public class NewtonFractal : AbstractDynamicFractal
    {
        private int _k;

        public NewtonFractal(int k)
        {
            _k = k;
        }

        public override Complex Iteration(Complex z)
        {
            Complex numerator = (_k - 1) * z^_k + 1;
            Complex denominator = _k * (z^(_k - 1));

            return numerator / denominator;
        }

        public override bool Check(Complex z)
        {
            throw new System.NotImplementedException();
        }
    }
}