using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int day, month;

            Console.Write("Input number of current day: ");
            int currentDay = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input number of current month: ");
            int currentMonth = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input count of last days: ");
            int countOfDays = Convert.ToInt32(Console.ReadLine());

            int date = (currentMonth - 1) * 31 + currentDay;
            date -= countOfDays;

            if(date < 0) date += 360;

            month = date / 31;
            day = date % 31;

            if(day == 0)
            {
                day = 31;
                month--;
                if (month < 0)
                    month += 12;
            }

            Console.Write("\nYour date: {0} ", day);

            switch (month)
            {
                case 0: Console.WriteLine("January"); break;
                case 1: Console.WriteLine("February"); break;
                case 2: Console.WriteLine("March"); break;
                case 3: Console.WriteLine("April"); break;
                case 4: Console.WriteLine("May"); break;
                case 5: Console.WriteLine("June"); break;
                case 6: Console.WriteLine("July"); break;
                case 7: Console.WriteLine("August"); break;
                case 8: Console.WriteLine("September"); break;
                case 9: Console.WriteLine("October"); break;
                case 10: Console.WriteLine("November"); break;
                case 11: Console.WriteLine("December"); break;
                default: Console.WriteLine("Error: This month isn't exist!"); break;
            }

            Console.WriteLine("Для продолжения нажмите любую клавишу...");
            Console.ReadKey();
        }
    }
}
