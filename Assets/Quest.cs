using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Quest : MonoBehaviour
{
    public string info;

    public Sprite iconSprite; 

    public Text text;

    public Image container;

    public string code;

    public string type;

    public List<string> nextQuestCodes=new List<string>();

    public List<string> requiredQuestCodes=new List<string>();

    public string Title(){
        return info.Split('\n')[0];
    }

    public bool IsAvailable(){
        //Debug.Log("AVAILEBALE: "+code+"_"+PlayerPrefs.GetInt("Quest_Available_"+code, 0).ToString());

        if(code == BasicQuests.LEARN_TO_RUN || code == MainQuests.FIND_HOUSE || code == MainQuests.FIND_MAZE){
            return true;
        }

        return PlayerPrefs.GetInt("Quest_Available_"+code, 0) == 1;
    }

    public bool IsCompleted(){
        return PlayerPrefs.GetInt("Quest_Completed_"+code, 0) == 1;
    }

    public void Complete(){
        PlayerPrefs.SetInt("Quest_Completed_"+code, 1);
    }

    private void Open(){
        Debug.Log("Opened_"+code);
        PlayerPrefs.SetInt("Quest_Available_"+code, 1);
    }

    public bool CanBeOpened(QuestsPanelController quests){
        //if(IsAvailable()) return false;

        bool canBeOpened=true;
        foreach(var code1 in requiredQuestCodes){
            var quest = quests.GetQuestByCode(code1);
            
            if(!quest.IsCompleted()){
                canBeOpened=false;
            }
        }

        Debug.Log("Can be opened: "+code+": "+canBeOpened.ToString());

        return canBeOpened;//canBeOpened;
    }

    public bool OpenNext(QuestsPanelController quests){
        bool openedAtLeastOne=false;
        foreach(var code in nextQuestCodes) {
            var quest = quests.GetQuestByCode(code);
            if(quest.CanBeOpened(quests)){
                quest.Open();
                openedAtLeastOne=true;
            }
        }

        return openedAtLeastOne;
    }
}
