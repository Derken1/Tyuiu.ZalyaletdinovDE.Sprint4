using Tyuiu.ZalyaletdinovDE.Sprint4.Task2.V1.Lib;
namespace Tyuiu.ZalyaletdinovDE.Sprint4.Task2.V1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Random rnd = new Random();
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            int[] numsArray = new int[10];
            for (int i = 0; i < numsArray.Length; i++)
            {
                numsArray[i] = rnd.Next(1, 9);
            }

            Console.WriteLine("Исходный массив:");
            Console.Write("{\t");
            for (int i = 0; i <= numsArray.Length - 1; i++)
            {
                Console.Write(numsArray[i] + ",\t");
            }
            Console.WriteLine("}");



            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            int mult = ds.Calculate(numsArray);
            Console.WriteLine("Произведение всех чётных элементов: " + mult);
        }
    }
}
