using System;

namespace Dmitriev_02
{
    class Program
    {
        /* Дмитриев Андрей - задание #2
         * 
         * Разработать методы для решения следующих задач. Дано сообщение:
         * а) Вывести только те слова сообщения, которые содержат не более чем n букв;
         * б) Удалить из сообщения все слова, которые заканчиваются на заданный символ;
         * в) Найти самое длинное слово сообщения;
         * г) Найти все самые длинные слова сообщения.
         * (Постарайтесь разработать класс MyString)
         */
        static void Main(string[] args)
        {
            string dataStr = "На вход программе подаются сведения о сдаче экзаменов учениками 9-х классов некоторой средней школы.";
            Console.WriteLine("Дана фраза: {0}", dataStr);

            MyString ms = new MyString(dataStr);

            int n = 6;
            char c = 'я';

            Console.WriteLine("\nСлова, содержащие больше {0} букв:\n{1}", n, ms.GetWordsBiggerThat(n));
            Console.WriteLine("\nСтрока без слов, заканчивающихся на '{0}':\n{1}", c, ms.GetWordsNotEndTo(c));
            Console.WriteLine("\nСамое длинное слово: {0}", ms.GetLongestWord()); 
            Console.WriteLine("\nВсе самые длинные слова:\n{0}", ms.GetAllLongestWords());

            Console.WriteLine("\n\nДля выхода нажмите любую клавишу ..");
            Console.ReadKey();
        }
    }
}
