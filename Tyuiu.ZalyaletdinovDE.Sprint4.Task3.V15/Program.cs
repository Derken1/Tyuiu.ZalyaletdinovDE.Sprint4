using Tyuiu.ZalyaletdinovDE.Sprint4.Task3.V15.Lib;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Tyuiu.ZalyaletdinovDE.Sprint4.Task3.V15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            int[,] numsArray =
            {
                { 7, 4, 2, 5, 3 },
                { 4, 3, 2, 5, 6 },
                { 6, 3, 4, 7, 5 },
                { 5, 7, 4, 3, 8 },
                { 7, 8, 8, 5, 6 }
            };

            int rowsNum = numsArray.GetUpperBound(0) + 1;
            int columnsNum = numsArray.Length / rowsNum;

            Console.WriteLine("Исходный массив:");
            for (int i = 0; i <= rowsNum - 1; i++)
            {
                for (int j = 0; j <= columnsNum - 1; j++)
                {
                    Console.Write($"{numsArray[i, j]} \t");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            



            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            int mult = ds.Calculate(numsArray);
            Console.WriteLine("Количество нечётных элементов: " + mult);
        }
    }
}
