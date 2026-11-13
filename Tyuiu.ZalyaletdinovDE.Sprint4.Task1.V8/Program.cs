using Tyuiu.ZalyaletdinovDE.Sprint4.Task1.V8.Lib;

namespace Tyuiu.ZalyaletdinovDE.Sprint4.Task1.V8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            int[] numsArray = new int[12];
            for (int i = 0; i < numsArray.Length; i++)
            {
                Console.Write("Введите значение " + i + " элемента массива: ");
                numsArray[i] = Convert.ToInt32(Console.ReadLine());
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
            int sum = ds.Calculate(numsArray);
            Console.WriteLine("Сумма всех нечётных элементов: " + sum);
        }
    }
}
