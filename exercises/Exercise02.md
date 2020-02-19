using System;

namespace Exercise2
{
    class Program
    {
        static void Main(string[] args)
        {
            GetSum(0, 10, 0);

            // Console.WriteLine("Part 1: Sum 10 scores");
            //AvgTenTestScores(0, 0);

            // Console.WriteLine("Part 2: User input averages");
            //Console.WriteLine("Enter the amount of tests you want to calculate: ");
            //string str = Console.ReadLine();
            //int tests = int.Parse(str);
            //AvgSpecNumbOfScores(0, tests, 0);

            //Console.WriteLine("Part 3: Non-specific Number of Scores");
            //AvgNonSpecNumOfTestScores(0, 0);

            Console.WriteLine("Part 4: Fibonacci Numbers");
            FibonacciNumbers(0, 1, 0, 10);


        }

        private static int GetSum(int start, int end, int sum)
        {
            Console.WriteLine($"The sum is {sum}");
            start++;
            sum += start;
            if (start < end)
            {
                return GetSum(start, end, sum);

            }
            else
            {
                return sum;
            }
        }

        public static String LetterGrade(double grade) // method to assign values to letters as grades.
        {
            String a = "A";
            String b = "B";
            String c = "C";
            String d = "D";
            String f = "F";
            if (grade <= 100 && grade >= 90)
            {
                return a;
            }
            else if (grade < 90 && grade >= 80)
            {
                return b;
            }
            else if (grade < 80 && grade >= 70)
            {
                return c;
            }
            else if (grade < 70 && grade >= 60)
            {
                return d;
            }
            else if (grade < 60)
            {
                return f;
            }
            else
            {
                return ("Invalid input.");
            }
        }

        public static double AvgTenTestScores(double i, double sum) //method to calculate the average of 10 test scores
        {
            i++;
            Console.WriteLine("Enter a test score: ");
            string str = Console.ReadLine();
            double nextTest = double.Parse(str);
            sum += nextTest;

            if (i <= 10)
            {
                return AvgTenTestScores(i, sum);
            }
            else
            {
                Console.WriteLine($"The total of 10 test scores is {sum}.  The average of 10 test scores is {sum / 10}.  The average letter grade is {LetterGrade(sum / 10)}");
                return i;
            }

        }
        public static double AvgSpecNumbOfScores(double i, double tests, double sum) //method to calculate any limit of test scores
        {
            i++;
            Console.WriteLine("Enter a test score: ");
            string str = Console.ReadLine();
            double nextTest = double.Parse(str);
            sum += nextTest;

            if (i < tests)
            {
                return AvgSpecNumbOfScores(i, tests, sum);
            }
            else
            {
                Console.WriteLine($"The total of {tests} test scores is {sum}.  The average of {tests} test scores is {sum / tests}.  The average letter grade is {LetterGrade(sum / tests)}.");
                return sum;
            }

        }

        public static double AvgNonSpecNumOfTestScores(double i, double sum) //method to calculate any limit of test scores
        {
            i++;
            Console.WriteLine($"Enter a test score, -1 to stop: ");
            string str = Console.ReadLine();
            double nextTest = double.Parse(str);
            sum += nextTest;

            if (nextTest > -1)
            {
                return AvgNonSpecNumOfTestScores(i, sum);
            }
            else
            {
                i--;
                sum = sum + 1;
                Console.WriteLine($"The total of {i} test scores is {sum}.  The average of {i} test scores is {sum / i}.  The average letter grade is {LetterGrade(sum / i)}.");
                return sum;
            }


        }

        public static int FibonacciNumbers(int lastNumber, int nextNumber, int i, int fibonacciNumber) // Method used to determine a Fibonacci number of 40.
        {
            if (i < fibonacciNumber)
            {
                int sum = lastNumber + nextNumber;
                Console.WriteLine($"{lastNumber} + {nextNumber} = {sum}");
                nextNumber = lastNumber;
                lastNumber = sum;
                i++;
                return FibonacciNumbers(lastNumber, nextNumber, i, fibonacciNumber);
            }
            else
            {
                Console.WriteLine($"Phi is: {(double)lastNumber / (double)nextNumber}");
                return fibonacciNumber;
            }
        }
    }
}