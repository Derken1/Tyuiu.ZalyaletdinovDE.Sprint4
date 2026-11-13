using Tyuiu.ZalyaletdinovDE.Sprint4.Task4.V20.Lib;
namespace Tyuiu.ZalyaletdinovDE.Sprint4.Task4.V20.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();
            int[,] numsArray =
            {
                { 7, 5, 6, 4, 5 },
                { 5, 7, 8, 6, 8 },
                { 8, 8, 4, 6, 5 },
                { 7, 4, 8, 5, 6 },
                { 4, 7, 8, 5, 6 }
            };
            int[,] res = ds.Calculate(numsArray);
            int[,] cor =
            {
                { 7, 5, 1, 1, 5 },
                { 5, 7, 1, 1, 1 },
                { 1, 1, 1, 1, 5 },
                { 7, 1, 1, 5, 1 },
                { 1, 7, 1, 5, 1 }
            };
            CollectionAssert.AreEqual(res, cor);
        }
    }
}
