using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dmitriev_01_struct_and_class
{
    /// <summary>
    /// Структура, представляющая комплексное число
    /// </summary>
    struct ComplexNum
    {
        public double re;  // действительная часть комплекстого числа
        public double im;  // мнимая часть комплексного числа

        /// <summary>
        /// Сложение комплексных чисел
        /// </summary>
        public ComplexNum Plus(ComplexNum x)
        {
            ComplexNum y;
            y.re = re + x.re;
            y.im = im + x.im;            
            return y;
        }

        /// <summary>
        /// Вычитания комплексных чисел
        /// </summary>
        public ComplexNum Minus(ComplexNum x)
        {
            ComplexNum y;
            y.re = re - x.re;
            y.im = im - x.im;
            return y;
        }

        /// <summary>
        /// Умножение комплексных чисел
        /// </summary>
        public ComplexNum Multi(ComplexNum x)
        {
            ComplexNum y;
            // a - re, b - im
            // c - x.re, d - x.im
            // (ac - bd) + (bc + ad) i
            y.re = re * x.re - im * x.im;
            y.im = im * x.re + re * x.im;            
            return y;
        }

        /// <summary>
        /// Переопределение метода ToString
        /// </summary>
        public override string ToString()
        {
            return string.Format("{0}+{1}i", re, im);
        }
    }
}
