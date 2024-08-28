namespace Exercise7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your random text here");
            string text = Console.ReadLine();

            int count = 0;

            for (int i = 0; i < text.Length; i++)
            {
                if (char.IsUpper(text[i])) count++;
            }

            Console.WriteLine("The number of Upper case letters are:");
            Console.WriteLine(count);
        }
    }
}

