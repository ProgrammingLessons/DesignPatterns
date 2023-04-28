using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyDesignPattern
{
    // MergeSort algorithm is defined
    public class ShellSort : ISortStrategy
    {
        public void Sort(List<string> list)
        {
            // Sorting codes are written to the implemented Sort method.
            Console.WriteLine("ShellSorted list ");
        }
    }
}
