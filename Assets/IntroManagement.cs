using System.Collections;
using System.Collections.Generic;
using UnityEngine;


using UnityEngine.UI;


public class IntroManagement : MonoBehaviour
{

  public GameObject introPanel;
  public GameObject[] text;
    // Start is called before the first frame update
    void Start()
    {
        if(PlayerPrefs.GetInt("history")==0){
          introPanel.SetActive(true);
          PlayerPrefs.SetInt("history",1);
          StartCoroutine(history());
          Invoke("skipHistory",15f);
        }
        else{
          introPanel.SetActive(false);
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
    int i=0;

    IEnumerator history(){
      while(i<text.Length){
        text[i].SetActive(true);
        i++;


        yield return new WaitForSeconds(2f);
      }
    }

    public void skipHistory(){

      introPanel.SetActive(false);
    }

    public void readStory(){

      introPanel.SetActive(true);
      StartCoroutine(history());
      //Invoke("skipHistory",15f);
    }
}
