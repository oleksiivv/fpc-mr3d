using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapOpenCloseController : MonoBehaviour
{
    public GameObject map;

    public Animator mapAnimator;

    private bool opened=true;

    void Start(){
        if (PlayerPrefs.GetInt("MAP") == 1)
        {
            opened = PlayerPrefs.GetInt("MAP_OPENED") == 1;
            OpenMap();
            
            // if(opened){
            //     OpenMap();
            // } else {
            //     CloseMap();
            // }
        }
    }

    public void ChangeMapState(){
        if(opened){
            CloseMap();
        } else{
            OpenMap();
        }
    }

    void CloseMap(){
        opened=false;

        mapAnimator.SetBool("open", false);
        mapAnimator.SetBool("close", true);

        PlayerPrefs.SetInt("MAP_OPENED", opened ? 1 : 0);
    }

    void OpenMap(){
        opened=true;

        mapAnimator.SetBool("close", false);
        mapAnimator.SetBool("open", true);

        PlayerPrefs.SetInt("MAP_OPENED", opened ? 1 : 0);
    }
}
