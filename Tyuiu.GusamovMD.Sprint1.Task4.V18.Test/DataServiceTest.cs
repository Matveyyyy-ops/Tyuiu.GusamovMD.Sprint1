using Tyuiu.GusamovMD.Sprint1.Task4.V18.Lib;
namespace Tyuiu.GusamovMD.Sprint1.Task4.V18.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = 1.0;
            double y = 4.0;
            double wait = 0.1250;
            var res = ds.Calculate(x, y);
            Assert.AreEqual(wait, res);

        }
    }
}
