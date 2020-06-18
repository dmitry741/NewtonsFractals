using System.Windows.Forms;

namespace NewtonsFractals
{
    public abstract class AbstractDynamicFractal
    {
        public int MaxIterationCount { get; set; }
        public Complex Start { get; set; }
        
        #region === abstarct ===
        
        protected abstract Complex NextIteration(Complex z);
        protected abstract bool Check(Complex z);

        #endregion

        public int GetIteration()
        {
            Complex z1 = Start;
            int index = -1;

            for (int i = 0; i < MaxIterationCount; i++)
            {
                Complex z2 = NextIteration(z1);

                if (Check(z2))
                {
                    index = i;
                    break;
                }

                z1 = z2;
            }

            return index;
        }
    }
}