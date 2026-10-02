using Tyuiu.GusamovMD.Sprint1.Task7.V4.Lib;
namespace Tyuiu.GusamovMD.Sprint1.Task7.V4.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            double x = -1;
            double y = 0;

            DataService ds = new DataService();

            double result = ds.Calculate(x, y);

            double wait = 0;

            Assert.AreEqual(wait, result);

        }
    }
}
