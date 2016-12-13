using System;

namespace Dmitriev_05_boby_weight_index
{
    enum BodyState { SKINNY, NORMAL, FAT }

    class Program
    {
        /* Дмитриев Андрей
         * 
         * а) Написать программу, которая запрашивает массу и рост человека, вычисляет его индекс массы и
         * сообщает, нужно ли человеку похудеть, набрать вес или вес в норме.
         * 
         * б) *Рассчитать, на сколько кг похудеть или сколько кг набрать для нормализации веса.
         */
        static void Main(string[] args)
        {
            Console.WriteLine("Вычисление и анализ индекса массы тела (ИМТ).\n");

            Console.Write("Введите вес (кг): ");
            int weight = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите рост (м): ");
            double height = Convert.ToDouble(Console.ReadLine());

            double bodyWeightIndex = GetBodyWeigthIndex(weight, height);
            BodyState bodyState = GetBodyState(bodyWeightIndex);

            string bodyStateDescription = string.Empty;
            switch (bodyState)
            {
                case BodyState.SKINNY:
                    bodyStateDescription = "дефицит массы тела";
                    break;
                case BodyState.NORMAL:
                    bodyStateDescription = "норма";
                    break;
                case BodyState.FAT:
                    bodyStateDescription = "ожирение";
                    break;
                default:
                    break;
            }

            // вариант "а"
            Console.WriteLine("\nВаш индекс массы тела равен: {0} - это {1}.", bodyWeightIndex.ToString("f2"), bodyStateDescription);

            // вариант "б" - в случае дефицита веса или ожирения получить рекомендации
            if (bodyState != BodyState.NORMAL)
            {
                Console.WriteLine("\nВам рекомендовано: {0}", GetRecomendations(weight, height));
            }            

            Console.WriteLine("\n\nДля выхода нажмите любую кнопку ..");
            Console.ReadKey();
        }

        /// <summary>
        /// Выдает рекомендации по изменению массы тела до значения нормы.
        /// </summary>
        private static string GetRecomendations(int weight, double height)
        {
            BodyState state = GetBodyState(GetBodyWeigthIndex(weight, height));
            int i = 1;

            if (state == BodyState.SKINNY)
            {
                // нужно набрать набрать N килограмм
                while (GetBodyWeigthIndex(weight + i, height) < 18.5)
                {
                    i++;
                }

                return string.Format("набрать {0} кг", i);
            }
            else
            {
                // нужно сбросить N килограмм
                while (GetBodyWeigthIndex(weight - i, height) > 24.99)
                {
                    i++;
                }
                
                return string.Format("сбросить {0} кг", i);
            }                        
        }

        /// <summary>
        /// Определяет текущее состояние тела (дефицит массы, норма, ожирение).
        /// </summary>
        /// <param name="bodyWeightIndex">Индекс массы тела</param>
        /// <returns>Возвращает значения типа BodyState</returns>
        private static BodyState GetBodyState(double bodyWeightIndex)
        {
            if (bodyWeightIndex < 18.5)
                return BodyState.SKINNY;
            else if (bodyWeightIndex < 24.99)
            {
                return BodyState.NORMAL;
            }
            else
            {
                return BodyState.FAT;
            }
        }

        /// <summary>
        /// Вычисляет индекс массы тела (ИМТ) человека.
        /// </summary>
        /// <param name="weight">Вес в килограммах</param>
        /// <param name="height">Рост в метрах</param>        
        private static double GetBodyWeigthIndex(int weight, double height)
        {
            return weight / (height * height);
        }
    }
}
