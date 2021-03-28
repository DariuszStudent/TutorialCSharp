using System.Collections.Generic;

namespace KlasyGeneryczne
{
    public class MyList<T>
    {
        private List<T> mObjects = new List<T>();

        public T GetmObjects(int index)
        {
            return mObjects[index];
        }

        public void AddmObjects(T @object)
        {
            mObjects.Add(@object);
        }

        public void SomeFunction()
        {
            //...

        }
    }
}
