using System;
using System.Collections.Generic;
using System.Text;

namespace aTheBasics
{
    class ShortWrite
    {
        public void ifFaster()
        {
            /*var a = 0;

                if (5 > 2)
                    a = 2;
                else
                    a = 5;*/

            var a = 5 > 2 ? 2 : 5;
            // warunek 5 > 2    znak zapytania to a = 2, a jeśli nie to a = 5
        }

        public bool SomeFunction => true;
        /*public bool SomeFunction()
        {
            return true;
        }*/
    }
}

