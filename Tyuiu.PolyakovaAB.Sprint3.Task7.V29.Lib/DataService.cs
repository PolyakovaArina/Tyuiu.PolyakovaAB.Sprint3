using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.PolyakovaAB.Sprint3.Task7.V29.Lib
{
    public class DataService : ISprint3Task7V29
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            
            double[] f = new double[(stopValue-startValue)+1];
            int w = 0;
            for (int i = startValue; i <= stopValue; i++)
            {
                if (i == 0)
                {
                    f[w] = 0.0;
                }
                else
                {
                    f[w] = Math.Round(((2 * i - 3) / (Math.Cos(i) * 2 * i)) + 5 * i - 6,2);
                }
                w++;
            }
            return f;
        }
    }
}
