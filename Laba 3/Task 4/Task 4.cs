using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_4
{
    class Program
    {
        static void Main(string[] args)
        {
            const double PI = 22 / 7;

            Console.WriteLine("Input interval:");
            Console.Write("x1 = ");
            double x1 = double.Parse(Console.ReadLine());
            Console.Write("x2 = ");
            double x2 = double.Parse(Console.ReadLine());
            Console.Write("Input step: ");
            double step = double.Parse(Console.ReadLine());
            Console.Write("Input an accuracy: ");
            double eps = double.Parse(Console.ReadLine());

            int count = 0;

            if (x1 >= 0)
            {
                for (double x = x1; x <= x2; x += step)
                {
                    count = 0;
                    double sum = 0, s0 = -1 / x, s1 = -1 / x;
                    do
                    {
                        count++;
                        s0 = s1;
                        s1 = -1.0 * s0 * s0 / (2 * count + 1);
                        sum += s0;

                    } while (Math.Abs(s0 - s1) > eps);

                    Console.WriteLine("arct({0}) = {1}, count of elements = {2}", x, PI / 2 + sum, count);
                }
            }
            else Console.WriteLine("x1 can't be less than 1!");

            Console.WriteLine("Для продолжения нажмите любую клавишу...");
            Console.ReadKey();
        }
    }
}
