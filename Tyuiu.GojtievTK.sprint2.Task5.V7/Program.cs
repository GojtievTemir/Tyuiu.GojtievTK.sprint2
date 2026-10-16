using Tyuiu.GojtievTK.sprint2.Task5.V7.Lib;
namespace Tyuiu.GojtievTK.sprint2.Task5.V7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #1 | Выполнил: Гойтиев Т. К. | ПКТб-26-1";
            Console.WriteLine("********************************************************************************************************");
            Console.WriteLine("* Спринт #2                                                                                            *");
            Console.WriteLine("* Тема: Базовые навыки работы в C#                                                                     *");
            Console.WriteLine("* Задание #0                                                                                           *");
            Console.WriteLine("* Вариант #19                                                                                           *");
            Console.WriteLine("* Выполнил: Гойтиев Темирсолтан Крымсолтанович | ПКТБ-26-1                                             *");
            Console.WriteLine("********************************************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                                             *");
            Console.WriteLine("* Написать консольную программу, которая вычисляет выражение 15/2/4                                    *");
            Console.WriteLine("* и печатает результат на экране.                                                                      *");
            Console.WriteLine("*                                                                                                      *");
            Console.WriteLine("********************************************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                                                     *");
            Console.WriteLine("15/2/4                                                                                                  ");
            Console.WriteLine("********************************************************************************************************");
            Console.WriteLine("********************************************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                                           *");
            int n;
            n = int.Parse(Console.ReadLine());

            Console.WriteLine("********************************************************************************************************");
            Console.WriteLine(ds.FindMonthName(1990,n));
            Console.ReadLine();


        }
    }
}
