using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise3
{
    class Program
    {
        static void Main(string[] args)
        {
            string str_var;
            double int_varC;
            double radiusCirc;
            double pi;
            double circumferenceCircle;
            double areaCircle;
            bool bError = true;
            Console.WriteLine("Part 1 circumference and area of a circle.");
            Console.WriteLine("Enter an integer for the radius: ");

            do
            {
                try
                {
                    str_var = Console.ReadLine();
                    int_varC = double.Parse(str_var);
                    radiusCirc = int_varC;
                    pi = Math.PI;
                    circumferenceCircle = 2 * pi * radiusCirc;
                    areaCircle = pi * Math.Pow(radiusCirc, 2);
                    if (int_varC < 0)
                    {
                        Console.WriteLine("Your number is out of range.");
                        continue;
                    }
                    Console.WriteLine("Circumference of a circle is: " + circumferenceCircle);
                    Console.WriteLine("Area of a circle is: " + areaCircle);

                    bError = false;
                }
                catch (FormatException)
                {
                    Console.WriteLine("You must enter a valid number.");
                }
                finally
                {
                    Console.WriteLine("Okay");
                }
            } while (bError);
        }
    }
}