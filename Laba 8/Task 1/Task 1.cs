using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//╔══╗─╔╗─╔══╦══╗╔══╗
//╚═╗║─║║─║╔╗║╔╗║║╔╗║
//──║║─║║─║╚╝║╚╝╚╣╚╝║
//──║║─║║─║╔╗║╔═╗║╔╗║
//──║║─║╚═╣║║║╚═╝║║║║
//──╚╝─╚══╩╝╚╩═══╩╝╚╝
//╔════╦══╦══╦╗╔══╗─╔╗
//╚═╗╔═╣╔╗║╔═╣║║╔═╝╔╝║
//──║║─║╚╝║╚═╣╚╝║──╚╗║
//──║║─║╔╗╠═╗║╔╗║───║║
//──║║─║║║╠═╝║║║╚═╗─║║
//──╚╝─╚╝╚╩══╩╝╚══╝─╚╝

namespace Task_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] mas1 = fill();

            String fileName1 = "sourse.txt";
            String fileName2 = "result.txt";

            //─╔╗─╔══╦════╦═══╦═══╗
            //╔╝║─║╔═╩═╗╔═╣╔══╣╔═╗║
            //╚╗║─║╚═╗─║║─║╚══╣╚═╝║
            //─║║─╚═╗║─║║─║╔══╣╔══╝
            //─║║─╔═╝║─║║─║╚══╣║
            //─╚╝─╚══╝─╚╝─╚═══╩╝
            #region step1

            //создание исходного массива и запись в файл
            FileStream file = new FileStream(fileName1, FileMode.Create, FileAccess.Write);
            StreamWriter writer = new StreamWriter(file);

            foreach (int data in mas1)
            {
                writer.Write(data + " ");
            }

            writer.Close();
            file.Close();
            #endregion

            //╔══╗─╔══╦════╦═══╦═══╗
            //╚═╗║─║╔═╩═╗╔═╣╔══╣╔═╗║
            //╔═╝║─║╚═╗─║║─║╚══╣╚═╝║
            //║╔═╝─╚═╗║─║║─║╔══╣╔══╝
            //║╚═╗─╔═╝║─║║─║╚══╣║
            //╚══╝─╚══╝─╚╝─╚═══╩╝
            #region step2

            //считывание из файла исходного массива
            file = new FileStream(fileName1, FileMode.Open, FileAccess.Read);
            StreamReader reader = new StreamReader(file);

            String s = reader.ReadLine();
            char[] a = { ' ' };
            String[] arr = s.Split(a, StringSplitOptions.RemoveEmptyEntries);

            int[] mas2 = new int[arr.Length];

            for (int i = 0; i < mas2.Length; i++)
            {
                mas2[i] = Convert.ToInt32(arr[i]);
            }

            print(mas2);

            reader.Close();
            file.Close();
            #endregion

            //╔══╗─╔══╦════╦═══╦═══╗
            //╚═╗║─║╔═╩═╗╔═╣╔══╣╔═╗║
            //╔═╝║─║╚═╗─║║─║╚══╣╚═╝║
            //╚═╗║─╚═╗║─║║─║╔══╣╔══╝
            //╔═╝║─╔═╝║─║║─║╚══╣║
            //╚══╝─╚══╝─╚╝─╚═══╩╝
            #region step3

            int size = 1;

            //выделение памяти под новый массив
            for (int i = 1; i < mas2.Length; i++)
            {
                bool sign = mas2[i] * mas2[i - 1] < 0;
                bool zero = mas2[i] * mas2[i - 1] == 0 && mas2[i] != mas2[i-1];
                if (sign || zero) size++;
            }

            //Console.WriteLine("Size = {0}", size);

            int[] mas3 = new int[size];
            mas3[0] = mas2[0];

            int it = 0;

            //переписываение исходного массива в новый
            for (int i = 1; i < mas2.Length; i++)
            {
                if (mas2[i] * mas2[i - 1] > 0)
                {
                    mas3[it] += mas2[i];
                }
                else if(mas2[i] == 0)
                {
                    if (mas2[i - 1] != 0)
                    {
                        it++;
                        mas3[it] = 0;
                    }
                    else continue;
                }
                else
                {
                    it++;
                    mas3[it] += mas2[i];
                }
            }

            print(mas3);

            //запись в файл нового массива
            file = new FileStream(fileName2, FileMode.Create, FileAccess.Write);
            writer = new StreamWriter(file);

            foreach (int data in mas3)
            {
                writer.Write(data + " ");
            }

            writer.Close();
            file.Close();
            #endregion
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
