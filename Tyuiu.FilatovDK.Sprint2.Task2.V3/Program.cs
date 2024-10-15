using Tyuiu.FilatovDK.Sprint2.Task2.V3.Lib;
namespace Tyuiu.FilatovDK.Sprint2.Task2.V3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            {

                DataService ds = new DataService();
                Console.Title = "Спринт #2 | Выполнил: Филатов Д. К. | СМАРТб-23-1 ";
                Console.WriteLine("**************************************************************************");
                Console.WriteLine("* Спринт #2                                                              *");
                Console.WriteLine("* Тема: Алгоритмы разветвляющей структуры. Оператор if                   *");
                Console.WriteLine("* Задание #2                                                             *");
                Console.WriteLine("* Вариант #3                                                             *");
                Console.WriteLine("* выполнил: Филатов Денис Константинович | СМАРТб-23-1                   *");
                Console.WriteLine("**************************************************************************");
                Console.WriteLine("* УСЛОВИЕ:                                                               *");
                Console.WriteLine("* Написать программу, которая запрашивает целые значения с клавиатуры и  *");
                Console.WriteLine("* вычисляет находится ли точка с координатами X,Y в заштрихованной       *");
                Console.WriteLine("*  области                                                               *");
                Console.WriteLine("**************************************************************************");
                Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                       *");
                Console.WriteLine("**************************************************************************");

                int x, y;
                Console.WriteLine(" Введите значение переменной х: ");
                x = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(" Введите значение переменной y: ");
                y = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("***************************************************************************");
                Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
                Console.WriteLine("***************************************************************************");

                bool res = ds.CheckDotInShadedArea(x, y);

                if (res == true)
                    Console.WriteLine("True");
                else
                    Console.WriteLine("Fales");

                Console.ReadKey();



            }
        }
    }
}