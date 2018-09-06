using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("12 -> {0:X}", 12);
            Console.WriteLine("256 -> {0:X}", 256);
            Console.WriteLine("1001 -> {0:X}", 1001);
            Console.WriteLine("123456789 -> {0:X}", 123456789);

            Console.Write("Для продолжения нажмите любую клавишу...");
            Console.ReadKey();
        }
    }
}
