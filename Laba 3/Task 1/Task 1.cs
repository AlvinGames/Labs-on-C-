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
            int y;
            for (int x = 1; x <= 23; x++)
            {
                y = 22 / x + 22 % x;
                Console.Write("{0}\t", y);
                for (int i = 0; i < y; i++)
                {
                    Console.Write("[]");
                }
                Console.WriteLine();
            }

            Console.WriteLine("Для продолжения нажмите любую клавишу...");
            Console.ReadKey();
        }
    }
}
