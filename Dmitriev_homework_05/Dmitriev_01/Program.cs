using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dmitriev_01
{
    class Program
    {
        /* Дмитриев Андрей - задание #1
         * 
         * Создать программу, которая будет проверять корректность ввода логина.
         * Корректным логином будет строка от 2-х до 10-ти символов, содержащая только буквы и цифры, и при этом цифра не может быть первой.
         * а) без использования регулярных выражений;
         * б) **с использованием регулярных выражений.
         */
        static void Main(string[] args)
        {
            Console.WriteLine("Требования к логину:\n\t- от 2-х до 10-ти символов;\n\t-содержит только буквы и цифры\n\t-не начинается с цифры.");

            while (true)
            {
                Console.Write("\nВведите логин (q - выход): ");
                string login = Console.ReadLine();

                if (login.Trim().ToLower() == "q") break;

                LoginChecker loginChecker = new LoginChecker(login);
                
                if (loginChecker.IsCorrect())
                    Console.WriteLine("{0}' соответствует требованиям!", login);
                else
                    Console.WriteLine("'{0}': {1}", login, loginChecker.ErrorDescr);

                loginChecker.UseRegEx = true;

                if (loginChecker.IsCorrect())
                    Console.WriteLine("{0}' соответствует требованиям!", login);
                else
                    Console.WriteLine("'{0}': {1}", login, loginChecker.ErrorDescr);
            }            
        }
    }
}
