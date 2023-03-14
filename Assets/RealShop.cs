using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
//using UnityEngine.Purchasing;

public class RealShop : MonoBehaviour
{
    public GameObject load;
    public GameObject adsPanel;

    public Text coins, prog;
    public GameObject audioComp;
    // Start is called before the first frame update
    /*
    void Start()
    {
        if(PlayerPrefs.GetInt("noads")==1){
            adsPanel.SetActive(false);
        }


        if (PlayerPrefs.GetInt("Mute") == 1)
        {
            audioComp.GetComponent<AudioSource>().enabled = false;

        }
        else{
            audioComp.GetComponent<AudioSource>().enabled = true;
        }
    }

    void Update(){
        coins.text=PlayerPrefs.GetInt("money").ToString();
        prog.text=PlayerPrefs.GetInt("skill").ToString();
    }

    public void buySmallBag(){
        PlayerPrefs.SetInt("money",PlayerPrefs.GetInt("money")+250);
        PlayerPrefs.SetInt("skill", PlayerPrefs.GetInt("skill")+500);
    }

    public void buySmallMiddleBag(){
        PlayerPrefs.SetInt("money",PlayerPrefs.GetInt("money")+500);
        PlayerPrefs.SetInt("skill", PlayerPrefs.GetInt("skill")+800);
    }

    public void buyBigBag(){
        PlayerPrefs.SetInt("money",PlayerPrefs.GetInt("money")+1200);
        PlayerPrefs.SetInt("skill", PlayerPrefs.GetInt("skill")+1500);
    }

    public void buyNoAdsBag(){
        //PlayerPrefs.GetInt("noads")!=1
        PlayerPrefs.SetInt("noads",1);
        Invoke("noads",0.2f);
    }
    

    public void loadS()
    {
        load.SetActive(true);
        Application.LoadLevel(0);
    }

    public void openScene(int id){
        load.SetActive(true);
        Application.LoadLevel(id);
    }

    void noads(){
        adsPanel.SetActive(false);
    }


    public void OnPurchaseComplete(Product product){
        if(PlayerPrefs.GetInt("Mute")!=1) GetComponent<AudioSource>().Play();
      switch(product.definition.id){
        case "small_bag":
        {
          Invoke("buySmallBag",0.2f);
          break;
        }
        case "mid_bag":
        {
          Invoke("buySmallMiddleBag",0.2f);
          break;
        }
        case "big_bag":
        {
          Invoke("buyBigBag",0.2f);
          break;
        }
        case "noads":
        {
          Invoke("buyNoAdsBag",0.2f);
          break;
        }
      }
    }

    */
}
