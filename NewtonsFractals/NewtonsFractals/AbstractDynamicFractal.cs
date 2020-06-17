using System.Windows.Forms;

namespace NewtonsFractals
{
    public abstract class AbstractDynamicFractal
    {
        public int IterationCount { get; set; }
        public Complex Start { get; set; }
        
        #region === abstarct ===
        
        public abstract Complex Iteration(Complex z);
        public abstract bool Check(Complex z);

        #endregion

        public int GetIteration()
        {
            Complex z1 = Start;
            int index = -1;

            for (int i = 0; i < IterationCount; i++)
            {
                Complex z2 = Iteration(z1);

                if (Check(z1))
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