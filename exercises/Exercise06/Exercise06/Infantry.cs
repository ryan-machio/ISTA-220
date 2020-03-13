using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise06
{
    class Infantry : Personnel
    {
        public override void BattalionSize()
        {
            Console.WriteLine($"The total personnel in the Infantry is 200 personnel.");
        }

        public override void Sections()
        {
            Console.WriteLine("Individual sections in the Infantry Battalion are the rifle squad and mortars.");
        }
    }
}
