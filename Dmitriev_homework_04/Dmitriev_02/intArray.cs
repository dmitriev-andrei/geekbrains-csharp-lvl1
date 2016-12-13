using System;
using System.IO;

namespace Dmitriev_02
{
    internal class IntArray
    {
        int[] arr;

        /// <summary>
        /// Свойство, возвращающее сумму элементов массива
        /// </summary>
        public int Sum {
            get {
                int sum = 0;
                foreach (var item in arr)
                    sum += item;
                return sum;
            }
        }

        /// <summary>
        /// Свойство, возвращающее количество максимальных элементов массива
        /// </summary>
        public int MaxCount {
            get {
                int maxCount = 1;
                int max = arr[0];                

                for (int i = 1; i < arr.Length; i++)
                {
                    if (arr[i] > max)
                    {
                        max = arr[i];
                        maxCount = 1;
                    }
                    else if (arr[i] == max)
                    {
                        maxCount++;
                    }
                }

                return maxCount;
            }
        }

        /// <summary>
        /// Конструктор по умолчанию
        /// </summary>
        public IntArray()
        {

        }

        /// <summary>
        /// Создает массив целых чисел заданной размерности, заполненный элементами
        /// от начального значения с заданным шагом.
        /// </summary>
        /// <param name="length">Длина массива</param>
        /// <param name="firstValue">Значение первого элемента массива</param>
        /// <param name="step">Шаг на который будут отличаться значения элементов</param>
        public IntArray(int length, int firstValue, int step)
        {
            arr = new int[length];

            arr[0] = firstValue;
            for (int i = 1; i < arr.Length; i++)
            {
                try
                {
                    arr[i] = checked(arr[i - 1] + step);
                }
                catch (OverflowException ex)
                {
                    //вывод на консоль не очень выглядит, лучше писать в файл лога
                    //Console.WriteLine("Ошибка: {0}", ex.Message);                    
                    arr[i] = arr[i - 1] + step > 0 ? int.MaxValue : int.MinValue;
                }
            }
        }

        public void SaveToFile(string filePath)
        {
            StreamWriter sw = new StreamWriter(filePath);

            foreach (var item in arr)
            {
                sw.WriteLine("{0}", item);
            }

            sw.Close();
        }

        /// <summary>
        /// Загрузка в массив данных из текстового файла
        /// </summary>
        public void LoadFromFile(string filePath)
        {
            InitArrayFromFile(filePath);
        }

        /// <summary>
        /// Реализация загрузки данных из текстового файла в массив
        /// </summary>
        /// <param name="filePath"></param>
        private void InitArrayFromFile(string filePath)
        {
            try
            {
                int arrLength = File.ReadAllLines(filePath).Length;
                arr = new int[arrLength];

                StreamReader sr = new StreamReader(filePath);

                for (int i = 0; i < arrLength; i++)
                {
                    int.TryParse(sr.ReadLine(), out arr[i]);
                }

                sr.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ошибка: {0}", ex.Message);
                arr = new int[10];
            }
        }

        /// <summary>
        /// Создание архива по данным из файла
        /// </summary>
        /// <param name="filePath">Путь к файлу с данными</param>
        public IntArray(string filePath)
        {
            InitArrayFromFile(filePath);
        }

        /// <summary>
        /// Меняет на противоположный знак каждого элемента массива
        /// </summary>
        public void Inverse()
        {
            for (int i = 0; i < arr.Length; i++)
            {
                // для минимального значения типа int нельзя просто сменить знак
                // решаем, что в таком случае приравниваем нужно взять int.MaxValue
                if (arr[i] != int.MinValue)
                {
                    arr[i] = arr[i] > 0 ? -arr[i] : Math.Abs(arr[i]);
                }
                else
                {
                    arr[i] = int.MaxValue;
                }
            }
        }

        /// <summary>
        /// Умножает все элементы массива на заданное число
        /// </summary>
        public void Multi(int num)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                try
                {
                    arr[i] = checked(arr[i] * num);
                }                   
                catch (OverflowException ex)
                {
                    //вывод на консоль не очень выглядит, лучше писать в файл лога
                    //Console.WriteLine("Ошибка: {0}", ex.Message);
                    arr[i] = arr[i] > 0 ? int.MaxValue : int.MinValue;
                }
            }
        }

        /// <summary>
        /// Выводит значения элементов массива в одну строку, через пробел
        /// </summary>
        public void Print()
        {
            foreach (var item in arr)
            {
                Console.Write("{0} ", item);
            }
            Console.WriteLine();
        }
    }
}