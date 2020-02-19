using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise4
{
    class Elephants
    {
        public void Dumbo()
        {
            Animals elephantDumbo = new Animals("Dumbo"); //first animal
            elephantDumbo.Speak("Dumbo", "Elephant", "Dawoo");
            elephantDumbo.Food("grass");
        }

        public void Por()
        {
            Animals elephantPor = new Animals("Por");
            elephantPor.Speak("Por", "Elephant", "Pawoo"); //second animal
            elephantPor.Food("peanuts");
        }

        public void Kor()
        {
            Animals elephantKor = new Animals("Kor");
            elephantKor.Speak("Kor", "Elephant", "Kawoo"); //third animal
            elephantKor.Food("almonds");
        }

        public void Tor()
        {
            Animals elephantTor = new Animals("Tor");
            elephantTor.Speak("Tor", "Elephant", "Tawoo"); //fourth animal
            elephantTor.Food("walnuts");
        }
    }
}
