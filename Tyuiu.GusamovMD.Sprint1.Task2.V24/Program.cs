using Tyuiu.GusamovMD.Sprint1.Task2.V24.Lib;
namespace Tyuiu.GusamovMD.Sprint1.Task2.V24
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ                                                         *");
            Console.WriteLine("***************************************************************************");

            int x;
            
            Console.WriteLine("Введите значение X:");
            x = Convert.ToInt32(Console.ReadLine());
            int y;

            Console.WriteLine("Введите значение Y:");
            

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ                                                               *");
            Console.WriteLine("***************************************************************************");
        
            Console.WriteLine("Квадрат их разницы X и Y = " + ds.CalculateDiffSquare(x, y));

            Console.ReadLine();
        }
    }
}
