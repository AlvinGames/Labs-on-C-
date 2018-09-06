using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_6
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("a= ");
                float a = float.Parse(Console.ReadLine());
                Console.Write("b= ");
                float b = float.Parse(Console.ReadLine());
                Console.Write("c= ");
                float c = float.Parse(Console.ReadLine());

                Console.WriteLine("({0:N}+{1:N})+{2:N}={0:N}+({1:N}+{2:N})", a, b, c);
            }
            catch(FormatException)
            {
                Console.WriteLine("Error: Format exception!");
            }

            Console.Write("Для продолжения нажмите любую клавишу...");
            Console.ReadKey();
        }
    }
}
