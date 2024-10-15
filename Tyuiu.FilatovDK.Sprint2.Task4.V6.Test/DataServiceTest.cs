using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.FilatovDK.Sprint2.Task4.V6.Lib;
namespace Tyuiu.FilatovDK.Sprint2.Task4.V6.Test
{
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            double res = ds.Calculate(1, 1);
            Assert.AreEqual(0.667, res, 0.001);
        }
    }
}
