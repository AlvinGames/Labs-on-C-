using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_7
{
    class Program
    {
        static void Main(string[] args)
        {
            // Форматирование с параметрами
            Console.WriteLine("C format: {0:C}", 99989.987);
            Console.WriteLine("D9 format: {0:D7}", 99999);
            Console.WriteLine("E format: {0:E}", .31415926538 * 10);
            Console.WriteLine("F format: {0:F3}", 55555.6664);
            Console.WriteLine("N format: {0:N}", 99999);
            Console.WriteLine("X format: {0:X}", 99999);
            Console.WriteLine("x format: {0:x}", 99999);
            Console.Write("\n\n");

            Console.Write("Для продолжения нажмите любую клавишу...");
            Console.ReadKey();
        }
    }
}
