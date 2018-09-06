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
            Console.Write("a= ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("b= ");
            int b = int.Parse(Console.ReadLine());

            Console.WriteLine("{0}+{1}={1}+{0}", a, b);

            Console.Write("Для продолжения нажмите любую клавишу...");
            Console.ReadKey();
        }
    }
}
