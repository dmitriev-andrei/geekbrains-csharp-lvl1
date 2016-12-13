using System;

namespace Dmitriev_01_struct_and_class
{
    class Program
    {
        /* Дмитриев Андрей - задание 1
         * 
         * а) Дописать структуру ComplexNum, добавив метод вычитания комплексных чисел.
         * Продемонстрировать работу структуры.
         * 
         * б) Дописать класс Complex, добавив методы вычитания и произведения чисел.
         * Проверить работу класса.
         */
        static void Main(string[] args)
        {
            #region а) работа со структурой данных ComplexNum
            ComplexNum a;
            a.re = 4;
            a.im = 5;
            ComplexNum b;
            b.re = 3;
            b.im = 2;
            Console.WriteLine("а) СТРУКТУРА: Даны два комплексных числа а = ({0}) и b = ({1})", a.ToString(), b.ToString());

            Console.WriteLine("a + b = {0}", a.Plus(b));
            Console.WriteLine("a - b = {0}", a.Minus(b));
            Console.WriteLine("a * b = {0}", a.Multi(b));
            Console.WriteLine();
            #endregion

            #region b) работа с классом Complex
            Complex x1 = new Complex(4, 5);
            Complex x2 = new Complex(3, 2);
            Console.WriteLine("b) КЛАСС: Даны два комплексных числа x1 = ({0}), x2 = ({1})", x1.ToString(), x2.ToString());

            Console.WriteLine("x1 + x2 = {0}", x1.Plus(x2));
            Console.WriteLine("x1 - x2 = {0}", x1.Minus(x2));
            Console.WriteLine("x1 * x2 = {0}", x1.Multi(x2));
            #endregion

            Console.WriteLine("\n\nДля выхода нажмите любую кнопку ..");
            Console.ReadKey();
        }
    }
}
