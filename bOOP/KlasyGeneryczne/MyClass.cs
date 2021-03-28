using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace KlasyGeneryczne
{
    public class MyClass<T> : IEquatable<int>              // może być wiele wartości, przykładowo TKey, TValue, piszemy tak żeby je odróżnić
    {
        public T MyNumber { get; set; }

        public bool Equals([AllowNull] int other)
        {
            throw new NotImplementedException();
        }
    }
}
