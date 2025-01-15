using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Engine
{
    public class Location
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public Item ItemRequiredToEnter { get; set; }
        public Quest QuestAvailableHere { get; set; }
        public Monster MonsterLivingHere { get; set; }
        public Location LocationToNorth { get; set; }
        public Location LocationToEast { get; set; }
        public Location LocationToSouth { get; set; }
        public Location LocationToWest { get; set; }

        public Location(int theId, string theName, string theDescription, Item theItemRequiredToEnter = null, Quest theQuestAvailableHere = null, Monster theMonsterLivingHere = null)
        {
            Id = theId;
            Name = theName;
            Description = theDescription;
            ItemRequiredToEnter = theItemRequiredToEnter;
            QuestAvailableHere = theQuestAvailableHere;
            MonsterLivingHere = theMonsterLivingHere;
        }
    }
}
