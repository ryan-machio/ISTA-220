using System;

namespace Quiz3Final
{
    class Program
    {
        private static void Main(string[] args)
        {
            Boolean bError = true;
            do
            {
                Console.WriteLine("To calculate the reciprocal of an integer, enter a positive integer: ");
                string userinp;
                int den;
                int num;
                try
                {
                    userinp = Console.ReadLine();
                    den = int.Parse(userinp);
                    num = 1;a
                    double recip = (num / den);
                    if (den < 0)
                    {
                        Console.WriteLine("You must enter a positive number");
                        continue;
                    }
                    Console.WriteLine("The reciprocal is " + ((double)num / (double)den));
                    bError = false;

                }
                catch (FormatException)
                {
                    Console.WriteLine("Input string was not in a correct format");
                }
                catch (DivideByZeroException)
                {
                    Console.WriteLine("Attempted to divide by zero.");
                }
            } while (bError);
        }
    }
}
