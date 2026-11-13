using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.ZalyaletdinovDE.Sprint4.Task5.V6.Lib;

namespace Tyuiu.ZalyaletdinovDE.Sprint4.Task5.V6.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();

            int[,] matrix = new int[5, 5]
            {
                { -3,  0,  2,  5, -1 },
                {  4, -2,  1,  0,  3 },
                { -1,  5, -3,  2,  0 },
                {  0,  3,  4, -2,  1 },
                {  2, -1,  0,  5, -3 }
            };

            int[,] wait = new int[5, 5]
            {
                { -3,  0,  1,  1, -1 },
                {  1, -2,  1,  0,  1 },
                { -1,  1, -3,  1,  0 },
                {  0,  1,  1, -2,  1 },
                {  1, -1,  0,  1, -3 }
            };

            int[,] res = ds.Calculate(matrix);

            CollectionAssert.AreEqual(wait, res);
        }
    }
}