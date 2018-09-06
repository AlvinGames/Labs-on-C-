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
            Console.Write("Input chessboard size: ");
            int size = int.Parse(Console.ReadLine());

            int[,] desk = new int[size, size];

            int a = 1;

            for (int i = 0; i < size; i++)
            {
                int b = a;
                for (int j = 0; j < size; j++)
                {
                    desk[i, j] = b;
                    b *= -1;
                }
                a *= -1;
            }

            int count = 0;

            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    if (desk[i, j] > 0) count++;
                }
            }
            //1
            Console.WriteLine("Count of black cells {0}", count);

            //2
            Console.WriteLine("\nInput coordinate of cell:");
            Console.Write("x = ");
            int x = int.Parse(Console.ReadLine());
            Console.Write("y = ");
            int y = int.Parse(Console.ReadLine());

            if (desk[x - 1, y - 1] > 0) Console.WriteLine("This cell is black");
            else Console.WriteLine("This cell is white");

            //3
            Console.WriteLine("\nInput coordinate of two cells: ");
            Console.WriteLine("First cell:");
            Console.Write("x1 = ");
            int x1 = int.Parse(Console.ReadLine());
            Console.Write("y1 = ");
            int y1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Second cell:");
            Console.Write("x2 = ");
            int x2 = int.Parse(Console.ReadLine());
            Console.Write("y2 = ");
            int y2 = int.Parse(Console.ReadLine());

            if (desk[x1 - 1, y1 - 1] == desk[x2 - 1, y2 - 1]) Console.WriteLine("This cells have identical color");
            else Console.WriteLine("This cells don't have identical color");

            //4
            Console.WriteLine("Input coordinate of figure: ");
            Console.Write("x1 = ");
            int fx1 = int.Parse(Console.ReadLine());
            Console.Write("y1 = ");
            int fy1 = int.Parse(Console.ReadLine());
            Console.Write("x2 = ");
            int fx2 = int.Parse(Console.ReadLine());
            Console.Write("y2 = ");
            int fy2 = int.Parse(Console.ReadLine());

            bool threat = false;

            if (fx2 - 1 == fx1 && fy2 + 2 == fy1) { threat = true; }
            else if (fx2 + 1 == fx1 && fy2 + 2 == fy1) { threat = true; }
            else if (fx2 + 2 == fx1 && fy2 + 1 == fy1) { threat = true; }
            else if (fx2 + 2 == fx1 && fy2 - 1 == fy1) { threat = true; }
            else if (fx2 + 1 == fx1 && fy2 - 2 == fy1) { threat = true; }
            else if (fx2 - 1 == fx1 && fy2 - 2 == fy1) { threat = true; }
            else if (fx2 - 2 == fx1 && fy2 - 1 == fy1) { threat = true; }
            else if (fx2 - 2 == fx1 && fy2 + 1 == fy1) { threat = true; }

            if (threat) Console.WriteLine("The figure is under blow");
            else Console.WriteLine("The figure isn't under blow");

            Console.Write("Для продолжения нажмите любую клавишу...");
            Console.ReadKey();
        }
    }
}
