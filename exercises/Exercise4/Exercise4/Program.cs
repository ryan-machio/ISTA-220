using System;

namespace Exercise4
{
    public class Program : Animals
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Manch-Ranch, where we have the greatest variety of animals in the UNIVERSE!");
            Animals manchansAnimals = new Animals();
            Console.WriteLine("");

            Elephants elephants = new Elephants();
            elephants.Dumbo();
            elephants.Por();
            elephants.Tor();
            elephants.Kor();

            Pigs pigs = new Pigs();
            pigs.Napoleon();
            pigs.Vato();
            pigs.MissPeggy();
            pigs.Porky();

            Horses horse = new Horses();
            horse.Harold();
            horse.Harry();
            horse.Venus();
            horse.Neptune();

            Dogs dogs = new Dogs();
            dogs.Alex();
            dogs.Amaterasu();
            dogs.Cerberus();
            dogs.Jack();

        }
    }
}
