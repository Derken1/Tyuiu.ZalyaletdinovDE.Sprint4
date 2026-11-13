using Tyuiu.ZalyaletdinovDE.Sprint4.Task2.V1.Lib;
namespace Tyuiu.ZalyaletdinovDE.Sprint4.Task2.V1.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();
            Random rnd = new Random();
            int[] numsArray = { 1, 7, 3, 6, 9, 5, 4, 2, 4, 5 };
            int res = ds.Calculate(numsArray);
            Assert.AreEqual(192, res);
        }
    }
}
