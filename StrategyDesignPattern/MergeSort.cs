using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyDesignPattern
{
    // MergeSort algorithm is defined
    public class MergeSort : ISortStrategy
    {
        // Sorting codes are written to the implemented Sort method.
        public void Sort(List<string> list)
        {
            Console.WriteLine("MergeSorted list ");
        }
    }
}
