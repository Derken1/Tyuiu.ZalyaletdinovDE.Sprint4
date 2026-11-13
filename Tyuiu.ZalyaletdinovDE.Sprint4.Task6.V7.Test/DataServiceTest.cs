using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.ZalyaletdinovDE.Sprint4.Task6.V7.Lib;

namespace Tyuiu.ZalyaletdinovDE.Sprint4.Task6.V7.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();

            string[] subjects = new string[]
            {
                "Математика", "Физика", "Химия", "Биология",
                "География", "История", "Экономика"
            };

            int res = ds.Calculate(subjects);
            int wait = 3;

            Assert.AreEqual(wait, res);
        }
    }
}