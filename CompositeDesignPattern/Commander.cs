using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositeDesignPattern
{
    // The commander is identified
    public class Commander : SoldierComposite
    {
        // The list that will hold the soldiers under the commander is defined.
        List<Soldier> _soldiers = new();
        // While creating the commander, its information is obtained with the constructor method. 
        // The received information is sent to a higher class with a base.
        public Commander(string name, Rank rank) : base(name, rank) { }

        // The method of adding soldiers depending on the commander.
        public override void AddSoldier(Soldier soldier)
        {
            _soldiers.Add(soldier);
        }

        // Soldier deletion method depending on the commander.
        public override void RemoveSoldier(Soldier soldier)
        {
            _soldiers.Remove(soldier);
        }

        public override void ExecuteOrder()
        {
            Console.WriteLine($"{_rank} - {_name}");
            _soldiers.ForEach(x => x.ExecuteOrder());
        }
    }

}
