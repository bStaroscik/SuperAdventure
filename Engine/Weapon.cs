using System;
using System.Collections.Generic;
using System.Text;

namespace Engine
{
    public class Weapon : Item
    {
        public int MinimumDamage { get; set; }
        public int MaximumDamage { get; set; }

        public Weapon(int theId, string theName, string theNamePlural, int theMinimumDamage, int theMaximumDamage) : base(theId, theName, theNamePlural)
        {
            MinimumDamage = theMinimumDamage;
            MaximumDamage = theMaximumDamage;
        }
    }
}
