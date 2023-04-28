using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyDesignPattern
{
    // QuickSort algorithm is defined
    public class QuickSort : ISortStrategy
    {
        // Sorting codes are written to the implemented Sort method.
        public void Sort(List<string> list)
        {
            Console.WriteLine("QuickSorted list ");
        }
    }
}
