using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise4
{
    class Dogs
    {
        public void Jack()
        {
            Animals napoleon = new Animals("Jack");
            napoleon.Speak("Jack", "Dog", "Woof");
            napoleon.Food("milk treats");
        }
        public void Alex()
        {
            Animals napoleon = new Animals("Alex");
            napoleon.Speak("Alex", "Dog", "Woof");
            napoleon.Food("steak");
        }
        public void Cerberus()
        {
            Animals napoleon = new Animals("Cerberus");
            napoleon.Speak("Cerberus", "Guard Dog of Hell", "Grrrr");
            napoleon.Food("spirit bones");
        }
        public void Amaterasu()
        {
            Animals napoleon = new Animals("Amaterasu");
            napoleon.Speak("Amaterasu", "Deity-God", "Howl");
            napoleon.Food("monster bones");
        }

    }
}
