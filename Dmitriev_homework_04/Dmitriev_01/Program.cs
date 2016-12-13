using System;


namespace Dmitriev_01
{
    class Program
    {
        /* Лмитриев Андрей - задание #1
         * 
         * Дан целочисленный массив из 20 элементов.
         * Элементы массива могут принимать целые значения от - 10 000 до 10 000 включительно.
         * Написать программу, позволяющую найти и вывести количество пар элементов массива.         * 
         */
        static void Main(string[] args)
        {
            int[] arr = new int[20];

            Console.WriteLine("Дан массив целых чисел:");

            FillArrayRandomValues(arr, -10000, 10000);
            PrintArrayInLine(arr);

            Console.WriteLine("\nКоличество пар, в которых хоть один элемент делится на три: {0}", GetPairsCount(arr));

            Console.WriteLine("\n\nДля выхода нажмите любую кнопку ..");
            Console.ReadKey();
        }

        /// <summary>
        /// Выводит на экран элементы массива
        /// </summary>
        private static void PrintArrayInLine(int[] arr)
        {
            ConsoleColor defaultColor = Console.ForegroundColor;

            foreach (var item in arr)
            {
                // для удобства проверки подсвечиваем элементы делящиеся на три
                if (IsDividedByThree(item))
                    Console.ForegroundColor = ConsoleColor.Green;
                else
                    Console.ForegroundColor = defaultColor;

                Console.Write("{0} ", item);
            }

            Console.ForegroundColor = defaultColor;
            Console.Write("\n");            
        }

        /// <summary>
        /// Вычисляет количество пар элементов массива, соответствующих условию
        /// </summary>
        private static int GetPairsCount(int[] arr)
        {
            int pairsCount = 0;
            
            for (int i = 1; i < arr.Length; i++)
            {
                if (IsDividedByThree(arr[i-1]) || IsDividedByThree(arr[i]))
                {
                    pairsCount++;
                }
            }

            return pairsCount;
        }

        /// <summary>
        /// Определяет делитс ли число на три.
        /// </summary>
        private static bool IsDividedByThree(int v)
        {
            return v % 3 == 0;
        }

        /// <summary>
        /// Заполняет массив случайными целыми числами в диапозоне от minValue до maxValue.
        /// </summary>
        /// <param name="arr">Массив, который будет заполнен случайными числами</param>
        /// <param name="minValue">Минимальное значение диапозона случайных чисел</param>
        /// <param name="maxValue">Максимальное значение диапозона случайных чисел</param>
        private static void FillArrayRandomValues(int[] arr, int minValue, int maxValue)
        {
            Random rnd = new Random();
            for (int i = 0; i < arr.Length; i++)          
                arr[i] = rnd.Next(minValue, maxValue+1); 
        }
    }
}
