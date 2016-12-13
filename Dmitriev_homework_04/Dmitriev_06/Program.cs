using System;
using System.IO;

namespace Dmitriev_06
{
    class Program
    {
        /* Дмитриев Андрей - задание #6 
         * 
         * Написать игру "Верю. Не верю". В файле хранятся некоторые данные и правда это или нет.
         * Компьютер загружает данные, случайным образом выбирает 5 вопросов и задает их игроку.
         * Игрок пытается ответить правда или нет, то что ему загадали и набирает баллы.
         */
        static void Main(string[] args)
        {
            Console.WriteLine("Игра \"Верю\" - \"Не верю\"\n");

            int correctAnswers = 0;
            int questionsLimit = 5;

            string[] questionsBase = File.ReadAllLines("questions.csv");

            if (questionsBase.Length < questionsLimit) questionsLimit = questionsBase.Length;
                
            Random rnd = new Random();

            for (int i = 0; i < questionsLimit; i++)
            {
                string[] question = questionsBase[rnd.Next(0, questionsBase.Length)].Split(';');
                Console.WriteLine(question[0]);

                Console.Write("(y - Верю, n - Не верю): ");
                string userAnswer = Console.ReadLine().ToUpper();

                if ((userAnswer == "Y" && bool.Parse(question[1])) || (userAnswer == "N" && !bool.Parse(question[1])))
                {
                    correctAnswers++;
                }
            }
            Console.WriteLine("Набрано баллов: {0}", correctAnswers);

            Console.WriteLine("\n\nДля выхода нажмите любую клавишу ..");
            Console.ReadKey();
        }
    }
}
