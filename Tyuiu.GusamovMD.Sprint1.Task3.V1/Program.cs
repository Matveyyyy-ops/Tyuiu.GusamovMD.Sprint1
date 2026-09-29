using Tyuiu.GusamovMD.Sprint1.Task3.V1.Lib;
namespace Tyuiu.GusamovMD.Sprint1.Task3.V1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ                                                         *");
            Console.WriteLine("***************************************************************************");

            double r = 2;
            double h = 3;
            Console.WriteLine("Радиус R основания цилиндра = " + r);
            Console.WriteLine("Прямая H высота цилиндра = " + h);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ                                                               *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Объём цилиндра = " + ds.CylinderVolume(r, h));

            Console.ReadKey();

        }
    }
}
