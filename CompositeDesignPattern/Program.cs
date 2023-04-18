using System;
using System.Collections.Generic;

namespace CompositeDesignPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Composite general object is created
            Commander general = new Commander("Gençay", Rank.General);

            //Adding Leaf objects to Composite general object
            general.AddSoldier(new BuckPrivate("Müslüm", Rank.Colonel));
            general.AddSoldier(new BuckPrivate("Orhan", Rank.Colonel));

            //New Composite Major and LieutenantColonel objects are created
            Commander major = new Commander("Hilmi", Rank.Major);
            Commander lieutenantColonel = new Commander("Cavit", Rank.LieutenantColonel);

            //We add Leaf objects to the Lieutenant Colonel Composite object.
            lieutenantColonel.AddSoldier(new BuckPrivate("Murat", Rank.Major));
            lieutenantColonel.AddSoldier(new BuckPrivate("Kaan", Rank.Major));

            //Adding the Lieutenant Colonel object to the Colonel Composite object.
            major.AddSoldier(lieutenantColonel);

            //Adding Leaf object to Colonel Composite object.
            major.AddSoldier(new BuckPrivate("Mustafa", Rank.LieutenantColonel));

            //Adding the Colonel Composite object to the general object.
            general.AddSoldier(major);

            //The command is given from the General object.
            general.ExecuteOrder();
        }
    }
}
