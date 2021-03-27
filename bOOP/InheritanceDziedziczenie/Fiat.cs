namespace InheritanceDziedziczenie
{
    class Fiat : Mazda                   // dzięki temu dziedziczy i po mazda i po car, bo mazda dziedziczy po car!
    {
        public Fiat(int topSpeed) : base(topSpeed)
        {

        }

    }
}
