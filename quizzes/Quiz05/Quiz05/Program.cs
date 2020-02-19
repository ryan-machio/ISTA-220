using System;

namespace Quiz05
{
    class Program
    {


        static void Main(string[] args)
        {
            Console.WriteLine("This is test 5");
            string s1 = "This is spart a a";
            string[] s2 = s1.Split(' ');
            int len = s2.Length;
            Console.WriteLine($"The test string is {s1}.\n" +
                $"The length of string array is {len}");
            for (int i = len - 1; i >= 0; i--)
                Console.WriteLine(i + " " +  s2[i]);
        }
    }
}
