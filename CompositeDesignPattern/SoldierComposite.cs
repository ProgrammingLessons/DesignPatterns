using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositeDesignPattern
{
    // SoldierComposite class is made as abstract class
    public abstract class SoldierComposite : Soldier
    {
        protected SoldierComposite(string name, Rank rank) : base(name, rank)
        {
        }

        public abstract void AddSoldier(Soldier soldier);
        public abstract void RemoveSoldier(Soldier soldier);
    }
}
