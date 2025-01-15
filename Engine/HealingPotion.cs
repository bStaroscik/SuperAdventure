using System;
using System.Collections.Generic;
using System.Text;

namespace Engine
{
    public class HealingPotion : Item
    {
        public int AmountToHeal { get; set; }

        public HealingPotion(int theId, string theName, string theNamePlural, int theAmountToHeal) : base(theId, theName, theNamePlural)
        {
            AmountToHeal = theAmountToHeal;
        }
    }
}
