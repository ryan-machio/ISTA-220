using System;


namespace Quiz4
{
    class Firearm
    {
        public void Guns(string weapon, string sound)
        {
            Console.WriteLine($"I am a {weapon} and I go {sound}");
        }


    }
}

using System;

namespace Quiz4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This is test 04");
            Firearm shotgun = new Firearm();
            Firearm pistol = new Firearm();
            Firearm rifle = new Firearm();
            shotgun.Guns("shotgun", "Boom");
            rifle.Guns("rifle,", "Bang");
            pistol.Guns("Pistol", "Pop");

        }

    }
}
