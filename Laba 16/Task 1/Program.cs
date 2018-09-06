using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1
{
    struct Pair
    {
        public int min;
        public int max;
    }

    class Program
    {
        static void Main(string[] args)
        {
            Interface();
        }

        static void Interface()
        {
            if (!Game.LoadResources("resources.txt"))
            {
                Console.WriteLine("The resources are not found");
                return;
            }

            while (true)
            {
                Console.Clear();

                Console.WriteLine("Welcom to the Game\n");

                Game.PrintContents();

                Console.WriteLine("(sn) sort ammunition by name");
                Console.WriteLine("(sp) sort ammunition by price");
                Console.WriteLine("(sw) sort ammunition by Weight");
                Console.WriteLine("(ek) equip the knight");

                string command = Console.ReadLine();

                if (command == "sn")
                {
                    Game.SortByName();
                }
                else if (command == "sp")
                {
                    Game.SortByPrice();
                }
                else if (command == "sw")
                {
                    Game.SortByWeight();
                }
                else if (command == "ek")
                {
                    Equipment();
                }
                else if (command == "exit") break;
                else
                {
                    Console.WriteLine("Unknown command (press any key to continue)");
                    Console.ReadKey();
                    continue;
                }
            }
        }

        static void Equipment()
        {
            while (true)
            {
                Console.Clear();

                Console.WriteLine("Equipment of knight\n");

                Game.PrintContents();
                Knight player = Game.player;
                player.Print();
                Console.WriteLine();

                Console.WriteLine("(sa) search of ammunitions");
                Console.WriteLine("(sla) select of ammunition");

                string command = Console.ReadLine();

                if (command == "sa")
                {
                    Game.SearchAmmunition(MinMax());
                    Console.WriteLine("press any key to continue");
                    Console.ReadKey();
                }
                else if (command == "sla")
                {
                    Console.Clear();

                    Game.PrintContents();
                    player.Print();
                    Console.WriteLine();

                    string name = NameOfAmmunition();

                    foreach (Ammunition item in Game.resources)
                    {
                        if (item.Name == name)
                        {
                            if (player.Money >= item.Price)
                            {
                                if (player.AddAmunition(item))
                                {
                                    player.Money -= item.Price;
                                    player.TotalCost += item.Price;
                                }
                                else Console.WriteLine("Slots under ammunition have ended");
                            }
                            else
                            {
                                Console.WriteLine("There isn't enough money for purchase");
                            }
                        }
                    }
                }
                else if (command == "exit") break;
                else
                {
                    Console.WriteLine("Unknown command (press any key to continue)");
                    Console.ReadKey();
                }
            }
        }

        static string NameOfAmmunition()
        {
            Console.WriteLine("Input name of ammunition");

            bool isCorrect;
            string name;

            do
            {
                isCorrect = true;
                name = Console.ReadLine();

                foreach (Ammunition item in Game.resources)
                {
                    if (item.Name == name)
                    {
                        isCorrect = true;
                        break;
                    }
                    else isCorrect = false;
                }

                if (!isCorrect)
                {
                    Console.Clear();
                    Game.PrintContents();
                    Console.WriteLine($"This ammunition is not exists, try again");
                }
                if (name.Length == 0)
                {
                    Console.Clear();
                    isCorrect = false;
                    Game.PrintContents();
                    Console.WriteLine("You must input correct name of ammunition, try again");
                }
                if (name == "exit") break;

            } while (!isCorrect);

            return name;
        }

        static Pair MinMax()
        {
            Console.Clear();

            Pair val;
            val.min = 0;
            val.max = 0;

            bool isCorrectMin = true;
            bool isCorrectMax = true;

            Console.WriteLine("Input minimum value of price");
            do
            {
                if (!isCorrectMin)
                {
                    Console.Clear();
                    Console.WriteLine("minimum alue of price has to be more than zero");
                }
                isCorrectMin = true;
                input(out val.min);
                if (val.min < 0) isCorrectMin = false;

            } while (!isCorrectMin);

            Console.Clear();

            Console.WriteLine("Input maximum value of price");
            do
            {
                if (!isCorrectMax)
                {
                    Console.Clear();
                    Console.WriteLine("maximum value of price has to be more than minimum value of price");
                }
                isCorrectMax = true;
                input(out val.max);
                if (val.max <= val.min) isCorrectMax = false;

            } while (!isCorrectMax);

            return val;
        }

        static void input(out int number)
        {
            bool Number = true;

            do
            {
                if (!Number) { Console.Clear(); Console.Write("It's not a number, try again: "); }
                Number = int.TryParse(Console.ReadLine(), out number);
            } while (!Number);
        }
    }
}
