using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1
{
    class Сuirass : Ammunition
    {
        public Сuirass(string Name, int Price, int Weight, int Protection) : base(Name, Price, Weight)
        {
            this.Protection = Protection;
        }

        public override void Information()
        {
            base.Information();
            Console.WriteLine($"Protection: {Protection}");
        }

        public int Protection { get; private set; }
    }
}
