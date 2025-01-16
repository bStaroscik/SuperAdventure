using System;
using System.Collections.Generic;
using System.Text;

namespace Engine
{
    public class InventoryItem
    {
        public Item Details { get; set; }
        public int Quantity { get; set; }

        public InventoryItem(Item theDetails, int theQuantity)
        {
            Details = theDetails;
            Quantity = theQuantity;
        }
    }
}
