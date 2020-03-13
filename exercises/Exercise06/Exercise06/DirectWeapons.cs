using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise06
{
    class DirectWeapons : Weapons
    {
        public override void Weapon( )
        {
            Console.WriteLine("Direct fire weapons in this command are the M16, M4, M249, and M27");
        }

        public override void load()
        {
            Console.WriteLine("The direct fire weapons all load 5.56mm rounds.");
        }
    }
}
