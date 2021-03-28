using System;

namespace Dodatek
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }

    public abstract class SomeClass
    {
        public abstract void SomeFunction()              // zmuszamy klasy dziedziczące po tej klasie do użycia tego kodu!
        {
            Console.WriteLine("Coś się dzieje");        // tylko że nie możemy nic tu dodać bo jest błąd
        }

        public virtual void SomeFunctionnnnnnn()
        {
            Console.WriteLine("Dzięki słówku virtual to tutaj działa !!! zasada jak przy abstract, ale od razu można coś dodać.");
        }
    }
}
