using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.FilatovDK.Sprint2.Task7.V12.Lib
{
    public class DataService : ISprint2Task7V12
    {
        public bool CheckDotInShadedArea(double x, double y)
        {
            bool res;
            if (((Math.Pow(x, 2) + Math.Pow(y, 2)) <= 1 && y >= 0))
            {
                res = false;
            }
            else
            {
                if (((Math.Pow(x, 2) + Math.Pow(y, 2)) <= 4 && y >= 0) && (Math.Abs(x) <= 2 && y > 0))
                {
                    res = true;
                }
                else
                {
                    res = false;
                }
            }
            return res;
        }
    }
}