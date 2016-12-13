using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dmitriev_02_even_positive_sum
{
    class Program
    {
        /* Дмитриев Андрей - задание 2
         * 
         * а) С клавиатуры вводятся числа, пока не будет введен 0 (каждое число в новой строке)
         * Требуется подсчитать сумму всех нечетных положительных чисел. Сами числа и сумму вывести на экран. 
         * Использовать TryParse;
         * 
         * б) Добавить обработку исключительных ситуаций на то, что могут быть введены не корректные данные.
         * При возникновении ошибки вывести сообщение
         */
        static void Main(string[] args)
        {
            Console.WriteLine("Вычисление суммы положительных нечетных чисел (0 - прекратить ввод).\n");
            int x;
            Boolean stayInLoop = true;            
            List<int> numsList = new List<int>();

            do
            {
                Console.Write("Введите число: ");

                #region а) реализация через TryParse
                //if (Int32.TryParse(Console.ReadLine(), out x))
                //{
                //    stayInLoop = x != 0;

                //    if (IsPositive(x) && IsOdd(x)) numsList.Add(x);
                //}
                //else
                //    Console.WriteLine("Ошибка: Ожидается целоче число в диапозоне от {0} до {1}", Int32.MinValue, Int32.MaxValue);
                #endregion

                #region б) реализация через обработку исключений
                try
                {
                    x = Int32.Parse(Console.ReadLine());

                    stayInLoop = x != 0;

                    if (IsPositive(x) && IsOdd(x)) numsList.Add(x);
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Ошибка: '{0}'", ex.Message);
                }
                #endregion


            } while (stayInLoop);

            Console.Write("\nБыли отобраны числа: ");            
            foreach (var num in numsList)
            {
                Console.Write("{0} ", num);
            } 
            Console.WriteLine("\nСумма положительных нечетных чисел: {0}", GetIntListSum(numsList));

            Console.WriteLine("\n\nДля выхода нажмите любую кнопку ..");
            Console.ReadKey();
        }

        /// <summary>
        /// Вычисляет сумму значений списка целых чисел
        /// </summary>
        private static int GetIntListSum(List<int> numsList)
        {
            int sum = 0;
            foreach (var num in numsList)
            {
                sum += num;
            }
            return sum;
        }

        /// <summary>
        /// Проверяет является ли целое число нечетным
        /// </summary>
        private static bool IsOdd(int x)
        {
            return x % 2 != 0;
        }

        /// <summary>
        /// Проверяет является ли число целое число положительным
        /// </summary>
        private static bool IsPositive(int x)
        {
            return x > 0;
        }
    }
}
