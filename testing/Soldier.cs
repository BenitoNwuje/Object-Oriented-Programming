using System;
using System.Collections.Generic;
using System.Text;

namespace testing
{
    class Vliegtuig
    {
        public virtual void Vlieg()
        {
            Console.WriteLine("Het vliegtuig vliegt rustig door de wolken.");
        }
    }

    class Raket : Vliegtuig
    {
        public override void Vlieg()
        {
            Console.WriteLine("De raket verdwijnt in de ruimte.");
        }
    }

}
