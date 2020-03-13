using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise06
{
    class Admin : Personnel
    {
        public override void BattalionSize()
        {
            Console.WriteLine($"The total personnel in Admin is 200 personnel.");
        }

        public override void Sections()
        {
            Console.WriteLine("Individual sections in the Supply Battalion are the Personnel Administration Center, DTS," +
                "S1, and processing.");
        }
    }
}
