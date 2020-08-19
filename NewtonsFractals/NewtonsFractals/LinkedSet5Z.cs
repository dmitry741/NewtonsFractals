using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewtonsFractals
{
    class LinkedSet5Z : AbstractDynamicFractal
    {
        public override AbstractDynamicFractal Copy()
        {
            return new LinkedSet5Z();
        }

        protected override bool Check(Complex z)
        {
            return z.ModuleInSquare > 16.0;
        }

        protected override Complex NextIteration(Complex z)
        {
            return 0.3333 * z * (5.0 - 2 * z * z);
        }
    }
}
