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
            Console.Write("x1 = ");
            float x1 = float.Parse(Console.ReadLine());
            Console.Write("x2 = ");
            float x2 = float.Parse(Console.ReadLine());
            Console.Write("Input step: ");
            float step = float.Parse(Console.ReadLine());

            float y = 0;

            for (float i = x1; i <= x2; i += step)
            {
                if (i >= -9 && i < 7)
                {
                    if ((i >= -9 && i <= -7) || (i > 4 && i <= 7))
                    {
                        y = 0;
                    }
                    if (i > -7 && i <= -3)
                    {
                        y = i + 7;
                    }
                    if (i > -3 && i <= -2)
                    {
                        i = 4;
                    }
                    if (i > -2 && i <= 2)
                    {
                        y = i * i;
                    }
                    if (i > 2 && i <= 4)
                    {
                        y = -2 * i + 8;
                    }

                    Console.WriteLine("y = {0}\tx = {1}", y, i);
                }
                else
                {
                    Console.WriteLine("Coordinate {0} doesn't belong to a function graph!", i);
                }
            }


            Console.WriteLine("Для продолжения нажмите любую клавишу...");
            Console.ReadKey();
        }
    }
}
