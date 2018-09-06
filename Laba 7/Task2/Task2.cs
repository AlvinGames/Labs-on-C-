using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input the string:");
            StringBuilder str1 = new StringBuilder(Console.ReadLine());

            for (int i = 0; i < str1.Length;)
                if (char.IsPunctuation(str1[i])) str1.Remove(i, 1);
                else i++;

            String str2 = str1.ToString();
            str2 = str2.Trim();
            str2 = str2.ToLower();

            String[] s = str2.Split(' ');

            bool isRepeated;
            Console.Write(s[0]);
            for (int i = 1; i < s.Length; i++)
            {
                isRepeated = false;
                for (int j = 0; j < i; j++)
                {
                    if (s[i] == s[j]) isRepeated = true;
                }
                if (!isRepeated) Console.Write(" {0}", s[i]);
            }

            Console.WriteLine();
        }
    }
}
