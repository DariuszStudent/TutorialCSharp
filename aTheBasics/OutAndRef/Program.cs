using System;

namespace OutAndRef
{
    class Program
    {
        static void Main(string[] args)
        {
            var firstNumber = 2;
            var secundNumber = 2;
            var result = 2;
            var myClass = new MyClass();

            var isOperationSuccess = SumTwoNumbers(firstNumber, secundNumber, out result);

            Console.WriteLine(result);
        }

        private static bool SumTwoNumbers(int firstNumber, int secundNumber, out int result)     // out musi zrobić zmianę na zmiennej wyżej, ref nie musi zrobić zmiany.
                                                                                                 // MyClass myClass --- tutaj mamy automatycznie referencje
        {
            if (firstNumber > 3)
            {
                result = firstNumber + secundNumber;

                return true;
            }
            result = 0;

            return false;
        }
    }

    public class MyClass { }
}
