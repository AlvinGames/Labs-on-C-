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
            Console.Write("Armstrongs numbers: ");
            for (int i = 100; i < 1000; i++)
            {
                int number = i;
                int i1 = number % 10;
                number /= 10;
                int i2 = number % 10;
                number /= 10;
                int i3 = number;

                bool armstrong = i == Math.Pow(i1, 3) + Math.Pow(i2, 3) + Math.Pow(i3, 3);

                if (armstrong) Console.Write("{0} ", i);
            }

            Console.WriteLine("\nДля продолжения нажмите любую клавишу...");
            Console.ReadKey();
        }
    }
}
