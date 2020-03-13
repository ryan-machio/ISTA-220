using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise06
{
    class Supply : Personnel
    {
        public override void BattalionSize()
        {
            Console.WriteLine($"The total personnel in Supply is 200 personnel.");
        }

        public override void Sections()
        {
            Console.WriteLine("Individual sections in the Supply Battalion are motor transport," +
                "warehouse, and armory.");
        }
    }
}
