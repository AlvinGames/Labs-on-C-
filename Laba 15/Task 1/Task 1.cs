using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = ReadFromFile("text.txt");

            if(!string.IsNullOrEmpty(str))
            {
                Console.WriteLine($"Result = {result(str)}");
            }

            Console.ReadKey();
        }

        static string ReadFromFile(string fileName)
        {
            if (File.Exists(fileName))
            {
                FileStream file = new FileStream(fileName, FileMode.Open, FileAccess.Read);
                StreamReader reader = new StreamReader(file);

                string str = reader.ReadLine();

                reader.Close();
                file.Close();

                return str;
            }
            else
            {
                File.Create(fileName);
            }
            return null;
        }

        static int result(string str)
        {
            const int max = 0;
            const int min = 1;

            Stack<int> stc = new Stack<int>();
            Char[] buf = new Char[100];

            char[] simbol = str.ToCharArray();

            for (int i = 0; i < simbol.Length; i++)
            {
                if (simbol[i] == 'M') { stc.Push(max); continue; }
                if (simbol[i] == 'm') { stc.Push(min); continue; }
                if (isDigit(simbol[i]))
                {
                    int j = 0;
                    while (isDigit(simbol[i])) buf[j++] = simbol[i++];

                    buf[j] = ' ';
                    stc.Push(ToInt32(buf));
                }

                if (str[i] == ')')
                {
                    int b = stc.Pop();
                    int a = stc.Pop();
                    int func = stc.Pop();

                    if (func == max) stc.Push(a > b ? a : b);
                    else stc.Push(a < b ? a : b);
                }
            }

            return stc.Pop();
        }

        static int ToInt32(char[] mas)
        {
            return Convert.ToInt32(new String(mas));
        }

        static bool isDigit(char simbol)
        {
            for (char i = '0'; i <= '9'; i++)
            {
                if (simbol == i) return true;
            }
            return false;
        }
    }
}
