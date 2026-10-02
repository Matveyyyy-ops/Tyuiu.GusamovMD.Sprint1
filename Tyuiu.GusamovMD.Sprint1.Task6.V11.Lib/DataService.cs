using tyuiu.cources.programming.interfaces.Sprint1;
namespace Tyuiu.GusamovMD.Sprint1.Task6.V11.Lib
{
    public class DataService : ISprint1Task6V11
    {
        public bool CheckeFirstLetterRepetition(string value)
        {
            value = value.Replace(" ", "");
            if (value.Length <= 1)
                return false;

            value = value.ToLower();

            return value.Substring(1).Contains(value[0]);
        }
    }
}
