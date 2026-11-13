using tyuiu.cources.programming.interfaces.Sprint4;
namespace Tyuiu.ZalyaletdinovDE.Sprint4.Task3.V15.Lib
{
    public class DataService : ISprint4Task3V15
    {
        public int Calculate(int[,] array)
        {
            int count = 0;
            int rows = array.GetUpperBound(0) + 1;
            int columns = array.Length / rows;

            for (int i = 0; i <= rows-1; i++)
            {
                for (int j = 0; j <= columns-1; j++)
                {
                    if (array[i, j] % 2 == 1) count++;
                }
            }

            return count;
        }
    }
}
