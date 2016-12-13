using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dmitriev_06_good_numbers_sum
{
    class Program
    {
        /* Дмитриев Андрей
         * 
         * *Написать программу подсчета "Хороших" чисел в диапозоне от 1 до 1 000 000.
         * Хорошим называется число, которое делится на сумму своих цифр.
         * Реализовать подсчет времени выполнения программы, используя структуру DateTime.
         */ 
        static void Main(string[] args)
        {
            int fromNumber = 1;
            int toNumber = 1000000;
            DateTime dtStart = DateTime.Now;
            Console.WriteLine("Количество чисел в диапозоне от {0} до {1}, делящихся на сумму своих цифр равно: {2}", fromNumber, toNumber, GetGoodNumbersCount(fromNumber, toNumber));

            TimeSpan runingTime = DateTime.Now - dtStart;

            Console.WriteLine("Время вычисления {0} сек, {1} мс ", runingTime.Seconds, runingTime.Milliseconds);

            Console.WriteLine("\n\nДля выхода нажмите любую кнопкку ..");
            Console.ReadKey();
        }

        /// <summary>
        /// Вычисляет количество "хороших" чисел в заданном диапозоне.
        /// </summary>
        /// <param name="fromNumber">Начало диапозона</param>
        /// <param name="toNumber">Конец диапозона</param>
        private static int GetGoodNumbersCount(int fromNumber, int toNumber)
        {
            int goodNumbersCount = 0;
            for (int i = fromNumber; i <= toNumber; i++)
            {
                if (isGood(i))
                    goodNumbersCount++;
            }

            return goodNumbersCount;
        }

        /// <summary>
        /// Проверяет делится ли число на сумму своих цифр.
        /// </summary>
        private static bool isGood(int number)
        {
            if (number % GetNumberSum(number) == 0)
                return true;
            else
                return false;
        }

        /// <summary>
        /// Вычисляет сумму цифр числа.
        /// Суммируем остаток от деления на 10, затем отбрасываем остаток и снова делим на 10.
        /// </summary>
        private static int GetNumberSum(int number)
        {
            int sum = 0;

            do
            {
                sum += number % 10;
                number = (int)Math.Truncate((double)number / 10);                
            } while (number > 0);

            return sum;
        }
    }
}
