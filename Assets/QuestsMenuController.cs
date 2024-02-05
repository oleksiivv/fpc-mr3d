using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class QuestsMenuController : MonoBehaviour
{
    private List<Quest> quests;

    public List<GameObject> completedQuestSlots, currentQuestSlots;

    public List<Image> completedQuestIcons, currentQuestIcons;

    public List<Text> completedQuestTexts, currentQuestTexts;

    public Sprite mainQuestIcon, basicQuestIcon, extraQuestIcon;

    void Start(){
        quests = QuestsFactory.GetQuests();

        FillCompleted();
        FillCurrent();
    }

    private void FillCompleted(){        
        int j=0;
        for(int i=0; i<completedQuestSlots.Count; i++){
            completedQuestSlots[i].SetActive(false);
        }

        for(int i=0; i<quests.Count; i++){
            if(quests[i].IsCompleted()){
                completedQuestSlots[j].SetActive(true);
                completedQuestTexts[j].text = quests[i].info;
                completedQuestIcons[j].GetComponent<Image>().sprite = GetSpriteByQuestType(quests[i].type);

                j++;
            } else {
                continue;
            }
        }
    }

    private void FillCurrent(){        
        int j=0;
        for(int i=0; i<currentQuestSlots.Count; i++){
            currentQuestSlots[i].SetActive(false);
        }

        for(int i=0; i<quests.Count; i++){
            if(!quests[i].IsAvailable())continue;
            if(quests[i].IsCompleted())continue;

            currentQuestSlots[j].SetActive(true);
            currentQuestTexts[j].text = quests[i].info;
            currentQuestIcons[j].GetComponent<Image>().sprite = GetSpriteByQuestType(quests[i].type);

            j++;
        }
    }

    public Sprite GetSpriteByQuestType(string type){
        switch (type)
        {
            case BasicQuests.TYPE:
                return basicQuestIcon;
            case MainQuests.TYPE:
                return mainQuestIcon;
            case ExtraQuests.TYPE:
                return extraQuestIcon;
            default:
                return extraQuestIcon;
        }
    }
}
