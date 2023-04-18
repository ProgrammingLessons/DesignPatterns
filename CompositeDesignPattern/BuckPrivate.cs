using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositeDesignPattern
{
    // It represents the leaf part in the design.
    // The last part is the soldier.
    public class BuckPrivate : Soldier
    {
        public BuckPrivate(string name, Rank rank) : base(name, rank)
        {
        }
        public override void ExecuteOrder()
        {
            Console.WriteLine($"{_rank} - {_name}");
        }
    }
}
