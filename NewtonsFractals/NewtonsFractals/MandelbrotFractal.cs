namespace NewtonsFractals
{
    /// <summary>
    ///  Фрактал Мандельброта.
    /// </summary>
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
        
        public override AbstractDynamicFractal Copy() { return new MandelbrotFractal(); }
    }
}