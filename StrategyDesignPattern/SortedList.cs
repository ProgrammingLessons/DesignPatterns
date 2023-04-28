using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyDesignPattern
{
    // Context is class
    public class SortedList
    {
        // The list to be sorted is defined
        private List<string> list = new List<string>();

        // In ISortStrategy type, the variable that will perform the sorting operation is defined.
        private ISortStrategy sortstrategy;
        // Which sorting algorithm will be used is taken by the method.
        public void SetSortStrategy(ISortStrategy sortstrategy)
        {
            this.sortstrategy = sortstrategy;
        }
        // Value is added to the list
        public void Add(string name)
        {
            list.Add(name);
        }
        // When the Sort method is called with the specified sorting algorithm, sorting is done
        public void Sort()
        {
            sortstrategy.Sort(list);
        }
    }
}
