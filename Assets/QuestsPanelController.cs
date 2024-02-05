using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Linq;

public class QuestsPanelController : MonoBehaviour
{
    public GameObject questsPanel;

    public GameObject questsButton;

    public List<Quest> quests;

    public List<GameObject> questSlots;

    public List<Image> questIcons;

    public List<Text> questTexts;

    private int questSlotsCount;

    public GameObject newQuestAvailableAlert;

    public bool isGameScene = false;

    public GameObject questCompletedObject;

    public Image questCompletedIcon;

    public Text questCompletedDescription;

    private bool dontAddNewQuestsToQueue = false;

    public Sprite mainQuestIcon, basicQuestIcon, extraQuestIcon;

    private bool needToShowNewQuestsAvailableAlert=false;

    private bool completedQuestsCoroutineInProgress=false;

    public CompletedQuestsPanelController completedQuestsController;

    public CompletedQuestsAutoOpen completedQuestsAutoOpen;

    void Awake(){
        quests = QuestsFactory.GetQuests();
    }

    void Start(){
        questsPanel.SetActive(false);

        questSlotsCount = questSlots.Count;

        if (PlayerPrefs.GetInt("second_open", 0) == 1 || PlayerPrefs.GetInt("second_open", 0) == 2) {
            questsButton.GetComponent<Animator>().enabled=true;
            PlayerPrefs.GetInt("second_open", PlayerPrefs.GetInt("second_open", 0) + 1);
        } else if (PlayerPrefs.GetInt("second_open", 0) == 0) {
            PlayerPrefs.SetInt("second_open", 1);
            questsButton.GetComponent<Animator>().enabled=false;

            Invoke(nameof(simulateSecondOpen), 20);
        } else {
            questsButton.GetComponent<Animator>().enabled=false;
        }

        if(isGameScene) {
            FillQuestsUI();
            ShowCompletedAlertsQueue();

            if (PlayerPrefs.GetInt("ShowedNewQuestsAvailable", 0) == -1){
                needToShowNewQuestsAvailableAlert=true;
                completedQuestsCoroutineInProgress = true;
            }

            if(completedQuestsController.FillQuestsUI()){
                completedQuestsAutoOpen.TryOpen();
            }
        }
    }

    public void SetQuestsPanelVisibility(bool visible){
        PlayerPrefs.SetInt("second_open", 4);
        questsButton.GetComponent<Animator>().enabled=false;

        questsPanel.SetActive(visible);

        //TODO: remove, test only
        if(!visible){
            //CompleteQuest(MainQuests.FIND_HOUSE);
            //CompleteQuest(MainQuests.FIND_MAZE);
        }
    }

    public void FillQuestsUI(){
                completedQuestsController.FillQuestsUI();

        int j=0;
        for(int i=0; i<questSlots.Count; i++){
            questSlots[i].SetActive(false);
        }

        for(int i=0; i<quests.Count; i++){
            if(!quests[i].IsAvailable())continue;
            if(quests[i].IsCompleted())continue;

            questSlots[j].SetActive(true);
            questTexts[j].text = quests[i].info;
            questIcons[j].GetComponent<Image>().sprite = GetSpriteByQuestType(quests[i].type);

            j++;

            if(j>=questSlots.Count)break;
        }
    }

    public Quest GetQuestByCode(string code){
        return this.quests.Find((q) => q.code == code);
    }

    public void CompleteQuest(string code){
        var quest = this.GetQuestByCode(code);
        
        if(quest.IsCompleted())return;
        //else if(!quest.IsAvailable())return;
        else Debug.Log("completed: "+ code);

        PlayerPrefs.SetInt("Quest_Completed_"+code, 1);
        if (!dontAddNewQuestsToQueue) {
            PlayerPrefs.SetString(
                "completed_quests_alerts_queue",
                PlayerPrefs.GetString("completed_quests_alerts_queue") +code+ ":"
            );
        } else {
            PlayerPrefs.SetString(
                "completed_quests_alerts_queue_tmp",
                PlayerPrefs.GetString("completed_quests_alerts_queue_tmp") +code+ ":"
            );
        }

        quest.Complete();
        
        if(quest.OpenNext(this)){
            if(quest.IsAvailable())OpenNewQuestPanel();
        }
        
        if(IsInvoking(nameof(ShowCompletedAlertsQueue))){
            //CancelInvoke(nameof(ShowCompletedAlertsQueue));
        }

        Invoke(nameof(ShowCompletedAlertsQueue), 1f);
        completedQuestsCoroutineInProgress = true;

        FillQuestsUI();

        //update quests and ui
        //add next available quests
        //move main quests to the top
        //update player prefs
    }

    private void OpenNewQuestPanel(){
        PlayerPrefs.SetInt("ShowedNewQuestsAvailable", -1);
//        var quest = this.GetQuestByCode(code);

        needToShowNewQuestsAvailableAlert=true;
        
//        quest.Open();
    }

    void CloseNewQuestAvailableAlert(){
        PlayerPrefs.SetInt("ShowedNewQuestsAvailable", 0);
        newQuestAvailableAlert.SetActive(false);
    }

    void simulateSecondOpen(){
        if (PlayerPrefs.GetInt("second_open", 0) == 1 || PlayerPrefs.GetInt("second_open", 0) == 2) {
            questsButton.GetComponent<Animator>().enabled=true;
            PlayerPrefs.GetInt("second_open", PlayerPrefs.GetInt("second_open", 0) + 1);
        }
    }

    void ShowCompletedAlertsQueue(){
        string completedQuests = PlayerPrefs.GetString("completed_quests_alerts_queue", "-1");
        if(completedQuests == "-1")return;

        var questCodes = completedQuests.Split(':').ToList();

        dontAddNewQuestsToQueue = true;
        StartCoroutine(ShowCompletedAlerts(questCodes));
        Invoke(nameof(ResumeQueueUpdating), questCodes.Count * 5);
    }

    IEnumerator ShowCompletedAlerts(List<string> codes){
        foreach(var code in codes){
            if(code.Length < 5)continue;

            yield return new WaitForSeconds(1.5f);

            if(PlayerPrefs.GetInt("quest_completed_panel_showed_for_"+code, 0) == 0){
                questCompletedObject.SetActive(true);
                Debug.Log(code);

                Quest quest = this.GetQuestByCode(code);
                
                if(quest.OpenNext(this)){
                    OpenNewQuestPanel();
                }

                ShowCompletedQuestAlert(quest);

                PlayerPrefs.SetInt("quest_completed_panel_showed_for_"+code, 1);

                yield return new WaitForSeconds(5);

                questCompletedObject.SetActive(false);
            }
        }
        completedQuestsCoroutineInProgress=false;
    }

    void ResumeQueueUpdating(){
        dontAddNewQuestsToQueue = false;
        PlayerPrefs.SetString("completed_quests_alerts_queue", PlayerPrefs.GetString("completed_quests_alerts_queue_tmp"));

        ShowCompletedAlertsQueue();
    }

    private void ShowCompletedQuestAlert(Quest quest){
        questCompletedIcon.GetComponent<Image>().sprite = this.GetSpriteByQuestType(quest.type);
        questCompletedDescription.text = "You succesfully completed \"" + quest.Title() + "\"";
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

    void Update(){
        if(
            needToShowNewQuestsAvailableAlert 
            && !completedQuestsCoroutineInProgress
        ){
            newQuestAvailableAlert.SetActive(true);
            PlayerPrefs.SetInt("ShowedNewQuestsAvailable", 1);
            needToShowNewQuestsAvailableAlert=false;
            Invoke(nameof(CloseNewQuestAvailableAlert), 4);
        }
    }
}
