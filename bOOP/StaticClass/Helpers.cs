using System;

namespace StaticClass
{
    public static class Helpers
    {
        public static void JustNumbers()
        {
            var userNumber = default(int);
            while (!int.TryParse(Console.ReadLine(), out userNumber))
            {
                Console.WriteLine("Musisz podać liczbę całkowitą");
            }
        }
    }
}
