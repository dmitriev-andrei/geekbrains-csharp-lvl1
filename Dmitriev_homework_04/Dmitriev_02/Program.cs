using System;

namespace Dmitriev_02
{
    class Program
    {
        /* Дмитриев Андрей - задание #2
         * 
         * а) Дописать класс для работы с одномерным массивом.
         * Реализовать конструктор, создающий массив заданной размерности и заплняющий массив числами от начального значения с заданным шагом.
         * Создать свойство Sum, которое возвращает сумму элементов массива, метод Inverse, меняющий знаки у всех элементов массива.
         * Метод Multi, умножающий каждый элемент массива на определенное число, свойство MaxCount, возвращающее количество максимальных элементов.
         * В Main продемонстрировать работу класса.
         * 
         * б) Добавить конструктор и методы, которые загружают данные из файла и записывают данные в файл.
         */
        static void Main(string[] args)
        {
            #region а) первая часть задания
            int arrayLength = 10; 
            int arrayFirstValue = -14000;
            int arrayValuesStep = 5000;

            IntArray arr = new IntArray(arrayLength, arrayFirstValue, arrayValuesStep);

            Console.WriteLine("Дан массив из {0} элементов с шагом значений {1}:", arrayLength, arrayValuesStep);
            arr.Print();

            Console.WriteLine("\nСумма элементов массива: {0}", arr.Sum);

            Console.WriteLine("\nСменим знак у элементов:");
            arr.Inverse();
            arr.Print();

            int multiNumber = 123456;
            Console.WriteLine("\nУмножим все элементы массива на {0}: ", multiNumber);
            arr.Multi(multiNumber);
            arr.Print();

            Console.WriteLine("\nСнова сменим знак у элементов:");
            arr.Inverse();
            arr.Print();

            Console.WriteLine("\nКоличество максимальных элементов: {0}", arr.MaxCount);
            #endregion

            #region б) создание архива из файла и запись архива в файл
            Console.WriteLine("\nМассив созданный по значениям в текстовом файле: ");
            IntArray arr2 = new IntArray("ArrayInputData.txt");
            arr2.Print();

            Console.WriteLine("\nМеняем знак у элементов и сохраняем массив в новый файл ArrayOutputData.txt");
            arr2.Inverse();
            arr2.SaveToFile("ArrayOutputData.txt");


            Console.WriteLine("\nСоздаем новый массив и загружаем в неего данные из файла ArrayOutputData.txt");
            IntArray arr3 = new IntArray();
            arr3.LoadFromFile("ArrayOutputData.txt");
            arr3.Print();
            #endregion

            Console.WriteLine("\n\nДля выхода нажмите любую клавишу ..");
            Console.ReadKey();
        }
    }
}
