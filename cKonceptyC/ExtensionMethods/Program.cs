using System.Collections.Generic;
using System.Linq;

namespace ExtensionMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            var someStrings = new List<string>();

            someStrings.Where(x => x.Length > 3);

            someStrings.SomeFunctionList();

            var a = "dasdsad";

            a.SomeFunctionString();
        }
    }

    public static class MyClass
    {
        //fdskjfksdjf

        public static void SomeFunctionList(this List<string> SomeList)
        {

        }

        public static void SomeFunctionString(this string someString)
        {
            // do typu prymitywnego, możemy rozszerzać 
        }
    }
}
