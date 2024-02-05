using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CompletedQuestsAutoOpen : MonoBehaviour
{
    public GameObject panel;

    public void TryOpen(){
        if(PlayerPrefs.GetInt("Completed_Quests_Auto_Open_Completed", -1) == -1){
            panel.SetActive(true);
            PlayerPrefs.SetInt("Completed_Quests_Auto_Open_Completed", 1);
        }
    }
}
