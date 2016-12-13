using System;
using System.IO;

namespace Dmitriev_03
{
    class Program
    {
        /* Дмитриев Андрей - задание #4
         * 
         * Решить задачу с логинами из предыдущего урока, только логины и пароли считать и файла в массив
         * 
         * Реализовать метод проверки логина и пароля. На вход подается логин и пароль. 
         * На выходе истина, если прошел авторизацию, и ложь, если не прошел.
         * Используя метод проверки логина и пароля, написать программу: пользователь вводит логин и пароль, программа пропускает его дальше или не пропускает. 
         */
        static void Main(string[] args)
        {
            Console.WriteLine("Пожалуйста, авторизуйтесь. Логин по умолчанию - admin, пароль - pass.\n");

            string login, password;

            login = GetUserString("Введите логин: ");

            int tryCount = 1;

            do
            {
                password = GetUserString("Введите пароль: ");

                if (isAuthorizationSucced(login, password))
                {
                    Console.WriteLine("Вы успешно авторизованы!");
                    break;
                }
                else
                    Console.WriteLine("Ввведен неверный логин или пароль. Попробуйте снова ..");

                tryCount++;
            } while (tryCount < 4);

            if (tryCount > 3) Console.WriteLine("Превышено допустимое количество попыток ..");

            Console.WriteLine("\n\nДля выхода нажмите любую клавишу ..");
            Console.ReadKey();
        }

        /// <summary>
        /// Проверяет корректность введенного логина и пароля
        /// </summary>
        /// <param name="login">Регистронезависимый логин пользователя</param>
        /// <param name="password">Пароль пользователя. Строгое совпадение</param>
        /// <returns></returns>
        private static bool isAuthorizationSucced(string login, string password)
        {
            bool loginSucced = false;
            try
            {
                string[] loginsData = File.ReadAllLines("base.txt");

                foreach (var item in loginsData)
                {
                    if (item.Split(' ')[0].ToUpper() == login.ToUpper() && item.Split(' ')[1] == password)
                    {
                        loginSucced = true;
                        break;
                    }
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine("{0}", ex.Message);
            }
            return loginSucced;
        }

        /// <summary>
        /// Выводит сообщение пользователю и ожидает ввода строки
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
