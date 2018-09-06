using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            int countOfLetters = 26;

            Console.WriteLine("Input the message which you want to cipher:");
            String str = Console.ReadLine();

            bool simbol = true;

            for (int i = 0; i < str.Length; i++)
            {
                if (!(Convert.ToInt32(str[i]) >= 97 && Convert.ToInt32(str[i]) <= 123))
                {
                    simbol = false;
                }
            }

            if (simbol)
            {
                Console.Write("Input shift of the cipher: ");
                int shift = int.Parse(Console.ReadLine());

                str = str.ToLower();

                char[] text = str.ToCharArray();

                for (int i = 0; i < text.Length; i++)
                {
                    if (!char.IsPunctuation(text[i]) && text[i] != ' ')
                    {
                        int code = Convert.ToInt32(text[i]) - 96;
                        code += shift;
                        code %= countOfLetters;
                        text[i] = Convert.ToChar(code + 96);
                    }
                }

                String s = new String(text);

                Console.WriteLine("Your text: {0}", s);
            }
            else Console.WriteLine("Text have a numbers!");
        }
    }
}
