using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1_7
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] mas = fill();

            int min, max;
            Console.Write("Input min interval: ");
            input(out min);
            Console.Write("Input max interval: ");
            input(out max);

            print(mas);

            int s = sum(mas, min, max);
            Console.Write("Summ of elements = {0}\n", s);
        }

        static int sum(int[] mas, int min, int max)
        {
            int sum = 0;
            for (int i = 0; i < mas.Length; i++)
            {
                if (mas[i] >= min && mas[i] <= max) sum += mas[i];
            }

            return sum;
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

        static int[] fill()
        {
            Console.Write("Input size of massif: ");
            int size;
            input(out size);

            int[] mas = new int[size];

            Console.WriteLine("Fill the massif: ");
            for (int i = 0; i < size; i++)
            {
                Console.Write("mas[{0}] = ", i);
                input(out mas[i]);
            }

            return mas;
        }

        static int[] generate(int min, int max)
        {
            Console.Write("Input size of massif: ");
            int size = int.Parse(Console.ReadLine());

            int[] mas = new int[size];

            Random obj = new Random();
            for (int i = 0; i < size; i++)
            {
                mas[i] = obj.Next(min, max);
            }

            return mas;
        }

        static void print(int[] mas)
        {
            Console.Write("Your massif: ");
            foreach (int x in mas)
            {
                Console.Write("{0} ", x);
            }
            Console.WriteLine();
        }
    }
}
