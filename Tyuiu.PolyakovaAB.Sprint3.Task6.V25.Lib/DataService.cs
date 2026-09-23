using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.PolyakovaAB.Sprint3.Task6.V25.Lib
{
    public class DataService : ISprint3Task6V25
    {
        public int GetSumTheDivisors(int startValue, int stopValue)
        {
            int sum = 0;
            for (int i = startValue; i <= stopValue; i++)
            {
                int sumd = 0;
                for (int j = 1; j <= i; j++)
                {
                    if (i % j == 0 && j<10)
                    {
                        sumd += j;
                    }
                }
                sum += sumd;
            }
            return sum;
        }
    }
}
