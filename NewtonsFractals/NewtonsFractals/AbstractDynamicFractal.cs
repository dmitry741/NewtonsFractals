using System.Windows.Forms;

namespace NewtonsFractals
{
    /// <summary>
    /// Абстрактный класс представляющий фрактал.
    /// </summary>
    public abstract class AbstractDynamicFractal
    {
        /// <summary>
        /// Максимальное количество итераций.
        /// </summary>
        public int MaxIterationCount { get; set; }
        
        /// <summary>
        /// Точка с которой начинается итеративный процесс.  
        /// </summary>
        public Complex Start { get; set; }
        
        #region === abstarct ===
        
        /// <summary>
        /// Получение следующей точки.
        /// </summary>
        /// <param name="z">Исходная точка.</param>
        /// <returns>Новая точка.</returns>
        protected abstract Complex NextIteration(Complex z);
        
        /// <summary>
        /// Проверка условия завершения итеративного процесса.
        /// </summary>
        /// <param name="z">Точка на плоскости.</param>
        /// <returns>True если следует завершить итеративный процесс, False в противоположном случае.</returns>
        protected abstract bool Check(Complex z);

        public abstract AbstractDynamicFractal Copy();

        #endregion

        /// <summary>
        /// Получение индекса, на котором был прерван итеративный процесс.
        /// </summary>
        /// <returns>Индекс итерации.</returns>
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