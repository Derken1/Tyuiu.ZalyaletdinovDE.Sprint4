using System;
using Tyuiu.ZalyaletdinovDE.Sprint4.Task6.V7.Lib;

namespace Tyuiu.ZalyaletdinovDE.Sprint4.Task6.V7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #4 | Выполнил: Залялетдинов Д. Э. | РППб-26-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("* Тема: Класс Array                                                       *");
            Console.WriteLine("* Задание #6                                                              *");
            Console.WriteLine("* Вариант #7                                                              *");
            Console.WriteLine("* Выполнил: Залялетдинов Д. Э. | РППб-26-1                                *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дан строковый массив данных [\"Математика\", \"Физика\", \"Химия\",          *");
            Console.WriteLine("* \"Биология\", \"География\", \"История\", \"Экономика\"] используя класс Array *");
            Console.WriteLine("* подсчитайте количество элементов, длина которых больше 8.               *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            string[] subjects = new string[]
            {
                "Математика", "Физика", "Химия", "Биология",
                "География", "История", "Экономика"
            };

            Console.WriteLine("Исходный массив:");
            for (int i = 0; i < subjects.Length; i++)
            {
                Console.WriteLine(subjects[i]);
            }

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            int res = ds.Calculate(subjects);
            Console.WriteLine("Количество элементов с длиной больше 8 = " + res);
        }
    }
}