﻿namespace NewtonsFractals
{
    public class JuliaFractal : AbstractDynamicFractal
    {
        private readonly Complex _c;
        
        public JuliaFractal(Complex c)
        {
            _c = c;
        }

        protected override Complex NextIteration(Complex z)
        {
            return z * z + _c;
        }

        protected override bool Check(Complex z)
        {
            return z.ModuleInSquare > 16.0;
        }
    }
}