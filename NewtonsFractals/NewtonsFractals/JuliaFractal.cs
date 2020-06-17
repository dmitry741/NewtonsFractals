namespace NewtonsFractals
{
    public class JuliaFractal : AbstractDynamicFractal
    {
        private Complex _c;
        
        public JuliaFractal(Complex c)
        {
            _c = c;
        }

        public override Complex Iteration(Complex z)
        {
            return z * z + _c;
        }

        public override bool Check(Complex z)
        {
            return z.ModuleInSquare > 16.0;
        }
    }
}