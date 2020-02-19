using System;

//whatever your namespace is for the Program
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the number of integers to add: ");
            string strNumber = Console.ReadLine();
            int end = Int32.Parse(strNumber);
            int start = 0;
            int sum = 0;
            sum = GetSums(start, end, sum);
            Console.WriteLine($"The sum is { sum}");
        }

        private static int GetSums(int start, int end, int sum)
        {
            if (start <= end)
            {
                Console.WriteLine("The sum of " + start + " and " + sum + " is " + (sum + start));
                sum = start + sum;
                start++;
                return (GetSums(start, end, sum));
            }
            else
            {
                return (sum);
            }
        }
    }
}
