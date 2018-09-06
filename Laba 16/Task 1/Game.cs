using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1
{
    static class Game
    {
        public static bool LoadResources(string fileName)
        {
            if (File.Exists(fileName))
            {
                FileStream file = new FileStream(fileName, FileMode.Open, FileAccess.Read);
                StreamReader reader = new StreamReader(file);

                while (!reader.EndOfStream)
                {
                    string[] data = reader.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                    string ammunition = data[0];

                    string name = data[1];
                    int price = Convert.ToInt32(data[2]);
                    int weight = Convert.ToInt32(data[3]);
                    int effect = Convert.ToInt32(data[4]);

                    if (ammunition == "Boots")
                    {
                        resources.Add(new Boots(name, price, weight, effect));
                    }
                    else if (ammunition == "Cuirass")
                    {
                        resources.Add(new Сuirass(name, price, weight, effect));
                    }
                    else if (ammunition == "Helmet")
                    {
                        resources.Add(new Helmet(name, price, weight, effect));
                    }
                    else if (ammunition == "Shield")
                    {
                        resources.Add(new Shield(name, price, weight, effect));
                    }
                    else if (ammunition == "Sword")
                    {
                        resources.Add(new Sword(name, price, weight, effect));
                    }
                    else
                    {
                        Console.WriteLine("Unknown resource");
                    }
                }

                reader.Close();
                file.Close();

                return true;
            }
            File.Create(fileName);
            return false;
        }

        public static bool SortByName()
        {
            if (resources.Count != 0)
            {
                resources = resources.OrderBy(ammunition => ammunition.Name).ToList();
                return true;
            }
            return false;
        }
        public static bool SortByPrice()
        {
            if (resources.Count != 0)
            {
                resources = resources.OrderBy(ammunition => ammunition.Price).ToList();
                return true;
            }
            return false;
        }
        public static bool SortByWeight()
        {
            if (resources.Count != 0)
            {
                resources = resources.OrderBy(ammunition => ammunition.Weight).ToList();
                return true;
            }
            return false;
        }

        public static bool SearchAmmunition(Pair val)
        {
            if(resources.Count != 0)
            {
                Console.WriteLine("The found ammunition:");
                foreach (Ammunition item in resources)
                {
                    if(item.Price < val.max && item.Price > val.min)
                    {
                        item.Information();
                        Console.WriteLine();
                    }
                }
                return true;
            }
            return false;
        }
        public static bool PrintContents()
        {
            if(resources.Count != 0)
            {
                foreach (Ammunition item in resources)
                {
                    item.Information();
                    Console.WriteLine();
                }
                return true;
            }
            return false;
        }

        public static Knight player = new Knight();
        public static List<Ammunition> resources = new List<Ammunition>();
    }
}
