using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise4
{
    public class Pigs : Animals
    {
        public void Vato()
        {
            Animals vato = new Animals("Vato");
            vato.Speak("Vato", "Pig", "Oink");
            vato.Food("distillery waste");
        }

        public void Porky()
        {
            Animals vato = new Animals("Porky");
            vato.Speak("Porky", "Pig", "Oink");
            vato.Food("distillery waste");
        }
        public void MissPeggy()
        {
            Animals misspeggy = new Animals("Miss Peggy");
            misspeggy.Speak("Miss Peggy", "Pig", "Oink");
            misspeggy.Food("distillery waste");
        }
        public void Napoleon()
        {
            Animals napoleon = new Animals("Napoleon");
            napoleon.Speak("Napoleon", "Pig", "Oink");
            napoleon.Food("distillery waste");
        }
    }
}
