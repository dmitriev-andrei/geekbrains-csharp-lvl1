using System;

namespace Dmitriev_05
{
    class Doubler
    {
        int current;
        int finish;

        public int Current { get { return current;  } }
        public int Finish { get { return finish; } }

        /// <summary>
        /// Конструктор по умолчанию
        /// </summary>
        public Doubler()
        {
            current = 1;

            Random rnd = new Random();
            finish = rnd.Next(2, 101);
        }

        /// <summary>
        /// Создает объект класса Doubler с заданным конечным числом, переданным в параметре
        /// </summary>B
        public Doubler(int finish)
        {
            current = 1;
            this.finish = finish;
        }

        /// <summary>
        /// Удваивает текущее значение
        /// </summary>
        public void Doubling()
        {
            current = current * 2;
        }

        /// <summary>
        /// Увеличивает текущее значение на единицу
        /// </summary>
        public void PlusOne()
        {
            current++;
        }
        
        /// <summary>
        /// Сбрасывает текущее значение до единицы
        /// </summary>
        public void Reset()
        {
            current = 1;
        }
    }
}
