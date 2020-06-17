namespace NewtonsFractals
{
    public class MandelbrotFractal : AbstractDynamicFractal
    {
        public override Complex Iteration(Complex z)
        {
            return z * z + Start;
        }

        public override bool Check(Complex z)
        {
            return z.ModuleInSquare > 16.0;
        }
    }
}