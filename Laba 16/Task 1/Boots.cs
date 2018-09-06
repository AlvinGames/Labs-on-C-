using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1
{
    class Boots : Ammunition
    {
        public Boots(string Name, int Price, int Weight, int Speed) : base(Name, Price, Weight)
        {
            this.Speed = Speed;
        }

        public override void Information()
        {
            base.Information();
            Console.WriteLine($"Speed {Speed}");
        }

        public int Speed { get; private set; }
    }
}
