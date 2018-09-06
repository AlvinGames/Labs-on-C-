using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to a digital shooting gallery!");
            Console.Write("Choose target radius: ");
            float radius = float.Parse(Console.ReadLine());
            Console.WriteLine("You have 10 attempts on hit\n");

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Step number {0}", i + 1);
                Console.WriteLine("Input shot coordinates:");
                Console.Write("x = ");
                float x = float.Parse(Console.ReadLine());
                Console.Write("y = ");
                float y = float.Parse(Console.ReadLine());

                bool leftTarget = (x <= 0 && x >= -radius && y >= 0 && y <= radius && Math.Pow((x + radius), 2) + Math.Pow((y - radius), 2) >= Math.Pow(radius, 2));
                bool rightTarget = (x >= 0 && x <= radius && y <= 0 && y >= -radius && x * x + y * y <= Math.Pow(radius, 2));

                if (leftTarget || rightTarget) Console.WriteLine("Perfectly, you have got\n");
                else Console.WriteLine("Unfortunately you have missed the mark\n");
            }

            Console.WriteLine("Для продолжения нажмите любую клавишу...");
            Console.ReadKey();
        }
    }
}
