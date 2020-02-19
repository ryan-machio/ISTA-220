using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise4
{
    class Horses
    {
        public void Harold()
        {
            Animals harold = new Animals("Harold");
            harold.Speak("Harold", "Horse", "Neigh");
            harold.Food("carrots");
        }
        public void Harry()
        {
            Animals vato = new Animals("Harry");
            vato.Speak("Harry", "Horse", "Neigh");
            vato.Food("hay");
        }
        public void Venus()
        {
            Animals vato = new Animals("Venus");
            vato.Speak("Venus", "Horse", "Neigh");
            vato.Food("bananas");
        }
        public void Neptune()
        {
            Animals vato = new Animals("Neptune");
            vato.Speak("Neptune", "Horse", "Neigh");
            vato.Food("apples");
        }
    }
}
