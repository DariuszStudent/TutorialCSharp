using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace IEnumerableVsIQueryableVsICollectionVsIList
{
    // ---------------------------------------------------------------Zawiera IEnumerable
    public class MyCollection<T> : ICollection<T>
    {
        public int Count => throw new NotImplementedException();

        public bool IsReadOnly => throw new NotImplementedException();

        public void Add(T item)
        {
            throw new NotImplementedException();
        }

        public void Clear()
        {
            throw new NotImplementedException();
        }

        public bool Contains(T item)
        {
            throw new NotImplementedException();
        }

        public void CopyTo(T[] array, int arrayIndex)
        {
            throw new NotImplementedException();
        }

        public IEnumerator<T> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        public bool Remove(T item)
        {
            throw new NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }

        // ------------------------------------------------------------------ metoda
        public void PrintAllElementsAndAdd(ICollection<int> list, int addToList)
        {
            list.Add(addToList);

            foreach (var element in list)
            {

            }
        }
    }
}
