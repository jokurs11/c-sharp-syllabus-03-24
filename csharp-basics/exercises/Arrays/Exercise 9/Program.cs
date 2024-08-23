using System;

namespace Exercise9
{
    class Program
    {
        private static void Main(string[] args)
        {
            string[] myArray1 = { "MAX", "HarOLd", "jane" };
            string[] myArray2 = { "KarL", "JOHN", "AnNa", "meridiTh" };
            string[] myArray3 = { "georGIA", "hannah", "calvin", "peter" };

            ChangeArray(myArray1);
            ChangeArray(myArray2);
            ChangeArray(myArray3);
        }

        private static void ChangeArray(string[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i].Length > 0)
                {
                    arr[i] = char.ToUpper(arr[i][0]) + arr[i].Substring(1).ToLower();
                }
            }

            Console.WriteLine("Returned array: " + string.Join(", ", arr));
        }
    }
}