using System;

namespace Exercise05
{
    class Program
    {

        public static void Main(string[] args)
        {
            int[] arrayAlpha = { 0, 2, 4, 6, 8, 10 };
            int[] arrayBravo = { 1, 3, 5, 7, 9 };
            int[] arrayCharlie = { 3, 1, 4, 1, 5, 9, 2, 6, 5, 3, 5, 9 };

            Console.WriteLine("Arrays");
            PrintArray(arrayAlpha, arrayAlpha.Length);
            PrintArray(arrayBravo, arrayBravo.Length);
            PrintArray(arrayCharlie, arrayCharlie.Length);

            Console.WriteLine("Part 1: count, sum, and average arrays.");
            SumAndAverage(arrayAlpha);
            SumAndAverage(arrayBravo);
            SumAndAverage(arrayCharlie);

            Console.WriteLine("Part 2: reversed arrays.");
            ReversedArrays(arrayAlpha, 0, arrayAlpha.Length);
            ReversedArrays(arrayBravo, 0, arrayBravo.Length);
            ReversedArrays(arrayCharlie, 0, arrayCharlie.Length);

            Console.WriteLine("Part 3: rotate arrays.");

            LeftRotation(arrayAlpha, arrayAlpha.Length, 2);
            PrintArray(arrayAlpha, arrayAlpha.Length);

            RightRotation(arrayBravo, arrayBravo.Length, 2);
            PrintArray(arrayBravo, arrayBravo.Length);

            LeftRotation(arrayCharlie, arrayCharlie.Length, 4);
            PrintArray(arrayCharlie, arrayCharlie.Length);

            Console.WriteLine("Part 4: sort array C.");
            Sort(arrayCharlie);
            PrintArray(arrayCharlie, arrayCharlie.Length);

        }


        public static void PrintArray(int[] array, int len)
        {
            for (int i = 0; i < len; i++)
                Console.Write(array[i] + " ");

            Console.WriteLine();
        }

        public static void SumAndAverage(int[] array)
        {
            int sum = 0;
            int len = array.Length;
            Console.WriteLine($"Number of elements: {len}");

            for (int i = 0; i < array.Length; i++)
            {
                sum += array[i];
                if (i + 1 == len)
                {
                    Console.WriteLine($"Sum is: {sum}.  The mean is: {(double)sum / (double)len}");
                }
            }
        }

        public static void ReversedArrays(int[] array, int start, int end)
        {
            int len = array.Length;

            for (int i = 0; i < array.Length / 2; i++)
            {
                int tmp = array[i];
                array[i] = array[array.Length - i - 1];
                array[array.Length - i - 1] = tmp;
            }

            for (int i = 0; i < len; i++)
                Console.Write(array[i] + " ");

            for (int i = 0; i < array.Length / 2; i++)
            {
                int tmp = array[i];
                array[i] = array[array.Length - i - 1];
                array[array.Length - i - 1] = tmp;
            }

            Console.WriteLine();
        }

        public static void RightRotation(int[] array, int n, int k)
        {
            for (int i = 0; i < k; i++)
            {
                int temp = array[array.Length - 1];
                for (int j = array.Length - 2; j >= 0; j--)
                {
                    array[j + 1] = array[j];
                }

                array[0] = temp;
            }
        }

        private static void LeftRotation(int[] array, int n, int k)
        {
            for (int i = 0; i < k; i++)
            {
                int temp = array[0];
                for (int j = 1; j < n; j++)
                {
                    array[j - 1] = array[j];
                }

                array[n - 1] = temp;
            }
        }

        private static void Sort(int[] array)
        {
            int n = array.Length;
            for (int i = 0; i < n - 1; i++)
                for (int j = 0; j < n - i - 1; j++)
                    if (array[j] > array[j + 1])
                    {
                        // swap temp and arr[i]
                        int temp = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = temp;
                    }
        }
    }
}
