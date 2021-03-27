namespace InheritanceDziedziczenie
{
    public class Porshe : Car        // sealed - nie można dziedziczyć klasy porshe! NIE UŻYWAĆ< LEPIEJ DLA ŚWIATA
    {
        public override string Name => "Porshe";

        public Porshe(int topSpeed) : base(topSpeed)
        {

        }

        public override void Drive()
        {
            throw new System.NotImplementedException();
        }
    }
}
