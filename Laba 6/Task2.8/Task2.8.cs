using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2_8
{
    class Program
    {
        static void Main(string[] args)
        {
            float[] mas = fill();

            print(mas);

            int Imin = min(mas);
            int Imax = max(mas);

            Console.WriteLine("min {0}", mas[Imin]);
            Console.WriteLine("max {0}", mas[Imax]);

            if (Imax > Imin)
            {
                Console.WriteLine("the maximum on is after a minimum!");
            }
            else
            {
                float s = sum(mas, Imax, Imin);
                Console.WriteLine("Summ of elements: {0}", s);
            }
        }

        static float sum(float[] mas, int max, int min)
        {
            float sum = 0;
            for (int i = max + 1; i < min; i++)
            {
                sum += mas[i];
            }

            return sum;
        }

        static int min(float[] mas)
        {
            float min = mas[0];
            int index = 0;

            for (int i = 0; i < mas.Length; i++)
            {
                if(mas[i] < min)
                {
                    min = mas[i];
                    index = i;
                }
            }

            return index;
        }

        static int max(float[] mas)
        {
            float max = mas[0];
            int index = 0;

            for (int i = 0; i < mas.Length; i++)
            {
                if (mas[i] > max)
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
