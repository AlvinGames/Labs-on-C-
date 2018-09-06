using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input your surname name middle and name:");
            String str = Console.ReadLine();
            str = str.ToLower();

            String[] s = str.Split(' ');

            int code = 0;

            for (int i = 0; i < s.Length; i++)
            {
                char[] simbol = s[i].ToCharArray();
                for (int j = 0; j < simbol.Length; j++)
                {
                    code = code + (Convert.ToInt32(simbol[j]) - 96);
                }
            }

            while(code.ToString().Length > 1)
            {
                int sum = 0;
                while (code > 0)
                {
                    sum += code % 10;
                    code /= 10;
                }
                code = sum;
            }

            Console.WriteLine("Your code: {0}", code);
        }
    }
}
