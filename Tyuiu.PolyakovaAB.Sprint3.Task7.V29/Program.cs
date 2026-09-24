using Tyuiu.PolyakovaAB.Sprint3.Task7.V29.Lib;
namespace Tyuiu.PolyakovaAB.Sprint3.Task7.V29
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            int n, k;
            Console.Title = "Спринт #3 | Выполнила: Полякова А. В. | ИИПб-26-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #3                                                               *");
            Console.WriteLine("* Тема: Добавление к решению итоговых проектов по спринту                 *");
            Console.WriteLine("* Задание #7                                                              *");
            Console.WriteLine("* Вариант #29                                                             *");
            Console.WriteLine("* Выполнила: Полякова Арина Вячеславовна | ИИПб-26-1                      *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, которая выводит таблицу значений функций.           *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Введите startValue:                                                     *");
            n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("* Введите stopValue:                                                      *");
            k = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("+----------+----------+");
            Console.WriteLine("|    X     |   f(x)   |");
            Console.WriteLine("+----------+----------+");
            double[] g;
            g = new double[k-n+1];
            g = ds.GetMassFunction(n, k);
            int len = g.Length;
            for (int i = 0; i < (len); i++)
            {
                Console.WriteLine("|{0,7:d}   |  {1,6:f2}  |", n, g[i]);
                n++;
            }
            Console.WriteLine("+----------+----------+");
            Console.ReadKey();
            
            
        }
    }
}
