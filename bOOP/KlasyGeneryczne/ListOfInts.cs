using System;
using System.Collections.Generic;
using System.Text;

namespace KlasyGeneryczne
{
    public class ListOfInts
    {
        private List<int> mNumbers = new List<int>();

        public int GetNumber(int index)
        {
            return mNumbers[index];
        }

        public void AddNumber(int number)
        {
            mNumbers.Add(number);
        }

        //dużo zmian jakbyśmy chcieli nagle string bool itp, kopiuj wklej
    }
}
