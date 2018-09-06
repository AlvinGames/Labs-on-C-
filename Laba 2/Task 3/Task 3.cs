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
            Console.Write("Input coordinate x: ");
            float x = float.Parse(Console.ReadLine());
            Console.Write("Input coordinate y: ");
            float y = float.Parse(Console.ReadLine());

            if (x <= 50 && x >= -50 && y <= 25 && y >= -25)
            {
                if(x < 50 && x > -50 && y < 25 && y > -25)
                {
                    Console.WriteLine("Inside");
                }
                else
                {
                    Console.WriteLine("Оn border");
                }                
            }
            else
            {
                Console.WriteLine("Outsize");
            }
            
            
            Console.WriteLine("Для продолжения нажмите любую клавишу...");
            Console.ReadKey();
        }
    }
}
