using System;

namespace Exercise10
{
    class Program
    {
        private static void Main(string[] args)
        {
            int[] numArray1 =
            {
                1, 2, 3, 4, 5,
                6, 7, 8, 9, 10, -11,
                -12, -13, -14, -15
            };
            int[] numArray2 =
            {
                92, 6, 73, -77,
                81, -90, 99, 8,
                -85, 34
            };

            ChangeArray(numArray1);
            ChangeArray(numArray2);
        }

        private static void ChangeArray(int[] arr)
        {
            int negativeSum = 0;
            int positiveCount = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] < 0)
                {
                    negativeSum += arr[i];
                }
                if (arr[i] > 0)
                {
                    positiveCount++;
                }
            }

            Console.WriteLine("This is the array: " + string.Join(", ", arr));
            Console.WriteLine("This is the negative sum of the array: " + string.Join(", ", negativeSum));
            Console.WriteLine("This is the positive count of the array: " + string.Join(", ", positiveCount));
            Console.WriteLine(" ");
        }
    }
}