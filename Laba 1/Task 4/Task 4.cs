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
            try
            {
                Console.Write("a= ");
                float a = float.Parse(Console.ReadLine());
                Console.Write("b= ");
                float b = float.Parse(Console.ReadLine());
                Console.WriteLine("{0:F1}*{1:F1}={2:F1}", a, b, a * b);
            }
            catch (FormatException)
            {
                Console.WriteLine("Error: Format exception!");
            }

            Console.Write("Для продолжения нажмите любую клавишу...");
            Console.ReadKey();
        }
    }
}
