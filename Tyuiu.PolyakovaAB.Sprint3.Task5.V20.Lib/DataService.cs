using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.PolyakovaAB.Sprint3.Task5.V20.Lib
{
    public class DataService : ISprint3Task5V20
    {
        public double GetSumSumSeries(int x, int startValue1, int startValue2, int stopValue1, int stopValue2)
        {
            double y = 0;
            for (int i = startValue1; i <= stopValue1; i++)
            {
                double f = 0;
                for (int j = startValue2; j <= stopValue2; j++)
                {
                    f += (Math.Pow(x / (Math.Sin(x)), j));
                }
                y += f;
            }
            return Math.Round(y,3);

        }
    }
}
