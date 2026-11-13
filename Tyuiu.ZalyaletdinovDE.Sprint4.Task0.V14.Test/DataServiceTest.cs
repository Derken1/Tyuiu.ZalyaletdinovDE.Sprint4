using Tyuiu.ZalyaletdinovDE.Sprint4.Task0.V14.Lib;

namespace Tyuiu.ZalyaletdinovDE.Sprint4.Task0.V14.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidGetSumOddArrEl()
        {
            DataService ds = new DataService();

            int[] numsArray = { 1, 2, 6, 1, 0, 7, 1, 9, 6, 4 };
            int res = ds.GetSumOddArrEl(numsArray);
            Assert.AreEqual(19, res);
        }
    }
}
