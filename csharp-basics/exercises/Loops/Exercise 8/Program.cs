using System;

namespace Exercise8
{
    class AsciiFigure
    {
        private const int BaseWidth = 4;
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the figure size:");
            int figureSize = Convert.ToInt32(Console.ReadLine());
            int lineLength = BaseWidth * (figureSize - 1);

            for (int i = 0; i < figureSize; i++)
            {
                int slashCount = 2 * (figureSize - 1 - i);
                int starCount = lineLength - 2 * slashCount;

                for (int j = 0; j < slashCount; j++)
                {
                    Console.Write("//");
                }

                for (int j = 0; j < starCount; j++)
                {
                    Console.Write("**");
                }

                for (int j = 0; j < slashCount; j++)
                {
                    Console.Write("\\\\");
                }

                Console.WriteLine();
            }
        }
    }
}