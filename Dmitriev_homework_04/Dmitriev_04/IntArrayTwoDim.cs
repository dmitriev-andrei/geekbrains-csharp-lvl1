using System;
using System.IO;

namespace Dmitriev_04
{
    class IntArrayTwoDim
    {
        int[,] a;

        /// <summary>
        /// Минимальный элемент массива
        /// </summary>
        public int Min
        {
            get
            {
                int min = int.MaxValue;
                for (int i = 0; i < a.GetLength(0); i++)
                {
                    for (int j = 0; j < a.GetLength(1); j++)
                    {
                        if (a[i, j] < min) min = a[i, j];
                    }
                }
                return min;
            }
        }

        /// <summary>
        /// Максимальный элемент массива
        /// </summary>
        public int Max
        {
            get
            {
                int max = int.MinValue;
                for (int i = 0; i < a.GetLength(0); i++)
                {
                    for (int j = 0; j < a.GetLength(1); j++)
                    {
                        if (a[i,j] > max) max = a[i,j];
                    }
                }
                return max;
            }
        }

        public IntArrayTwoDim()
        {
            a = new int[10, 10];            
        }

        /// <summary>
        /// Заполняет массив случайными целыми числами в заданном диапозоне
        /// </summary>
        public IntArrayTwoDim(int n, int min, int max)
        {
            Random rnd = new Random();

            a = new int[n, n];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    a[i, j] = rnd.Next(min, max);
                }
            }
        }

        /// <summary>
        /// Создание массива на основе текстового файла.
        /// Подразумеваем, что количество строк и столбцов массива одинаковы.
        /// </summary>
        public IntArrayTwoDim(string filePath)
        {
            LoadFromFile(filePath);
        }

        /// <summary>
        /// Реализация загрузки данных массива из текстового файла
        /// </summary>
        /// <param name="filePath"></param>
        private void LoadFromFile(string filePath)
        {
            string[] arrayLines = File.ReadAllLines(filePath);

            int iLength = arrayLines[0].Split(' ').Length;
            int jLength = arrayLines.Length;

            a = new int[iLength, jLength];

            for (int i = 0; i < iLength; i++)
            {
                for (int j = 0; j < jLength; j++)
                {
                    a[i, j] = int.Parse(arrayLines[i].Split(' ')[j]);
                }
            }
        }

        /// <summary>
        /// Загружает данные массива из файла
        /// </summary
        internal void Load(string filePath)
        {
            LoadFromFile(filePath);
        }

        /// <summary>
        /// Возвращает сумму всех элементов массива
        /// </summary>
        public int GetSum()
        {
            int sum = 0;
            foreach (var item in a)
            {
                sum += item;
            }
            return sum;
        }

        /// <summary>
        /// Возвращает  сумму элементов массива, больших заданного числа
        /// </summary>
        public int GetSumAbove(int n)
        {
            int sum = 0;
            foreach (var item in a)
            {
                if (item > n) sum += item;
            }
            return sum;
        }

        /// <summary>
        /// Получеие индексов максимального элемента массива
        /// </summary>
        public void GetMaxIndex(out int maxI, out int maxJ)
        {
            maxI = 0;
            maxJ = 0;
            int max = a[maxI, maxJ];
            for (int i = 1; i < a.GetLength(0); i++)
            {
                for (int j = 1; j < a.GetLength(1); j++)
                {
                    if (max < a[i, j])
                    {
                        max = a[i, j];
                        maxI = i;
                        maxJ = j;
                    }
                }
            }
        }

        /// <summary>
        /// Преобразование массива в строку
        /// </summary>
        public override string ToString()
        {
            string s = string.Empty;
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    if (j + 1 < a.GetLength(1))
                        s += string.Format("{0} ", a[i, j]);
                    else
                        s += string.Format("{0}\n", a[i, j]);
                }
            }
            return s;
        }

        /// <summary>
        /// Сохранение в массива файл
        /// </summary>
        public void SaveToFile(string filePaht)
        {
            StreamWriter sw = new StreamWriter(filePaht);
            try
            {
                for (int i = 0; i < a.GetLength(0); i++)
                {
                    string s = string.Empty;
                    for (int j = 0; j < a.GetLength(1); j++)
                    {
                        if (j + 1 < a.GetLength(1))
                            s += string.Format("{0} ", a[i, j]);
                        else
                            s += string.Format("{0}", a[i, j]);
                    }
                    sw.WriteLine(s);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ошибка: {0}", ex.Message);
            }
            sw.Close();
        }
    }
}
