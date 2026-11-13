using Tyuiu.ZalyaletdinovDE.Sprint4.Task3.V15.Lib;
namespace Tyuiu.ZalyaletdinovDE.Sprint4.Task3.V15.Test
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
                { 1, 2, 3, 4, 5 },
                { 6, 7, 8, 9, 10 },
                { 11, 12, 13, 14, 15 },
                { 16, 17, 18, 19, 20 },
                { 21, 22, 23, 24, 25 }
            };
            int res = ds.Calculate(numsArray);
            Assert.AreEqual(13, res);
        }
    }
}
