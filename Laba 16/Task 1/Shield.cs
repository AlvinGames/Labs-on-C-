using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1
{
    class Shield : Ammunition
    {
        public Shield(string Name, int Price, int Weight, int Absorption) : base(Name, Price, Weight)
        {
            this.Absorption = Absorption;
        }

        public override void Information()
        {
            base.Information();
            Console.WriteLine($"Absorption: {Absorption}");
        }

        public int Absorption { get; private set; }
    }
}
