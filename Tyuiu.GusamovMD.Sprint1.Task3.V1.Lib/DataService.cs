using tyuiu.cources.programming.interfaces.Sprint1;
namespace Tyuiu.GusamovMD.Sprint1.Task3.V1.Lib
{
    public class DataService : ISprint1Task3V1
    {
        public double CylinderVolume(double r, double h)
        {
            double Pi = 3.141;
            return r * r * h * Pi;
        }
    }
}
