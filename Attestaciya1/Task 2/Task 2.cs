//by_Kanatush_Timofey
//variant_2
//

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
            double x1, y1, x2, y2;
            Console.WriteLine("Input coordinate of line:");
            Console.Write("Input coordinate x1: ");
            input(out x1);
            Console.Write("Input coordinate y1: ");
            input(out y1);
            Console.Write("Input coordinate x2: ");
            input(out x2);
            Console.Write("Input coordinate y2: ");
            input(out y2);

            Console.Write("Length of line = {0}", Length(x1, y1, x2, y2));

            double a, b, c;
            Console.WriteLine("Input lengths of the parties of a triangle:");
            Console.Write("a=");
            input(out a);
            Console.Write("b=");
            input(out b);
            Console.Write("c=");
            input(out c);

            if (isTriangle(a, b, c)) Console.WriteLine("This triangle exists");
            else Console.WriteLine("This triangle doesn't exist");
        }

        static double Length (double x1, double y1, double x2, double y2)
        {
            return Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2));
        }

        static bool isTriangle(double a, double b, double c)
        {
            bool triangle1 = a < b + c;
            bool triangle2 = b < a + c;
            bool triangle3 = c < a + b;

            return triangle1 || triangle2 || triangle3;
        }

        static void input(out double number)
        {
            bool Number = true;

            do
            {
                if (!Number) { Console.Write("It's not a number, try again: "); }
                Number = double.TryParse(Console.ReadLine(), out number);
            } while (!Number);

        }
    }
}
