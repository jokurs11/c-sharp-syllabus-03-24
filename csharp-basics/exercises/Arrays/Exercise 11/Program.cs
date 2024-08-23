using System;

namespace Exercise11
{
    class Program
    {
        private static void Main(string[] args)
        {
            string[] findingNemo = { "I", "am", "finding", "Nemo", "!" };
            bool isThereNemo = false;

            for (int i = 0; i < findingNemo.Length; i++)
            {
                if (findingNemo[i] == "Nemo")
                {
                    isThereNemo = true;
                    Console.WriteLine($"found Nemo at: {i}");
                    break;
                }
            }
            if (!isThereNemo)
            {
                Console.WriteLine("I can't find Nemo :(");
            }
        }
    }
}