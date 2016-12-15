using System.Text;
using System.Text.RegularExpressions;

namespace Dmitriev_02
{
    internal class MyString
    {
        private string str;
        private string[] words;

        public MyString(string str)
        {
            this.str = str;
            words = str.Split(' ');
        }

        /// <summary>
        /// Возвращает строку с перечислением слов длиннее заданного количества символов
        /// </summary>
        internal StringBuilder GetWordsBiggerThat(int n)
        {
            StringBuilder sb = new StringBuilder();                        
            
            foreach (var item in words)
            {
                string word = Regex.Replace(item, "[.)(,;]", "");

                if (word.Length > n)
                    if (sb.Length == 0)
                        sb.Append(word);
                    else
                        sb.AppendFormat(", {0}", word);
            }

            return sb;
        }

        /// <summary>
        /// Возвращает исходную строку в которой удалены слова оканчивающихся на заданный символ
        /// </summary>
        internal StringBuilder GetWordsNotEndTo(char c)
        {
            StringBuilder sb = new StringBuilder(str);

            foreach (var item in words)
            {

                if (item[item.Length -1] == c)
                {
                    sb.Replace(item, "");                    
                }
            }

            return sb;
        }

        /// <summary>
        /// Возвращает самое длинное слово. Если слов с такой длиной несколько - возвращается первое встреченное.
        /// </summary>
        internal string GetLongestWord()
        {
            Regex re = new Regex("[.)(,;]");

            string longestWord = re.Replace(words[0], "");

            foreach (var item in words)
            {
                string word = re.Replace(item, "");
                if (word.Length > longestWord.Length)
                    longestWord = word;
            }

            return longestWord;
        }

        /// <summary>
        /// Возвращает строку с перечислением самых длинных слов в строке
        /// </summary>
        internal StringBuilder GetAllLongestWords()
        {
            StringBuilder sb = new StringBuilder();

            Regex re = new Regex("[.)(,;]");
            string longestWord = re.Replace(words[0], "");

            foreach (var item in words)
            {
                string word = re.Replace(item, "");
                if (word.Length > longestWord.Length)
                {
                    longestWord = word;
                    sb.Clear();
                    sb.Append(word);
                }
                else if (word.Length == longestWord.Length)
                {
                    sb.AppendFormat(", {0}", word);
                }
            }
           
            return sb;
        }
    }
}