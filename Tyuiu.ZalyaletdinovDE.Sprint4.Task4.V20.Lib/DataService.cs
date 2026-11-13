using tyuiu.cources.programming.interfaces.Sprint4;
using static System.Runtime.InteropServices.JavaScript.JSType;
namespace Tyuiu.ZalyaletdinovDE.Sprint4.Task4.V20.Lib
{
    public class DataService : ISprint4Task4V20
    {
        public int[,] Calculate(int[,] matrix)
        {
            int rows = matrix.GetUpperBound(0) + 1;
            int columns = matrix.Length / rows;

            for (int i = 0; i <= rows - 1; i++)
            {
                for (int j = 0; j <= columns - 1; j++)
                {
                    if (matrix[i, j] % 2 == 0) matrix[i, j] = 1;
                }
            }

            return matrix;
        }
    }
}
