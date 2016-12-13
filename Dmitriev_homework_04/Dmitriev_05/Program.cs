using System;

namespace Dmitriev_05
{
    class Program
    {
        /* Дмитриев Андрей - задание #5
         * 
         * Реализовать класс "Удовитель". Класс хранит в себе поле current - текущее значение, finish - число, которого нужно достичь.
         * Конструктор, в котором задается конечное число. Методы:
         * - увеличить число на 1; - увеличить число в два раза; - сброс текущего до 1
         * Свойство Current, которое возвращает текущее значение, свойство Finish, которое возвращает конечное значение.
         */
        static void Main(string[] args)
        {
            Console.WriteLine("Игра \"Удвоитель\"");

            Doubler doubler = new Doubler(50);

            Console.WriteLine("Задача - дойти от 1 до загаданного числа: {0}", doubler.Finish);
            Console.WriteLine("Возможные действия: ");
            Console.WriteLine("\t 1 - увеличить текущее значение на единицу");
            Console.WriteLine("\t 2 - удвоить текущее значение");
            Console.WriteLine("\t 0 - сбросить текущее значение до единицы");
            Console.WriteLine("\t q - выйти из игры\n");

            int stepsCount = 0;

            string userInput = string.Empty;
            do
            {
                Console.Write("Ваше действие: ");
                userInput = Console.ReadLine().ToUpper();
                switch (userInput)
                {
                    case "1":
                        doubler.PlusOne();
                        break;
                    case "2":
                        doubler.Doubling();
                        break;
                    case "0":
                        doubler.Reset();                        
                        break;
                    default:
                        // некорректный ввод не увеличивает количество попыток
                        stepsCount--;
                        break;                    
                }
                stepsCount++;
                Console.WriteLine("Текущее значение: {0}, конечное значение {1}", doubler.Current, doubler.Finish);
                
            } while ((doubler.Current != doubler.Finish) && (userInput != "Q"));

            if (doubler.Current == doubler.Finish)
            {
                Console.WriteLine("\nЧтобы добиться успеха вам потребовалось {0} шагов", stepsCount);
            }
            else
            {
                Console.WriteLine("\nВы закончили игру после {0} шага. ", stepsCount);
            }

            Console.WriteLine("\n\nДля выхода нажмите любую клавишу ..");
            Console.ReadKey();
        }
    }
}
