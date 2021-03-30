using System;
using System.Collections;
using System.Collections.Generic;

namespace IEnumerableVsIQueryableVsICollectionVsIList
{
    public class MyEnumerable<T> : IEnumerable<T>
    {
        public IEnumerator<T> GetEnumerator()               // on sprawia to, że po klasie co implementuje ten interface sprawia to że można przechodzić po jej elementach
        {                                                   // czyli np. można zrobić foreach
            throw new NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }

        // -----------------------------------------------Jeśli robimy tylko foreacha, to możemy wykorzystać tylko I Enumerable
        public void PrintAllElements(IEnumerable<int> list)
        {
            foreach (var element in list)
            {
                Console.WriteLine(element);
            }
        }
        // -------------------------------------------------
    }
}
