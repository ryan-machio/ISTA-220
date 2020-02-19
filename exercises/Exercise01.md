using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1
{
    class Program
    {
        static void Main(string[] args)
        {
            string str_var;
            double int_varC;
            double radiusCirc;
            double pi = Math.PI;
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
                    Console.WriteLine("\nPart 2, volume of a hemisphere");
                    Console.WriteLine("Enter an integer for the radius: ");
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

            str_var = Console.ReadLine();
            double int_varH = double.Parse(str_var);

            double radiusHem = int_varH;
            double volumeHem = (1.3 * pi * (radiusHem * radiusHem * radiusHem)) / 2;

            Console.WriteLine("The volume of a hemisphere is: " + volumeHem);

            Console.WriteLine("\nPart 3 area of a trinagle (Heron's Formula)" +
                "\n Enter an integer for side a: ");
            str_var = Console.ReadLine();
            double int_a = double.Parse(str_var);

            Console.WriteLine("Enter an integer for side b: ");
            str_var = Console.ReadLine();
            double int_b = double.Parse(str_var);

            Console.WriteLine("Enter an integer for side c: ");
            str_var = Console.ReadLine();
            double int_c = double.Parse(str_var);

            double trianglePerimeter = int_a + int_b + int_c;
            double triangleArea = Math.Sqrt(trianglePerimeter * (trianglePerimeter - int_a) * (trianglePerimeter - int_b) * (trianglePerimeter - int_c));

            Console.WriteLine("The perimeter of a triangle is: " + trianglePerimeter);
            Console.WriteLine("The area of a triangle is: " + triangleArea);

            Console.WriteLine("\nPart 4 solving a quadratic equation");

            Console.WriteLine("Enter an integer for a");
            str_var = Console.ReadLine();
            double int_A = double.Parse(str_var);

            Console.WriteLine("enter an integer for b");
            str_var = Console.ReadLine();
            double int_B = double.Parse(str_var);

            Console.WriteLine("Enter an integer for c");
            str_var = Console.ReadLine();
            double int_C = double.Parse(str_var);

            double fourAC = 4 * int_A * int_C;
            double int_XPOS = (-int_B + ((Math.Sqrt(Math.Pow(int_B, 2) - fourAC)))) / (2 * int_A);
            double int_XNEG = (-int_B - ((Math.Sqrt(Math.Pow(int_B, 2)) - (4 * int_A * int_C)))) / (2 * int_A);
            Console.WriteLine("The positive solution is: " + int_XPOS);
            Console.WriteLine("The negative solution is: " + int_XNEG);
        }
    }
}
