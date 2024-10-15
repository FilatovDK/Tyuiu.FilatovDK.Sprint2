using Tyuiu.FilatovDK.Sprint2.Task5.V12.Lib;
namespace Tyuiu.FilatovDK.Sprint2.Task5.V12.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidFindDateOfPreviousDay()
        {
            DataService ds = new DataService();

            int g = 1980;
            int m = 10;
            int n = 28;

            string wait = "27.10.1980";

            string res = ds.FindDateOfPreviousDay(g, m, n);
            Assert.AreEqual(wait, res);
        }
    }
}