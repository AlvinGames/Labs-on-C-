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
            double x = 0;
            do
            {
                if (x == 3) Console.WriteLine("Деление на ноль!");
                Console.Write("Input a number: ");
                 x = Convert.ToDouble(Console.ReadLine());
                

            } while (x == 3);

            

            double z1 = (Math.Pow(x, 2) + 2 * x - 3 + (x + 1) * Math.Sqrt(Math.Pow(x, 2) - 9)) / (Math.Pow(x, 2) - 2 * x - 3 + (x - 1) * Math.Sqrt(Math.Pow(x, 2) - 9));
            double z2 = Math.Sqrt((x + 3) / (x - 3));

            Console.WriteLine("z1 = " + z1);
            Console.WriteLine("z2 = " + z2);

            Console.WriteLine("Для продолжения нажмите любую клавишу...");
            Console.ReadKey();
        }
    }
}
