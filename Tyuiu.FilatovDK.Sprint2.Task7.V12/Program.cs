using Tyuiu.FilatovDK.Sprint2.Task7.V12.Lib;
namespace Tyuiu.FilatovDK.Sprint2.Task7.V12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            double x = Convert.ToDouble(Console.ReadLine());
            double y = Convert.ToDouble(Console.ReadLine());
            bool res = ds.CheckDotInShadedArea(x, y);
            Console.WriteLine(res);
            Console.ReadLine();

        }
    }
}