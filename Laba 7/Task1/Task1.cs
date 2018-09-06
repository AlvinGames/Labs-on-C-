using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input the string:");
            String str = Console.ReadLine();
            
            Console.Write("Input the simbol: ");
            char x = Convert.ToChar(Console.Read());

            String temp1 = x.ToString();
            String temp2 = "";
            temp2 += temp1 + temp1;

            str = str.Replace(temp1, temp2);

            Console.WriteLine("The final string: {0}", str);
        }
    }
}
