using System;
using System.Collections.Generic;

namespace Dmitriev_03
{
    class Program
    {
        /* Дмитриев Андрей - задание #3
         * 
         * *Для двух строк написать метод, определяющий, является ли одна строка перестановкой другой.
         * Регистр можно не учитывать.
         * а) с использованием методов C#;
         * б) *разработав собственный алгоритм
         * 
         * Например: badc является перестановкой abcd
         */
        static void Main(string[] args)
        {
            string str1 = "rdlolohwel";
            string str2 = "hellowardl";
            string str3 = "helloworla";

            // а) решение с использованием встроенных методов
            Console.WriteLine("Является ли строка '{0}' перестановкой '{1}'? {2}", str1, str3, IsSameButShifted(str1, str3) ? "Да": "Нет");
            Console.WriteLine("Является ли строка '{0}' перестановкой '{1}'? {2}", str2, str3, IsSameButShifted(str2, str3) ? "Да" : "Нет");
            Console.WriteLine();

            // б) собственный алгоритм
            Console.WriteLine("Является ли строка '{0}' перестановкой '{1}'? {2}", str1, str3, IsSameButShifted2(str1, str3) ? "Да" : "Нет");
            Console.WriteLine("Является ли строка '{0}' перестановкой '{1}'? {2}", str2, str3, IsSameButShifted2(str2, str3) ? "Да" : "Нет");

            Console.WriteLine("\n\nДля выхода нажмите любую клавишу ..");
            Console.ReadKey();
        }

        /// <summary>
        /// Собственная реализация подсчета количества уникальных символов в каждой строке, формирование словарей <символ><частота_использования> 
        /// и дальнейшее сравнение получившихся словарей.
        /// </summary>
        private static bool IsSameButShifted2(string str1, string str2)
        {
            if (str1.Length != str2.Length)
                return false;

            if (str1.Equals(str2))
                return true;

            Dictionary<char, int> dict1 = new Dictionary<char, int>();
            Dictionary<char, int> dict2 = new Dictionary<char, int>();

            for (int i = 0; i < str1.Length; i++)
            {
                if (dict1.ContainsKey(str1[i]))                
                    dict1[str1[i]]++;
                else
                    dict1.Add(str1[i], 1);
            }

            for (int i = 0; i < str2.Length; i++)
            {
                if (dict2.ContainsKey(str2[i]))
                    dict2[str2[i]]++;
                else
                    dict2.Add(str2[i], 1);
            }

            foreach (var item in dict2)
            {
                if (!dict1.ContainsKey(item.Key))
                    return false;
                else if (dict1[item.Key] != item.Value)
                    return false;
            }

            return true;
        }

        /// <summary>
        /// Метод, определяющий является ли одна строка перестановкой другой
        /// </summary>
        private static bool IsSameButShifted(string str1, string str2)
        {
            if (str1.Length != str2.Length)
                return false;

            if (str1.Equals(str2))
                return true;

            char[] charray1 = str1.ToCharArray();
            Array.Sort(charray1);

            char[] charray2 = str2.ToCharArray();
            Array.Sort(charray2);

            for (int i = 0; i < charray1.Length; i++)
            {
                if (charray1[i] != charray2[i])
                    return false;
            }

            return true;            
        }
    }
}
