using Tyuiu.ZalyaletdinovDE.Sprint4.Task4.V20.Lib;
namespace Tyuiu.ZalyaletdinovDE.Sprint4.Task4.V20
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
                { 4, 5, 5, 6, 4 },
                { 7, 8, 4, 7, 5 },
                { 5, 6, 5, 8, 5 },
                { 7, 5, 8, 7, 8 },
                { 4, 7, 7, 8, 8 }
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
            int[,] resArr = ds.Calculate(numsArray);

            int rowsArr = resArr.GetUpperBound(0) + 1;
            int columnsArr = resArr.Length / rowsNum;

            Console.WriteLine("Итоговый массив: ");
            for (int i = 0; i <= rowsArr - 1; i++)
            {
                for (int j = 0; j <= columnsArr - 1; j++)
                {
                    Console.Write($"{resArr[i, j]} \t");
                }
                Console.WriteLine();
            }
        }
    }
}
