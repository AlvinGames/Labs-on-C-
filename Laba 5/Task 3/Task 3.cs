using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3
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

            double y;

            for (double i = a; i <= b; i += step)
            {
                function(i, out y);
                Console.WriteLine("function({0}) = {1}", i, y);
            }

            Console.Write("Для продолжения нажмите любую клавишу...");
            Console.ReadKey();
        }

        static void function(double x, out double y)
        {
            if (x < 0) y = -4;
            if (x >= 0 && x < 1) y = x * x;
            else y = 2;
        }
    }
}
