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
            for(int i = 1; i < 6; i++)
            {
                for(int j = 1; j <= i; j++)
                {
                    Console.Write("{0} ", i);
                }
                Console.WriteLine();
            }

            Console.Write("Для продолжения нажмите любую клавишу...");
            Console.ReadKey();
        }
    }
}
