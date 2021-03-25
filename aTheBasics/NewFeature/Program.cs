using System;

namespace NewFeature
{
    class Program
    {
        static void Main(string[] args)
        {
            int? i = default;  // int który nie ma domyślnie zero tylko jest null

            var myClass = new MyClass();

            /*if (myClass == null)
            {
                myClass.Variable = "costam2";
            }*/

            myClass.Variable ??= "costam2";   // to tutaj to dokładnie to samo co jest na górze!

            Console.WriteLine(myClass?.Variable);   // dzięki znaku zapytania nie wywali wyjątku gdy właściwość jest nullem a da pusty string

            //---------------------------------------------------------------Switch feature

            var operation = 1;
            var someOutput = default(double);
            var firstNumber = 5;
            var secundNumber = 2;

           /* switch (operation)
            {
                case 1:
                    someOutput = firstNumber + secundNumber;
                    break;
                case 2:
                    someOutput = firstNumber - secundNumber;
                    break;
                case 3:
                    someOutput = firstNumber * secundNumber;
                    break;
                case 4:
                    someOutput = firstNumber / secundNumber;
                    break;
                default:
                    someOutput = 0;
                    break;
            }*/


            someOutput = operation switch                  // to jest to samo co na górze tylko w pięknym krótkim zapisie :)
            {
                1 => firstNumber + secundNumber,
                2 => firstNumber - secundNumber,
                3 => firstNumber * secundNumber,
                4 => firstNumber / secundNumber,
                _ => 0,
            };

            // ----------------------------------------------------------------------------------Para zmiennych Super rzecz !

            var a = myClass.SumeFunction();

            var resultSomeFuntion = a.Item1;
            var isFineSomeFunction = a.Item2;

            // -----------------------------------------------------------------------------------Wyjątki

            try
            {
                // ......
                MyClass mC = null;

                mC.Variable = "S";
            }
            catch (Exception)
            {

                throw;
            }
            finally          // nie ważne że jest błąd czy coś takiego! finally zawsze się wykona, np. żeby zakmnąć plik!
            {

            }
        }
    }

    public class MyClass
    {
        public string Variable { get; set; }

        public (int, bool) SumeFunction()
        {
            return (5 + 2, true);
        }
    }
}
