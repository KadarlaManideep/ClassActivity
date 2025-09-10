namespace ClassActivity
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a sentence");
            string sentence = Console.ReadLine();

            int lettercount = 0;
            foreach (char c in sentence)
            {
                if (char.IsLetter(c))
                {
                    lettercount++;
                }
            }

            Console.WriteLine($"Number of letters in the sentence: {lettercount}");
        }
    }
}
