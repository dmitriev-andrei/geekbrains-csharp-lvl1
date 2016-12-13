using System;

namespace Dmitriev_03_fractions
{
    class Program
    {
        /* Дмитриев Андрей - задание 3
         * 
         * Описать класс дробей - рациональных чисел, являющихся отношением двух целых чисел.
         * Предусмотреть методы сложения, вычитания, умножения и деления дробей.
         * Написать программу, демонстрирующую все разработанные элементы класса.
         */
        static void Main(string[] args)
        {
            Fraction x1 = new Fraction(1, 2);
            Fraction x2 = new Fraction(2, 3);

            Console.WriteLine("Даны две дроби x1 = ({0}), x2 = ({1})", x1.ToString(), x2.ToString());
                        
            try
            {
                Console.WriteLine("x1 + x2 = {0}", x1.Plus(x2));
                Console.WriteLine("x1 - x2 = {0}", x1.Minus(x2));
                Console.WriteLine("x1 * x2 = {0}", x1.Multi(x2));
                Console.WriteLine("x1 / x2 = {0}", x1.Div(x2));
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ошибка: {0}", ex.Message);
            }

            Console.WriteLine("\n\nДля выхода нажмите любую кнопку ..");
            Console.ReadKey();
        }
    }
}
