using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dmitirev_03_sum_odd_numbers
{
    class Program
    {
        /* Дмитриев Андрей
         * 
         * С клавиатуры вводятся числа, пока не будет введен 0.
         * Подсчитать сумму всех нечетных положительных чисел.
         */
        static void Main(string[] args)
        {
            Console.WriteLine("Подсчет суммы нечетных положительных чисел.\nВведите 0, чтобы прекратить ввод чисел.\n");

            int sum = 0;

            while (true)
            {
                Console.Write("Введите число: ");
                int x = Convert.ToInt32(Console.ReadLine());

                // Если введен ноль - выходим из цикла
                if (x == 0) break;

                // Если число нечетное и положительное - прибавляем его к сумме
                if (isOddAndPositive(x))
                    sum += x;
            }

            Console.WriteLine("Сумма введенных нечетных положительных чисел равна: {0}", sum);

            Console.WriteLine("\n\nДля выхода нажмите любую кнопку ..");
            Console.ReadKey();
        }

        /// <summary>
        /// Определяет является ли число положительным и нечетным.
        /// </summary>
        private static bool isOddAndPositive(int x)
        {
            return (x % 2 != 0 && x > 0);
        }
    }
}
