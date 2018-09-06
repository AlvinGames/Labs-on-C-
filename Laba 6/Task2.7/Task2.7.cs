using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2_7
{
    class Program
    {
        static void Main(string[] args)
        {
            float[] mas = fill();

            print(mas);

            int i = index(mas);
            Console.WriteLine("Index of max element: {0}\nelement: {1}", i + 1, mas[i]);
        }

        static int index(float[] mas)
        {
            float max = 0;
            int index = 0;
            for (int i = 0; i < mas.Length; i++)
            {
                if(mas[i] >= max)
                {
                    max = mas[i];
                    index = i;
                }
            }
            
            return index;
        }

        static void input(out float number)
        {
            bool Number = true;

            do
            {
                if (!Number) { Console.Write("It's not a number, try again: "); }
                Number = float.TryParse(Console.ReadLine(), out number);
            } while (!Number);

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

        static float[] fill()
        {
            Console.Write("Input size of massif: ");
            int size;
            input(out size);

            float[] mas = new float[size];

            Console.WriteLine("Fill the massif: ");
            for (int i = 0; i < size; i++)
            {
                Console.Write("mas[{0}] = ", i);
                input(out mas[i]);
            }

            return mas;
        }

        static void print(float[] mas)
        {
            Console.Write("Your massif: ");
            foreach (float x in mas)
            {
                Console.Write("{0} ", x);
            }
            Console.WriteLine();
        }
    }
}
