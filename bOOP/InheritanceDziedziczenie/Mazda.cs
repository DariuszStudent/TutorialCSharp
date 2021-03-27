using System;

namespace InheritanceDziedziczenie
{
    public class Mazda : Car
    {
        public override string Name => "Mazda";

        public Mazda(int topSpeed) : base(topSpeed)
        {
            Console.WriteLine("I am porshe constructor");
        }

        public override void Drive()
        {
            
        }

        public void SomeFunctionSpecificMazda()
        {

        }
    }
}
