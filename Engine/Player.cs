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

        public Player(int theCurrentHitPoints, int theMaximumHitPoints, int theGold, int theExperiencePoints, int theLevel) : base(theCurrentHitPoints, theMaximumHitPoints)
        {
            Gold = theGold;
            ExperiencePoints = theExperiencePoints;
            Level = theLevel;
            Inventory = new List<InventoryItem>();
            Quests = new List<PlayerQuest>();
        }

        public bool HasRequiredItemToEnterThisLocation(Location location)
        {
            if (location.ItemRequiredToEnter == null)
            {
                //There is no required item for this location, so return "true"
                return true;
            }

            //See if player has the required item in their inventory
            foreach (InventoryItem ii in Inventory)
            {
                if (ii.Details.Id == location.ItemRequiredToEnter.Id)
                {
                    //We found the required item, so return "true"
                    return true;
                }
            }

            //We didn't find the required item in their inventory, so return "false"
            return false;
        }

        public bool HasThisQuest(Quest quest)
        {
            foreach (PlayerQuest playerQuest in Quests)
            {
                if (playerQuest.Details.Id == quest.Id)
                {
                    return true;
                }
            }

            return false;
        }

        public bool CompletedThisQuest(Quest quest)
        {
            foreach (PlayerQuest playerQuest in Quests)
            {
                if (playerQuest.Details.Id == quest.Id)
                {
                    return playerQuest.IsCompleted;
                }
            }

            return false;
        }

        public bool HasAllQuestCompletionItems(Quest quest)
        {
            //See if the player has all the items needed to complete the quest here
            foreach (QuestCompletionItem qci in quest.QuestCompletionItems)
            {
                bool foundItemInPlayersInventory = false;

                //Check each item in the player's inventory, to see if they have it, and enough of it
                foreach (InventoryItem ii in Inventory)
                {
                    if (ii.Details.Id == qci.Details.Id) //The player has the item in their inventory
                    {
                        foundItemInPlayersInventory = true;

                        if (ii.Quantity < qci.Quantity) //The player does not have enough of this item to complete this quest
                        {
                            return false;
                        }
                    }
                }

                //The player does not have any of this quest completion items in their inventory
                if (!foundItemInPlayersInventory)
                {
                    return false;
                }
            }

            //If we got here, then the player must have all the required items, and enough of them, to complete the quest.
            return true;
        }

        public void RemoveQuestCompletionItems(Quest quest)
        {
            foreach (QuestCompletionItem qci in quest.QuestCompletionItems)
            {
                foreach (InventoryItem ii in Inventory)
                {
                    if (ii.Details.Id == qci.Details.Id)
                    {
                        //Subtract the quantity from the player's inventory that was needed to complete the quest
                        ii.Quantity -= qci.Quantity;
                        break;
                    }
                }
            }
        }

        public void AddItemToInventory(Item itemToAdd)
        {
            foreach (InventoryItem ii in Inventory)
            {
                if (ii.Details.Id == itemToAdd.Id)
                {
                    //They have the item in their inventory, so increase the quantity by one
                    ii.Quantity++;

                    return; //We added the item, and are done, so get out of this function
                }
            }

            //They didn't have the item, so add it to their inventory, with a quantity of 1
            Inventory.Add(new InventoryItem(itemToAdd, 1));
        }

        public void MarkQuestCompleted(Quest quest)
        {
            //Find the quest in player's quest list
            foreach (PlayerQuest pq in Quests)
            {
                if (pq.Details.Id == quest.Id)
                {
                    //Mark it as completed
                    pq.IsCompleted = true;

                    return; //We found the quest, and marked it complete, so get out of this function
                }
            }
        }
    }
}