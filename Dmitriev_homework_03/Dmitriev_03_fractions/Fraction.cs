namespace Dmitriev_03_fractions
{
    /// <summary>
    /// Класс, представляющий дроби
    /// </summary>
    public class Fraction
    {
        int dividend;  // делимое, числитель
        int divider;  // делитель, знаменатель

        /// <summary>
        /// Конструктор по умолчанию
        /// </summary>
        public Fraction()
        {
            dividend = 0;
            divider = 0;
        }

        /// <summary>
        /// Конструктор класса дороби с двумя параметрами
        /// </summary>
        public Fraction(int dividend, int divider)
        {
            this.dividend = dividend;
            this.divider = divider;
        }

        /// <summary>
        /// Сложение дробей
        /// </summary>
        public Fraction Plus(Fraction f2)
        {
            Fraction f3 = new Fraction();

            if (divider == f2.divider)
            {
                f3.dividend = dividend + f2.dividend;
                f3.divider = divider;
            }
            else
            {
                f3.divider = LeastCommonMultiple(divider, f2.divider);
                f3.dividend = dividend * (f3.divider / divider) + f2.dividend * (f3.divider / f2.divider);
            }

            return f3;
        }

        /// <summary>
        /// Вычетание дробей
        /// </summary>
        public Fraction Minus(Fraction f2)
        {
            Fraction f3 = new Fraction();
            if (divider == f2.divider)
            {
                f3.dividend = dividend - f2.dividend;
                f3.divider = divider;
            }
            else
            {
                f3.divider = LeastCommonMultiple(divider, f2.divider);
                f3.dividend = dividend * (f3.divider / divider) - f2.dividend * (f3.divider / f2.divider);
            }
            return f3;
        }

        /// <summary>
        /// Умножение дробей
        /// </summary>
        public Fraction Multi(Fraction f2)
        {
            Fraction f3 = new Fraction();

            f3.dividend = dividend * f2.dividend;
            f3.divider = divider * f2.divider;

            return f3;
        }

        /// <summary>
        /// Деление дробей
        /// </summary>
        public Fraction Div(Fraction f2)
        {
            Fraction f3 = new Fraction();

            f3.dividend = dividend * f2.divider;
            f3.divider = f2.dividend * divider;

            return f3;
        }

        public override string ToString()
        {
            return string.Format("{0}/{1}", dividend, divider);
        }

        #region вспомогательные внутренние методы

        /// <summary>
        /// Нахождение наименьшего общего кратного (НОК)
        /// </summary>
        private int LeastCommonMultiple(int a, int b)
        {            
            if (a == b) return a;

            int i = Max(a, b);

            do
            {
                i++;                
            } while ((i % a != 0) || (i % b != 0));

            return i;
        }

        /// <summary>
        /// Определение максимального из двух целых чисел
        /// </summary>
        private int Max(int a, int b)
        {
            int max = a > b ? a : b;
            return max;
        }

        #endregion
    }
}
