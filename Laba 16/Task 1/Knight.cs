using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1
{
    class Knight
    {
        public Knight() : this(100, 150, 2000)
        {
        }
        public Knight(int Health, int Mana, int Money)
        {
            this.Health = Health;
            this.Mana = Mana;
            this.Money = 2000;

            index = 0;
        }

        public void Print()
        {
            Console.WriteLine("Player:");
            Console.WriteLine($"Healt: {Health}");
            Console.WriteLine($"Mana {Mana}");
            Console.WriteLine($"Money {Money}$");
            Console.WriteLine("Ammunition:");
            if (inventory.Count != 0)
            {
                foreach (Ammunition item in inventory)
                {
                    Console.WriteLine(item.Name);
                }
            }
            else Console.WriteLine("Empty");
            Console.WriteLine($"Total cost: {TotalCost}");
        }
        public bool AddAmunition(Ammunition item)
        {
            if (index <= 5)
            {
                inventory.Add(item);
                index++;
                return true;
            }
            return false;
        }

        public int Health { get; private set; }
        public int Mana { get; private set; }
        public int Money { get; set; }
        public int TotalCost { get; set; }

        private int index;
        private List<Ammunition> inventory = new List<Ammunition>();
    }
}
