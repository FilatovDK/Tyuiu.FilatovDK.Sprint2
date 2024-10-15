using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.FilatovDK.Sprint2.Task1.V3.Lib
{
    public class DataService : ISprint2Task1V3
    {
        public bool[] GetLogicOperations(int a, int b, int c, int d)
        {
            bool[] res = new bool[6];

            res[0] = (a > b) | (c - 3 < d);
            res[1] = (a > b) & (c - 3 < d);
            res[2] = (a > b) || (c < d);
            res[3] = (a > b) && (c - 3 < d);
            res[4] = !(!res[1]);
            res[5] = (a + 135 > b) ^ (c - 3 < d);

            return res;
        }
    }
}
