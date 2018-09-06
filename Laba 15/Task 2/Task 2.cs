using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    static class Program
    {
        static void Main(string[] args)
        {
            string fileName = "text.txt";

            if(File.Exists(fileName))
            {
                Queue<string> upper = new Queue<string>();
                Queue<string> lower = new Queue<string>();

                ReadFromFile(fileName, upper, lower);

                upper.Print();

                Console.WriteLine();

                lower.Print();
            }
            else
            {
                File.Create(fileName);
                Console.WriteLine($"File {fileName} is not exists");
            }
        }

        static void ReadFromFile(string fileName, Queue<string> upper, Queue<string> lower)
        {
            FileStream file = new FileStream(fileName, FileMode.Open, FileAccess.Read);
            StreamReader reader = new StreamReader(file);

            while (!reader.EndOfStream)
            {
                string temp = reader.ReadLine();
                if (temp.StartUpperSimbol()) upper.Enqueue(temp);
                else if (temp.StartlowerSimbol()) lower.Enqueue(temp);
            }

            reader.Close();
            file.Close();
        }

        public static bool StartUpperSimbol(this string str)
        {
            for (char i = 'A'; i <= 'Z'; i++)
            {
                if (str.StartsWith(i.ToString())) return true;
            }
            return false;
        }

        public static bool StartlowerSimbol(this string str)
        {
            for (char i = 'a'; i <= 'z'; i++)
            {
                if (str.StartsWith(i.ToString())) return true;
            }
            return false;
        }

        static void Print(this Queue<string> que)
        {
            while (que.Count != 0)
            {
                Console.WriteLine(que.Dequeue());
            }
        }
    }
}
