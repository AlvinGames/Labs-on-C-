using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int currentDay, currentMonth, year;
            int cDays = 30;

            Console.WriteLine("Input current date:");
            Console.Write("Day: ");
            input(out currentDay);
            Console.Write("Month: ");
            input(out currentMonth);
            Console.Write("Year: ");
            input(out year);

            //1
            int Bday = (currentMonth - 1) * cDays + currentDay;
            Console.WriteLine("\n{0} days have passed since the beginning of year", Bday);

            //2
            int Eday = 12 * cDays - Bday;
            Console.WriteLine("{0} days remained until the end of the year", Eday);

            //3
            int pMonth = currentMonth;
            int previous = currentDay - 1;
            if(previous < 1)
            {
                previous = cDays;
                pMonth--;
            }
            Console.WriteLine("\nPrevious date: {0}.{1}.{2}", previous, pMonth, year);

            //4
            int lMonth = currentMonth;
            int last = currentDay + 1;
            if(last > 30)
            {
                last = 1;
                lMonth++;
            }
            Console.WriteLine("Last date: {0}.{1}.{2}", last, lMonth, year);

            Console.Write("Для продолжения нажмите любую клавишу...");
            Console.ReadKey();
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
    }
}
