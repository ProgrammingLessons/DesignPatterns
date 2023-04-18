using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositeDesignPattern
{
    // Soldier class is made as abstract class
    public abstract class Soldier
    {
        protected string _name;
        protected Rank _rank;

        // When creating a soldier with the constructive method, his name and rank are taken.
        protected Soldier(string name, Rank rank)
        {
            _name = name;
            _rank = rank;
        }

        // Define the 'Execute Order' abstract method to be used in both Composite and Leaf objects
        public abstract void ExecuteOrder();
    }
}
