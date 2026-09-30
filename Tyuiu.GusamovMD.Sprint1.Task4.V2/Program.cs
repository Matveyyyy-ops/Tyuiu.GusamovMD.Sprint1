using Tyuiu.GusamovMD.Sprint1.Task4.V2.Lib;
namespace Tyuiu.GusamovMD.Sprint1.Task4.V2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title =  ("*Спринт #1 | Выполнил: Гусамов М. Д. | РППб-26-1                          *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #1                                                               *");
            Console.WriteLine("* Тема: Базовые наыки работы в C#                                         *");
            Console.WriteLine("* Задание #5                                                              *");
            Console.WriteLine("* Вариант #2                                                              *");
            Console.WriteLine(" Выполнил: Гусамов Матвей Дмитриевич | РППб-26-1                          *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, которая решает следующую задачу:                    *");
            Console.WriteLine("* Дано значение температуры в градусах Фаренгейта.                        *");
            Console.WriteLine("* Определить значение этой же температуры в градусах Цельсия.             *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ                                                         *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Введите Temp");
            double temp = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ                                                               *");
            Console.WriteLine("***************************************************************************");

            int res = Convert.ToInt32(ds.FahrenheitToСelsius(temp));
            Console.WriteLine(res);

            Console.ReadKey();

        }
    }
}
