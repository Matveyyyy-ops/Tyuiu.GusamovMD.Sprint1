using Tyuiu.GusamovMD.Sprint1.Task4.V2.Lib;
namespace Tyuiu.GusamovMD.Sprint1.Task4.V2.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            double temp = 23;
            DataService ds = new DataService();
            double res = ds.FahrenheitToСelsius(temp);

            int result = Convert.ToInt32(res);

            int wait = -5;
            Assert.AreEqual(wait, result);
        }
    }
}
