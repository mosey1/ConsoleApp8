using System;

namespace ConsoleApp8
{
    class Program
    {
        static void Main(string[] args)
        { // 3.4 базовый уровень
            try
            {
                Console.WriteLine("|     x       |      y       |");
                for (double x = 0.1; x <= 2.5; x += 0.2)
                {
                    double y = Math.Pow(x, 2) + 2 * Math.PI * Math.Cos(Math.PI) * x;
                    Console.WriteLine("|{0,13:F1}|{1,14:F2}|", x, y);
                }
              
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
