using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuestsFactory : MonoBehaviour
{
    public static List<Quest> GetQuests(){
        return new List<Quest> {
            //basic
  /* + */   new Quest(){type=BasicQuests.TYPE, info = "<b>Learn how to run</b>\nVery important ability. Learn how to run asap.", code=BasicQuests.LEARN_TO_RUN, nextQuestCodes=new List<string>{MainQuests.FIND_WEAPON}},
  /* + */   new Quest(){type=BasicQuests.TYPE, info = "<b>Learn to shoot</b>\nNow, learn how to shoot to not to do it in the last moment.", code=BasicQuests.LEARN_TO_SHOOT, requiredQuestCodes=new List<string>{MainQuests.FIND_WEAPON}, nextQuestCodes=new List<string>{MainQuests.FIND_BULLETS}},
  /* + */   new Quest(){type=BasicQuests.TYPE, info = "<b>Survive over night</b>\nSomething strange is going on with the time. Maze is closed at night.", code=BasicQuests.SURVIVE_OVER_NIGHT, requiredQuestCodes=new List<string>{MainQuests.FIND_HOUSE, MainQuests.FIND_MAZE}, nextQuestCodes=new List<string>{MainQuests.FIND_EXIT_FROM_MAZE, ExtraQuests.FIND_HEALTH_RESOURCES}},

            //main
  /* + */   new Quest(){type=MainQuests.TYPE, info = "<b>Find house</b>\nIn house you will get a map of the village with maze. There are 2 houses in the village.", code=MainQuests.FIND_HOUSE, nextQuestCodes=new List<string>{ExtraQuests.FIND_GOLD, MainQuests.FIND_EXIT_FROM_MAZE, BasicQuests.SURVIVE_OVER_NIGHT}},
  /* + */   new Quest(){type=MainQuests.TYPE, info = "<b>Find maze</b>\nThere is only one way out - via maze. Find it to be ready to escape asap.", code=MainQuests.FIND_MAZE, nextQuestCodes=new List<string>{MainQuests.FIND_EXIT_FROM_MAZE, BasicQuests.SURVIVE_OVER_NIGHT}},
  /* + */   new Quest(){type=MainQuests.TYPE, info = "<b>Find weapon</b>\nWithout weapon you'll be an easy pray in the maze", code=MainQuests.FIND_WEAPON, nextQuestCodes=new List<string>{ExtraQuests.KILL_THREE_SPIDER, MainQuests.FIND_EXIT_FROM_MAZE}, requiredQuestCodes={BasicQuests.LEARN_TO_RUN}},
  /* + */   new Quest(){type=MainQuests.TYPE, info = "<b>Find bullets</b>\nThere are a lot of enemy creatures in the maze, make sure that you'll be able to destroy as much of them as will be needed.", code=MainQuests.FIND_BULLETS, requiredQuestCodes={MainQuests.FIND_WEAPON}, nextQuestCodes=new List<string>{ExtraQuests.KILL_THREE_SPIDER}},
  /* + */   new Quest(){type=MainQuests.TYPE, info = "<b>Escape the maze</b>\nYou are ready. Go, and find the exit!", code=MainQuests.FIND_EXIT_FROM_MAZE, requiredQuestCodes={MainQuests.FIND_HOUSE, MainQuests.FIND_MAZE, MainQuests.FIND_WEAPON}},

            //extra
  /* + */   new Quest(){type=ExtraQuests.TYPE, info = "<b>Find some gold</b>\nYou'll need it to make some purchases.", code=ExtraQuests.FIND_GOLD, requiredQuestCodes=new List<string>{MainQuests.FIND_HOUSE}, nextQuestCodes=new List<string>{ExtraQuests.BUY_ARMOR_IN_SHOP}},
  /* + */   new Quest(){type=ExtraQuests.TYPE, info = "<b>Buy armor</b>\nUse gold that you have found to buy armor in the shop.", code=ExtraQuests.BUY_ARMOR_IN_SHOP, requiredQuestCodes=new List<string>{ExtraQuests.FIND_GOLD}, nextQuestCodes=new List<string>{ExtraQuests.FIND_HEALTH_RESOURCES}},
  /* + */   new Quest(){type=ExtraQuests.TYPE, info = "<b>Find some food</b>\nUse it to restore your health.", code=ExtraQuests.FIND_HEALTH_RESOURCES, requiredQuestCodes=new List<string>{ExtraQuests.KILL_THREE_SPIDER}},
            new Quest(){type=ExtraQuests.TYPE, info = "<b>Kill monster</b>\nAre you brave enough to find any creature that live in maze?", code=ExtraQuests.KILL_THREE_SPIDER, requiredQuestCodes=new List<string>{MainQuests.FIND_WEAPON}, nextQuestCodes=new List<string>{ExtraQuests.FIND_HEALTH_RESOURCES}},
        };
    }
}
