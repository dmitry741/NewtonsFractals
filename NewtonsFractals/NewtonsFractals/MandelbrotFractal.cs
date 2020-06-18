namespace NewtonsFractals
{
    public class MandelbrotFractal : AbstractDynamicFractal
    {
        protected override Complex NextIteration(Complex z)
        {
            return z * z + Start;
        }

        protected override bool Check(Complex z)
        {
            return z.ModuleInSquare > 16.0;
        }
    }
}