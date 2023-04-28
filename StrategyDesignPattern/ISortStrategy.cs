using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyDesignPattern
{
    // The interface is defined for the Sort method to be used in sorting algorithms
    public interface ISortStrategy
    {
        public void Sort(List<string> list);
    }
}
