using Tyuiu.PolyakovaAB.Sprint3.Task5.V20.Lib;
namespace Tyuiu.PolyakovaAB.Sprint3.Task5.V20
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            int x, q, w, e, r;
            Console.Title = "Спринт #3 | Выполнила: Полякова А. В. | ИИПб-26-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #3                                                               *");
            Console.WriteLine("* Тема: Использование операторов continue и break в циклах                *");
            Console.WriteLine("* Задание #5                                                              *");
            Console.WriteLine("* Вариант #20                                                             *");
            Console.WriteLine("* Выполнила: Полякова Арина Вячеславовна | ИИПб-26-1                      *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, где x принимает значения от -5 до 5, вычислить      *");
            Console.WriteLine("* значение функции.                                                       *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Введите x:                                                              *");
            x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("* Введите start i:                                                        *");
            q = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("* Введите stop i:                                                         *");
            w = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("* Введите start k:                                                        *");
            e = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("* Введите stop k:                                                         *");
            r = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine(ds.GetSumSumSeries(x, q, w, e, r));
            Console.ReadKey();
        }
    }
}
