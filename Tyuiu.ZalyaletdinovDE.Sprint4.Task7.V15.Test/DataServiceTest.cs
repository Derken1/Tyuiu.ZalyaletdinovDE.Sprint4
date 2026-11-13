using Tyuiu.ZalyaletdinovDE.Sprint4.Task7.V15.Lib;

namespace Tyuiu.ZalyaletdinovDE.Sprint4.Task7.V15.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            int n = 4;
            int m = 2;
            string value = "10293847";

            DataService ds = new DataService();
            int res = ds.Calculate(n, m, value);
            int wait = 4;

            Assert.AreEqual(wait, res);
        }
    }
}