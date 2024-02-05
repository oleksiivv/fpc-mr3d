using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CompletedQuestsPanelController : MonoBehaviour
{
    public QuestsPanelController questsController;

    public GameObject questsPanel;

    private List<Quest> quests;

    public List<GameObject> questSlots;

    public List<Image> questIcons;

    public List<Text> questTexts;

    public bool FillQuestsUI(){
        int numberOfActiveSlots = 0;

        quests=questsController.quests;
        
        int j=0;
        for(int i=0; i<questSlots.Count; i++){
            questSlots[i].SetActive(false);
        }

        for(int i=0; i<quests.Count; i++){
            if(quests[i].IsCompleted()){
                questSlots[j].SetActive(true);
                questTexts[j].text = quests[i].info;
                questIcons[j].GetComponent<Image>().sprite = questsController.GetSpriteByQuestType(quests[i].type);

                j++;
                numberOfActiveSlots=j;
                Debug.Log(j);
                Debug.Log("...");
            } else {
                continue;
            }
        }

        return numberOfActiveSlots>=2;
    }

    public void SetQuestsPanelVisibility(bool visible){
        questsPanel.SetActive(visible);
    }
}
