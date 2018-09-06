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
            Console.Write("x = ");
            double x = Convert.ToDouble(Console.ReadLine());
            double y = 0;

            if (x >= -9 && x <= 7)
            {
                if ((x >= -9 && x <= -7) || (x > 4 && x <= 7))
                {
                    y = 0;
                }
                if (x > -7 && x <= -3)
                {
                    y = x + 7;
                }
                if (x > -3 && x <= -2)
                {
                    y = 4;
                }
                if (x > -2 && x <= 2)
                {
                    y = x * x;
                }
                if (x > 2 && x <= 4)
                {
                    y = -2 * x + 8;
                }

                Console.WriteLine("y = " + y);
            }
            else
            {
                Console.WriteLine("Coordinate {0} doesn't belong to a function graph!", x);
            }

            Console.WriteLine("Для продолжения нажмите любую клавишу...");
            Console.ReadKey();
        }
    }
}
