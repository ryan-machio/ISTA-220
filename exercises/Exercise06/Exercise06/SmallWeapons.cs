using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise06
{
    class SmallWeapons : Weapons
    {
        public override void Weapon()
        {
            Console.WriteLine("The available small fires weapon is the M9.");
        }

        public override void load()
        {
            Console.WriteLine("The M9 loads 9mm rounds.");
        }
    }
}
