using System;

namespace KlasyGeneryczne
{
    class Program
    {
        static void Main(string[] args)
        {
            var someClass = new MyClass<int>();    // <double> zmieniamy typy na bierząco, super rzecz! :)

            var listOfInts = new MyList<int>();

            listOfInts.AddmObjects(10);
            listOfInts.AddmObjects(20);
            listOfInts.AddmObjects(30);
            listOfInts.AddmObjects(40);
            listOfInts.AddmObjects(50);

            var listOfStrings = new MyList<string>();

            listOfStrings.AddmObjects("A");
            listOfStrings.AddmObjects("B");
            listOfStrings.AddmObjects("C");
            listOfStrings.AddmObjects("D");
            listOfStrings.AddmObjects("E");

            Console.WriteLine(listOfInts.GetmObjects(2));
            Console.WriteLine(listOfStrings.GetmObjects(2));
        }
    }
}
