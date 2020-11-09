using System;
using System.Collections.Generic;
using System.Text;

namespace testing
{
    class Mens
    {
        private int leeftijd = 1;

        public void VerjaardagVieren()
        {
            Console.WriteLine("Hiphip hoera voor mezelf!");
            leeftijd++;
            Praat();
        }

        public void Praat()
        {
            Console.WriteLine("Ik ben een mens! ");
            Console.WriteLine($"Ik ben {leeftijd} jaar oud");
        }
        public Mens()
        {
            Console.WriteLine("Please Shut Up");
        }
    }
}
