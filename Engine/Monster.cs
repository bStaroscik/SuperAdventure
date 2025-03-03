﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Engine
{
    public class Monster : LivingCreature
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int MaximumDamage { get; set; }
        public int RewardExperiencePoints { get; set; }
        public int RewardGold { get; set; }
        public List<LootItem> LootTable { get; set; }

        public Monster(int theId, string theName, int theMaximumDamage, int theRewardExperiencePoints, int theRewardGold, int theCurrentHitPoints, int theMaximumHitPoints ) : base(theCurrentHitPoints, theMaximumHitPoints)
        {
            Id = theId;
            Name = theName;
            MaximumDamage = theMaximumDamage;
            RewardExperiencePoints = theRewardExperiencePoints;
            RewardGold = theRewardGold;
            LootTable = new List<LootItem>();
        }
    }
}
