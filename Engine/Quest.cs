using System;
using System.Collections.Generic;
using System.Text;

namespace Engine
{
    public class Quest
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int RewardExperiencePoints { get; set; }
        public int RewardGold { get; set; }
        public Item RewardItem { get; set; }
        public List<QuestCompletionItem> QuestCompletionItems { get; set; }

        public Quest(int theId, string theName, string theDescription, int theRewardExperiencePoints, int theRewardGold)
        {
            Id = theId;
            Name = theName;
            Description = theDescription;
            RewardExperiencePoints = theRewardExperiencePoints;
            RewardGold = theRewardGold;
            QuestCompletionItems = new List<QuestCompletionItem>();
        }
    }
}
