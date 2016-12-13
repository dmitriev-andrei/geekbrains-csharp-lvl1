using System;

namespace Dmitriev_04
{
    class Program
    {
        /* Дмитриев Андрей - задание #4
         * 
         * а) Реализовать класс для работы с двумерным массивом.
         * Реализовать конструктор, заполняющий массив случайными числами.
         * Создать методы, которые возвращают сумму всех элементов массива, 
         * сумму всех элементов массива больше заданного значения.
         * Свойство, возвращающее минимальный элемент массива, 
         * свойство, возвращающее максимальный элемент массива.
         * Метод, возвращающий номер максимального элемента массива (через параметры, используя модификатор ref или  out)
         * 
         * б) Добавить конструктор и методы, которые загружают данные из файла и записывают данные в файл.
         */
        static void Main(string[] args)
        {
            IntArrayTwoDim arr1 = new IntArrayTwoDim(5, 0, 10);
            Console.WriteLine("Дан массив случайных чисел:\n{0}", arr1.ToString());
            int maxI, maxJ;
            arr1.GetMaxIndex(out maxI, out maxJ);
            Console.WriteLine("Максимальное знаачение: {0}, индекс первого элемента [{1}, {2}]", arr1.Max, maxI, maxJ);
            Console.WriteLine("Минимальное знаачение: {0}", arr1.Min);
            Console.WriteLine("Сумма всех элементов: {0}", arr1.GetSum());
            Console.WriteLine("Сумма элементов, чьи значения больше пяти: {0}", arr1.GetSumAbove(5));

            #region б) Сохранение массива в файл и загрузка массива из файла
            string filePath = "arrayData.txt";
            Console.WriteLine("\nСохраняем массив в файл \"{0}\"", filePath);
            arr1.SaveToFile(filePath);
            
            IntArrayTwoDim arr2 = new IntArrayTwoDim(filePath);
            Console.WriteLine("\n(Используем конструктор)Читаем массив из файла:\n{0}", arr2.ToString());

            IntArrayTwoDim arr3 = new IntArrayTwoDim();
            arr3.Load(filePath);
            Console.WriteLine("\n(Используем метод)Читаем массив из файла:\n{0}", arr3.ToString());
            #endregion

            Console.WriteLine("\n\nДля выхода нажмите любую клавишу ..");
            Console.ReadKey();
        }
    }
}
