using System;
using System.Collections.Generic;
using System.Text;

namespace InheritanceDziedziczenie
{
    public class Audi : Car
    {
        public override string Name => "Audi";

        public Audi(int topSpeed) : base(topSpeed)
        {

        }

        public override void Drive()
        {
            throw new NotImplementedException();
        }
    }
}
