using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RateUsController : MonoBehaviour
{
    public void rate(){


      Application.OpenURL("https://vertexstudio.herokuapp.com/games/game?game=10");
      PlayerPrefs.SetInt("asked",1);
      gameObject.SetActive(false);


    }

    public void remindLater(){
      functional.first=3;
      gameObject.SetActive(false);

    }

    public void remindNewer(){
      PlayerPrefs.SetInt("asked",1);
      gameObject.SetActive(false);
    }
}
