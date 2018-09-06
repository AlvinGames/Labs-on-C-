//by_Kanatush_Timofey
//variant_2
//

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
            int[,] mas = fill();

            if (function(mas)) Console.WriteLine("The sum of elements of a matrix is two-digit number and multiple 5");
            else Console.WriteLine("The sum of elements of a matrix is not a two-digit number");
        }

        static bool function(int[,] mas)
        {
            int sum = 0;

            for (int i = 0; i < mas.GetLength(0); i++)
            {
                for (int j = 0; j < mas.GetLength(1); j++)
                {
                    sum += mas[i, j];
                }
            }

            bool num = (sum.ToString().Length == 2) && (sum % 5 == 0);

            return num;
        }

        static void input(out int number)
        {
            bool Number = true;

            do
            {
                if (!Number) { Console.Write("It's not a number, try again: "); }
                Number = int.TryParse(Console.ReadLine(), out number);
            } while (!Number);

        }

        static int[,] fill()
        {
            Console.Write("Input size of matrix: ");
            int size;
            input(out size);

            int[,] mas = new int[size, size];

            Console.WriteLine("Fill the massif: ");
            for (int i = 0; i < size; i++)
                for (int j = 0; j < size; j++)
                {
                    Console.Write("mas[{0}][{1}] = ", i, j);
                    input(out mas[i, j]);
                }

            return mas;
        }

        static int[,] generate(int min, int max)
        {
            Console.Write("Input size of matrix: ");
            int size = int.Parse(Console.ReadLine());

            int[,] mas = new int[size, size];

            Random obj = new Random();
            for (int i = 0; i < size; i++)
                for (int j = 0; j < size; j++)
                {
                    mas[i, j] = obj.Next(min, max);
                }

            return mas;
        }

        static void print(int[,] mas)
        {
            Console.WriteLine("Your matrix:");

            for (int i = 0; i <= mas.GetUpperBound(0); i++)
            {
                for (int j = 0; j <= mas.GetUpperBound(1); j++)
                {
                    Console.Write("{0} ", mas[i, j]);
                }
                Console.WriteLine();
            }
        }
    }
}
