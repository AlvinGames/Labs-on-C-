using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1
{
    class Sword : Ammunition
    {
        public Sword(string Name, int Price, int Weight, int Power) : base(Name, Price, Weight)
        {
            this.Power = Power;
        }

        public override void Information()
        {
            base.Information();
            Console.WriteLine($"Power: {Power}");
        }

        public int Power { get; private set; }
    }
}
