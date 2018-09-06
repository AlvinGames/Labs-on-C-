using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input interval:");
            Console.Write("a = ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("b = ");
            double b = double.Parse(Console.ReadLine());
            Console.Write("Input step: ");
            double step = double.Parse(Console.ReadLine());

            for (double i = a; i <= b; i += step)
            {
                double y = function(i);
                Console.WriteLine("function({0}) = {1}", i, y);
            }

            Console.Write("Для продолжения нажмите любую клавишу...");
            Console.ReadKey();
        }

        static double function(double x)
        {
            if (x < 0) return -4;
            if (x >= 0 && x < 1) return x * x;
            return 2;
        }
    }
}
