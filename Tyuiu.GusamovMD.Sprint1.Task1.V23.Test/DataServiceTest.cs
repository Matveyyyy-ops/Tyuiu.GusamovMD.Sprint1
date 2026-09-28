using Tyuiu.GusamovMD.Sprint1.Task1.V23.Lib;
namespace Tyuiu.GusamovMD.Sprint1.Task1.V23.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double a = 3.14;
            double x = -2;
            var res = ds.Calculate(a, x);
            Assert.AreEqual(-1, res);
        }
    }
}
