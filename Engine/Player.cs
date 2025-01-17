﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Engine
{
    public class Player : LivingCreature
    {
        public int Gold { get; set; }
        public int ExperiencePoints { get; set; }
        public int Level { get; set; }
        public Location CurrentLocation { get; set; }
        public List<InventoryItem> Inventory { get; set; }
        public List<PlayerQuest> Quests { get; set; }

        public Player(int theCurrentHitPoints, int theMaximumHitPoints, int theGold, int theExperiencePoints, int theLevel) : base (theCurrentHitPoints, theMaximumHitPoints)
        {
            Gold = theGold;
            ExperiencePoints = theExperiencePoints;
            Level = theLevel;
            Inventory = new List<InventoryItem>();
            Quests = new List<PlayerQuest>();
        }
    }
}
