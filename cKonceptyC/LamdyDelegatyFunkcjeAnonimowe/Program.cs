using System;
using System.Collections.Generic;

namespace LamdyDelegatyFunkcjeAnonimowe
{
    class Program
    {
        static void Main(string[] args)
        {
            /*// Action<int> someVariable = (a) => a * 2;     //Action nie działa, bo nie może nic zwracać
            Func<int, (int, int)> someVariable = (a) => (a * 2, a * 4);

            *//*DelegateName someVariable = (a) =>      // dłuższy zapis
            { 
                return a * 2; 
            };*//*

            var number = someVariable(5);

            SomeFunction2(someVariable);*/

            var listOfStrings = new List<string>
            {
                "a", "b", "c", "d", "e", "f"
            };

            var stringMatchingExpression = GetFirstOrDefault(listOfStrings, (someString) => 
            { 
                return someString.StartsWith('b'); 
            });

            Console.WriteLine(stringMatchingExpression);
        }
              

       /* private static void SomeFunction2(Func<int, (int, int)> someFunction1)
        {
            var a = someFunction1(2);
        }*/

        private static string GetFirstOrDefault(List<string> strings, Func<string, bool> functionToCheck)
        {
            foreach (var item in strings)
            {
                if (functionToCheck(item))
                {
                    return item;
                }
            }

            return null;
        }
    }
}
