using System;

namespace ParsowanieDanych
{
    class Program
    {
        static void Main(string[] args)
        {
            var someInt = 5;
            someInt.ToString();

            var isSucceded = DateTime.TryParse(Console.ReadLine(), out var result);

            if (isSucceded)
            {
                Console.WriteLine(result);
            }
            else
            {
                Console.WriteLine("Format was wrong, try again");
            }

        }
    }
}
