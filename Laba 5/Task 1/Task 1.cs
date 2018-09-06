using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1
{
    class Program
    {
        static void Main(string[] args)
        {
            double s1 = function(6) / 2;
            double s2 = function(13) / 2;
            double s3 = function(21) / 2;
            double result = s1 + s2 + s3;
            Console.WriteLine("{0:F2} + {1:F2} + {2:F2} = {3:F2}", s1, s2, s3, result);

            Console.Write("Для продолжения нажмите любую клавишу...");
            Console.ReadKey();
        }

        static double function(double num)
        {
            num += Math.Sqrt(num);
            return num;
        }
    }
}
