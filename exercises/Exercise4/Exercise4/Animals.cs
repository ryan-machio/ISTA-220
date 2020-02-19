using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise4
{
    //Part 1
    public class Animals
    {
        public string name; //instance for name

        public Animals() //default constructor 
        {
        }

        public Animals(string name) //constructor that takes 1 parameter
        {
            this.name = name;
            Console.WriteLine($"The name of this animal is {name}.");
        }

        public string Speak(string name, string breed, string sound) //method to output animal name, breed, and sound
        {
            Console.WriteLine($"I am {name}, I am a(n) {breed}, and the sound I make is {sound}.");
            return name;
        }

        public string Food(string food) //method for animal to say their preferred food
        {
            Console.WriteLine($"I like to eat {food}.\n");
            return food;
        }
    }
}
