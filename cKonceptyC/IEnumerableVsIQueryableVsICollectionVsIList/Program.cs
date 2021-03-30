using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace IEnumerableVsIQueryableVsICollectionVsIList
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = new List<int>();

            // IQueryable interface implementujący wszystkie opcje LinQ, tylko że on nie działa na samej liście np. tylko
            // tworzy osobny obiekt , query który wybiera najloptymalniejszą metodę to zrobienia tego co chcemy i dopiero
            // na końcu np. .ToList() tworzy nam listę!!

            // IEnumerable, IQueryable, ICollection, IList    // wszystkie typy tych interfesjów są generyczne
            // w interfacach tych chodzi o to , żeby używać tylko tego co jest nam potrzebne, nie używać wszystkiego
            // jak np mamy wyświetlić wszystko z listy, tu wystarczy IEnumerable

            // ------------------------------------------------------------------------------------------------
            var myEnumerable = new MyEnumerable<List<int>>();
                     // IEnumarable pomaga nam w przejściu pokolei
            foreach (var item in list)
            {

            }

            myEnumerable.PrintAllElements(list);
            // -------------------------------------------------------------------------------------------------

            // -------------------------------ECollection zawiera IEnumarable, podstawowe operacje, dodać, odjąc itp
            var myCollection = new MyCollection<List<int>>();

            myCollection.PrintAllElementsAndAdd(list, 25);
            // -------------------------------------------------------------------------------------------------

            // --------------------------------IList najbardziej rozszerzona metoda 
            var myList = new MyIList<List<int>>();

            myList.plusIndexOfCountAndOthersFunction(list);
            // --------------------------------------------------------------------------------------------------


            // --------------------------------------------------------------------------Optymalny LINQ! 
            var listThousandInt = new List<int>();
            for (int i = 0; i < 1001; i++)
            {
                listThousandInt.Add(i);
            }

            // listThousandInt.Select(x => x + 5).ToList();  // w taki sposób przy skomplikowanych np. obiektach spieprzymy sprawę
                                                             // bo możemy zawiesić nawet komputer, przy tworzeniu tych wszystkich danych
            listThousandInt.Select(x => x + 5);              // Tutaj tworzy obiekt query i dzięki temu że mamy to tak zapisane
            var midList = listThousandInt.Take(5);           // tylko do 5 danych doda te 5, więc jest to super optymalne i zwalnia nas z myślenia :)

        }
    }
}
