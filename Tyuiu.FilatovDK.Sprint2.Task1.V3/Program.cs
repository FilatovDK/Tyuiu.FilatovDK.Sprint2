﻿using Tyuiu.FilatovDK.Sprint2.Task1.V3.Lib;
namespace Tyuiu.FilatovDK.Sprint2.Task1.V3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #2 | Выполнил: Филатов Д. К | СМАРТб-24-1";
            Console.WriteLine("*************************************************************************************");
            Console.WriteLine("* Спринт #2                                                                         *");
            Console.WriteLine("* Тема: Логические операции                                                         *");
            Console.WriteLine("* Задание #1                                                                        *");
            Console.WriteLine("* Вариант #3                                                                        *");
            Console.WriteLine("* Выполнил: Филатов Денис Константинович | СМАРТб-24-1                              *");
            Console.WriteLine("*************************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                          *");
            Console.WriteLine("* Написать программу из операций сравнений (==, !=, <, >, <=, >=,                   *");
            Console.WriteLine("* можно чередовать, но использовать один раз в выражении) и логических операций     *");
            Console.WriteLine("* (|, &, ||, &&, !, ^, последовательность операций не должна нарушаться), а также   *");
            Console.WriteLine("* арифметических выражений, которая вернет логическую последовательность(массив):   *");
            Console.WriteLine("* (True, False, False, False, False, False), при a = 185, b = 316, c = 134, d = 134 *");
            Console.WriteLine("*                                                                                   *");

            int a = 185;
            int b = 316;
            int c = 134;
            int d = 134;

            bool[] res = new bool[6];
            res = ds.GetLogicOperations(a, b, c, d);

            Console.WriteLine("*************************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                                  *");
            Console.WriteLine("*************************************************************************************");

            Console.WriteLine("a = " + a);
            Console.WriteLine("b = " + b);
            Console.WriteLine("c = " + c);
            Console.WriteLine("d = " + d);

            Console.WriteLine("*************************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                        *");
            Console.WriteLine("*************************************************************************************");

            for (int i = 0; i < 6; i++)
            {
                Console.WriteLine(res[i]);
            }

            Console.ReadKey();
        }
    }
}
