using System;
using System.Collections.Generic;
using System.Text;

namespace Engine
{
    public class QuestCompletionItem
    {
        public Item Details { get; set; }
        public int Quantity { get; set; }

        public QuestCompletionItem(Item theDetails, int theQuantity)
        {
            Details = theDetails;
            Quantity = theQuantity;
        }
    }
}
