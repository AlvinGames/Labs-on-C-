using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1
{
    abstract class Ammunition
    {
        public Ammunition(string Name, int Price, int Weight)
        {
            this.Name = Name;
            this.Price = Price;
            this.Weight = Weight;
        }

        public virtual void Information()
        {
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Price: {Price}");
            Console.WriteLine($"Weight: {Weight}");
        }

        public string Name { get; private set; }
        public int Price { get; private set; }
        public int Weight { get; private set; }
    }
}
