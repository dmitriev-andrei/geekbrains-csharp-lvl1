using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dmitriev_01_trio_minimum
{
    class Program
    {
        /*
         * Дмитриев Андрей
         * 
         * Написать метод возвращающий минимальное из трех чисел         
         *
         */
        static void Main(string[] args)
        {
            Console.WriteLine("Вычисление минимального из трёх чисел.\n");

            int a = GetNumber("Введите первое число: ");  // 4
            int b = GetNumber("Введите второе число: ");  // 7
            int c = GetNumber("Введите третье число: ");  // 0

            Console.WriteLine("\nМинимальное из трех чисел равно: {0}", GetMinValue(a, b, c));

            Console.WriteLine("\n\nДля продолжения нажмите любую кнопку ..");
            Console.ReadKey();
        }

        /// <summary>
        /// Определение минимального значения среди трех целых чисел
        /// </summary>
        private static int GetMinValue(int a, int b, int c)
        {
            if (a < b && a < c)
                return a;
            else if (b < a && b < c)
                return b;
            else
                return c;
        }

        /// <summary>
        /// Выводит пользователю сообщения и ожидает ввода значения.
        /// </summary>
        /// <param name="msg">Текст сообщения пользователю</param>
        /// <returns>Введенное пользователем значение</returns>
        private static int GetNumber(string msg)
        {
            Console.Write(msg);
            return Convert.ToInt32(Console.ReadLine());
        }
    }
}
