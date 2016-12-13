using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dmitriev_01_struct_and_class
{
    /// <summary>
    /// Класс, описывающий комплексное число
    /// </summary>
    public class Complex
    {
        double re;  // действительная часть комплексного числа
        double im;  // мнимая часть комплексного числа

        public Complex()
        {
            re = 0;
            im = 0;
        }

        /// <summary>
        /// Создает экземпляр класса комплексного числа с заданными в параметрах значениями
        /// действительной и мнимой части
        /// </summary>
        /// <param name="re">Действительная часть</param>
        /// <param name="im">Мнимая часть</param>
        public Complex (double re, double im)
        {
            this.re = re;
            this.im = im;
        }

        /// <summary>
        /// Сложение комплексных чисел
        /// </summary>
        public Complex Plus(Complex x2)
        {
            Complex x3 = new Complex();
            x3.re = x2.re + re;
            x3.im = x2.im + im;
            return x3;
        }

        /// <summary>
        /// Свойство класса. 
        /// Предоставляет доступ к мнимой части комплексного числа.
        /// </summary>
        public double Im
        {
            get { return im; }
            set
            {
                if (value >= 0) im = value;
            }
        }

        /// <summary>
        /// Вычетание комплексных чисел
        /// </summary>
        public Complex Minus(Complex x2)
        {
            Complex x3 = new Complex();
            x3.re = re - x2.re;
            x3.im = im - x2.im;
            return x3;
        }

        /// <summary>
        /// Умножение комплексных чисел
        /// </summary>
        public Complex Multi(Complex x2)
        {
            Complex x3 = new Complex();
            x3.re = re * x2.re - im * x2.im;
            x3.im = im * x2.re + re * x2.im;
            return x3;
        }

        /// <summary>
        /// Переопределение метода конвертации в строку
        /// </summary>
        public override string ToString()
        {
            return string.Format("{0}+{1}i", re, im);
        }
    }
}
