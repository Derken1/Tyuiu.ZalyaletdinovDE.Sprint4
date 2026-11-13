using Tyuiu.ZalyaletdinovDE.Sprint4.Task0.V14.Lib;
namespace Tyuiu.ZalyaletdinovDE.Sprint4.Task0.V14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            int[] numsArray = { 8, 9, 5, 4, 3, 2, 1, 0, 5, 7 };
            Console.WriteLine("Исходный массив:");
            for (int i = 0; i <= numsArray.Length-1; i++)
            {
                Console.WriteLine(numsArray[i]);
            }



            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            int sum = ds.GetSumOddArrEl(numsArray);
            Console.WriteLine("Сумма всех нечётных элементов: " + sum);


        }
    }
}
