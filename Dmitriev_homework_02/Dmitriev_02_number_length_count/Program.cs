using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dmitriev_02_number_length_count
{
    class Program
    {
        /* Дмитриев Андрей
         * 
         * Написать метод подсчета количества цифр числа         
         * 
         */
        static void Main(string[] args)
        {
            Console.WriteLine("Подсчет количества цифр в числе.\n");

            Console.Write("Введите число: ");
            int x = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("В числе '{0}' количество цифр равно: {1}", x, GetNumberLength(x));

            Console.WriteLine("\n\nДля выхода нажмите любую кнопку ..");
            Console.ReadKey();
        }

        /// <summary>
        /// Считает количество цифр в числе.
        /// </summary>
        private static int GetNumberLength(int x)
        {
            int numberLength = 0;

            do
            {
                x = x / 10;
                numberLength++;
            } while (x > 0);

            return numberLength;
        }
    }
}
