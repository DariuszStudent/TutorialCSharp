namespace InheritanceDziedziczenie
{
    class Program
    {
        static void Main(string[] args)
        {
            var mazda = new Mazda(150);

            mazda.Drive();
            SomeFunction(mazda);
            System.Console.WriteLine(mazda.Name);
        }

        public static void SomeFunction(Car car)
        {

        }
    }
}
