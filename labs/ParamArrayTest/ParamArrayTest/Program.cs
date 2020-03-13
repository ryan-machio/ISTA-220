using System;

namespace ParamArrayTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calling ordinary array");
            int[] arr = { 1, 2 , 3, 4 ,5, 6, 7, 8, 9, 10 };

            int sum1 = Method1(arr);
            int sum2 = Method2(arr);
            Console.WriteLine($"Sum1 is {sum1}");
        }

        private static int Method2(params int[] arr)
        {
            int sum = 0;
            foreach (int i in arr)
                sum += i;
            return sum;
        }

        private static int Method1(int[] array1) //find the sum of an array
        {
            int sum = 0;
            foreach(int i in array1)
                sum = i + sum;

                return sum;
        }
    }
}
