using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dmitriev_07_recursion
{
    class Program
    {
        /* Дмитриев Андрей
         * 
         * а) Разработать рекурсивный метод, который выводит на экран числа от a до b;
         * б) *Разработать рекурсивный метод, который считает сумму чисел от a до b.
         */
        static void Main(string[] args)
        {
            Console.WriteLine("Вывод чисел в итервале от a до b.\n");

            int a = GetUserValue("Введите число a: ");
            int b = GetUserValue("Введите число b: ");
            Console.WriteLine();

            // вариант а)
            PrintRange(a, b);

            // вариант б)
            Console.WriteLine("\nСумма чисел в дипозоне от {0} до {1} равна {2}", a, b, GetRangeSum(a, b));            

            Console.WriteLine("\n\nДля выхода нажмите любую кнопку ..");
            Console.ReadKey();
        }

        /// <summary>
        /// Возвращает сумму чисел из диапозона от a до b.
        /// </summary>
        /// <param name="a">Начало диапозона</param>
        /// <param name="b">Конец диапозона</param>
        private static int GetRangeSum(int a, int b)
        {
            if (a < b)
            {
                return a += GetRangeSum(++a, b);
            }
            else if (a == b)
            {
                return b;
            }            
            else
            {
                return a += GetRangeSum(--a, b);
            }
        }

        /// <summary>
        /// Выводит на экан числа в диапозоне от a до b.
        /// </summary>
        /// <param name="a">Начало диапозона</param>
        /// <param name="b">Конец диапозона</param>
        private static void PrintRange(int a, int b)
        {            
            if (a < b)
            {
                Console.WriteLine("{0}", a);
                PrintRange(++a, b);
            }
            else if (a == b)
            {
                Console.WriteLine("{0}", b);
            }
            else
            {
                Console.WriteLine("{0}", a);
                PrintRange(--a, b);
            }
        }

        /// <summary>
        /// Выводит сообщение пользователю и ожидает ввода значения.
        /// </summary>
        /// <param name="msg">Текст сообщения пользователю</param>
        private static int GetUserValue(string msg)
        {
            Console.Write(msg);
            return Convert.ToInt32(Console.ReadLine());
        }
    }
}
