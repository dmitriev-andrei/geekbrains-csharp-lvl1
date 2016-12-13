using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dmitriev_04_authorization
{
    class Program
    {
        /* Дмитриев Андрей
         * 
         * Реализовать метод проверки логина и пароля. 
         * На вход подается логин и пароль.
         * На выходе истина, если прошел авторизацию, и ложь, если не прошел.
         * Используя метод проверки логина и пароля, написать программу: 
         * пользователь вводит логин и пароль, программа пропускает его дальше или не пропускает.
         * С помощью цикла do while ограничить ввод пароля трема попытками.
         */
        static void Main(string[] args)
        {
            Console.WriteLine("Пожалуйста, авторизуйтесь. Логин по умолчанию - admin, пароль - pass.\n");

            string login, password;

            login = GetUserString("Введите логин: ");

            int tryCount = 1;
            // по заданию нужно ограничить тремя попытками только ввод пароля 
            do
            {                
                password = GetUserString("Введите пароль: ");               

                if (isAuthorizationSucced(login, password))
                { 
                    Console.WriteLine("Вы успешно авторизованы!");
                    break;
                }
                else
                  Console.WriteLine("Введен невереный логин или пароль. Попробуйте снова ..");

                tryCount++;
            } while (tryCount <= 3);

            if (tryCount > 3) Console.WriteLine("Превышено допустимое количество попыток ..");

            Console.WriteLine("\n\nДля выхода нажмите любую кнопку ..");
            Console.ReadKey();
        }

        /// <summary>
        /// Проверяет корректность введенного логина и пароля.       
        /// </summary>
        /// <param name="login">Регистронезависимый логин пользователя</param>
        /// <param name="password">Пароль пользователя. Строгое совпадение</param>
        /// <returns></returns>
        private static bool isAuthorizationSucced(string login, string password)
        {
            return login.ToUpper() == "ADMIN" && password == "pass";
        }

        /// <summary>
        /// Выводит сообщение пользователю и ожидает ввода строки.
        /// </summary>
        /// <param name="msg">Сообщение пользователю</param>
        /// <returns>Строка, введенная пользователем</returns>
        private static string GetUserString(string msg)
        {
            Console.Write(msg);
            return Console.ReadLine();
        }
    }
}
