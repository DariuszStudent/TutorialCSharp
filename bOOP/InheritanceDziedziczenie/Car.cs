using System;

namespace InheritanceDziedziczenie
{
    public abstract class Car
    {
        public abstract string Name { get;}
        public int WheelSize { get; private set; }
        public int TopSpeed { get; set; }
        public int Length { get; set; }

        public Car(int topSpeed)
        {
            TopSpeed = topSpeed;

            Console.WriteLine("I am car construtor.");
        }

        public abstract void Drive();
    }
}
