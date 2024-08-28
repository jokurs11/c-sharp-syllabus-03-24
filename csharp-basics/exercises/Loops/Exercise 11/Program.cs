using System;

namespace Exercise11
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstSentence = "Happy Birthday";
            string secondSentence = "MANY THANKS";
            string thirdSentence = "sPoNtAnEoUs";

            ReverseCase(firstSentence);
            ReverseCase(secondSentence);
            ReverseCase(thirdSentence);
        }

        private static void ReverseCase(string str)
        {
            char[] letters = str.ToCharArray();
            for (int i = 0; i < letters.Length; i++)
            {
                if (char.IsLetter(letters[i]))
                {
                    letters[i] = char.IsUpper(letters[i]) ? char.ToLower(letters[i]) : char.ToUpper(letters[i]);
                }
            }
            str = new string(letters);

            Console.WriteLine(str);
        }
    }
}