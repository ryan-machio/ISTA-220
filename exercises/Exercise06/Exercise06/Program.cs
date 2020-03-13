using System;

namespace Exercise06
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Overall Personnel from EWTGLANT");

            Supply supply = new Supply();
            supply.BattalionSize();
            supply.Sections();

            Infantry i = new Infantry();
            i.BattalionSize();
            i.Sections();

            Admin a = new Admin();
            a.BattalionSize();
            a.Sections();

            SmallWeapons sw = new SmallWeapons();
            sw.Weapon();
            sw.load();

            DirectWeapons dw = new DirectWeapons();
            dw.Weapon();
            dw.load();
        }
    }
}
