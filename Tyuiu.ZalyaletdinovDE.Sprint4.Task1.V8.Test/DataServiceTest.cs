using Tyuiu.ZalyaletdinovDE.Sprint4.Task1.V8.Lib;
namespace Tyuiu.ZalyaletdinovDE.Sprint4.Task1.V8.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();
            int[] numsArray = { 5, 2, 3, 9, 6, 4, 6, 5, 3, 2, 6, 8 };
            int res = ds.Calculate(numsArray);
            Assert.AreEqual(25, res);
        }
    }
}
