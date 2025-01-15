using System;
using System.Collections.Generic;
using System.Text;

namespace Engine
{
    public class Item
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string NamePlural { get; set; }

        public Item(int theId, string theName, string theNamePlural)
        {
            Id = theId;
            Name = theName;
            NamePlural = theNamePlural;
        }
    }
}
