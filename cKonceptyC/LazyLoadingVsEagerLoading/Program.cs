using System.Collections.Generic;
using System.Linq;

namespace LazyLoadingVsEagerLoading
{
    class Program
    {
        static void Main(string[] args)
        {
            // koncept głównie wykorzystywany w bazie danych!
            // Jeśli chodzi o teoretyczną 
            // Lazy loading nie ładuje się od razu do pamięci, tylko wtedy kiedy je wykorzystujemy
            // jest wczytywany przepis na wygenerowanie danych, kiedy je wykorzystujemy dopiero się ładują do pamięci,
            // tylko ładują się te dane które chcemy, a nie wszystkie, np. Quearyale, linq, dopiero po zrobieniu np .ToList wczytuje się do pamięci.

            // Easer loading ładuje się od razu do pamięci, w pełnej formie, wszystkie dane się ładują

            var someList = GetNumbers();                  // tu mamy IEnumarable, LazyLoading

            var materializedList = someList.ToList();     // tu mamy EaserLoading - dopiero tu materializujemy te dane, są w pamięci
        }

        private static IEnumerable<int> GetNumbers()
        {
            for (int i = 0; i < 10; i++)
            {
                yield return i;                // yield - te słówko sprawia to że, zwróci nam każdy element tej pętli jako liste interface IEnumerable
            }
        }
    }
}
