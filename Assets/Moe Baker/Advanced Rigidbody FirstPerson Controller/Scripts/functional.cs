using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
using UnityEngine.Advertisements;
using GoogleMobileAds.Api;

public class functional : MonoBehaviour
{

    public GameObject settingsButton, settingsText;

    // Use this for initialization
    public GameObject toMute;

    public GameObject load;

    public Text language;
    private int lngNumber=0;

    static int sett = 0;
    static int inf = 0;
    static int pl = 0;

#if UNITY_IOS
    string gameId = "3507081";
#else
    string gameId = "3507082";
#endif

    public GameObject likePanel;
    public static int first=0;

    public AdmobController admob;
    public GameObject noadsBtn;
    void Awake()
    {
        Advertisement.Initialize(gameId, false);
        // Show an ad:
        
        if (PlayerPrefs.GetString("Language") == "Eng")
        {
            language.GetComponent<Text>().text = "Language: English";
            lngNumber = 0;
        }
        else if (PlayerPrefs.GetString("Language") == "Ukr")
        {
            language.GetComponent<Text>().text = "Мова: Українська";
            lngNumber = 1;
        }



        else if (PlayerPrefs.GetString("Language") == "Esp")
        {
            language.GetComponent<Text>().text = "Idioma: Espaniol";

            lngNumber = 2;
        }
        else if (PlayerPrefs.GetString("Language") == "Fra")
        {
            language.GetComponent<Text>().text = "Langue: français";

            lngNumber = 3;
        }
        else
        {
            lngNumber = 0;
        }

        ////////


        if (PlayerPrefs.GetInt("Settings") == 1)
        {
            settingsButton.gameObject.SetActive(true);
            settingsText.gameObject.SetActive(true);
        }
        else
        {
            settingsButton.gameObject.SetActive(false);
            settingsText.gameObject.SetActive(false);
        }
    }
	void Start () {
        
        if (PlayerPrefs.GetInt("Mute") == 1) toMute.GetComponent<AudioSource>().enabled = false;
        Screen.orientation = ScreenOrientation.LandscapeLeft;
        if (PlayerPrefs.GetInt("Record")!=0)
        {
            GameObject.Find("PlayerRecord2").gameObject.SetActive(true);
            GameObject.Find("RescueTime").gameObject.SetActive(true);
            GameObject.Find("days.").gameObject.SetActive(true);

            GameObject.Find("PlayerRecord2").GetComponent<Text>().text = Convert.ToString(PlayerPrefs.GetInt("Record"));
            GameObject.Find("RescueTime").GetComponent<Text>().text = "Rescue time: ";
            GameObject.Find("days.").GetComponent<Text>().text = "hours.";
        }
        else 
        {
            GameObject.Find("PlayerRecord2").gameObject.SetActive(false);
            GameObject.Find("RescueTime").gameObject.SetActive(false);
            GameObject.Find("days.").gameObject.SetActive(false);
        }
        Debug.Log(PlayerPrefs.GetInt("Record"));

        
        first++;
        if(first==2 && PlayerPrefs.GetInt("asked")==0){
           likePanel.SetActive(true);

        }
        else{
            likePanel.SetActive(false);
        }

        if(PlayerPrefs.GetInt("noads")!=1)admob.RequestBannerAd();

        if(PlayerPrefs.GetInt("noads")==1){
            noadsBtn.SetActive(false);
        }
        else{
            //noadsBtn.SetActive(true);
            noadsBtn.SetActive(false);
        }
        
	}
	
	// Update is called once per frame
	void Update ()
    {
		if (Input.GetKey(KeyCode.Escape))
        {
            Application.Quit();
        }





        if (lngNumber==0)
        {
            language.GetComponent<Text>().text = "Language: English";
            PlayerPrefs.SetString("Language","Eng");
        }
        else if (lngNumber == 1)
        {
            language.GetComponent<Text>().text = "Мова: Українська";
            PlayerPrefs.SetString("Language", "Ukr");
        }
        else if (lngNumber == 2)
        {
            language.GetComponent<Text>().text = "Idioma: Espaniol";
            PlayerPrefs.SetString("Language", "Esp");
        }
        else if (lngNumber == 3)
        {
            language.GetComponent<Text>().text = "Langue: français";
            PlayerPrefs.SetString("Language", "Fra");
        }
        
    }
    int cnt = 0;
    void OnMouseDown()
    {
        cnt++;
        //if (Advertisement.IsReady("baner")&&cnt%2==0) Advertisement.Show("baner");
    }
    public void Play()
    {
       
        load.SetActive(true);
        Invoke("load1",2f);
    }
    public void Leave()
    {

        Application.Quit();
    }
    public void Inst()
    {
        load.SetActive(true);
        Application.OpenURL("https://sites.google.com/view/jokercompany/%D0%B4%D0%BE%D0%BC%D0%B0%D1%88%D0%BD%D1%8F-%D1%81%D1%82%D0%BE%D1%80%D1%96%D0%BD%D0%BA%D0%B0");
    }
    public void Info()
    {
     
        load.SetActive(true);
        Invoke("load4", 2f);
    }
    public void Settings()
    {

        load.SetActive(true);
        Invoke("load5", 2f);
    }


    public void load1()
    {
        Application.LoadLevel(1);
    }
    public void load4()
    {
        Application.LoadLevel(4);
    }

    public void load5()
    {
        Application.LoadLevel(5);
    }

    public void changeLng()
    {
        

        lngNumber++;
        if (lngNumber > 3) lngNumber = 0;
        
    }
    static int shop=0;
    public void Shopping()
    {
        //shop++;
        //if (Advertisement.IsReady("video")) Advertisement.Show("video");
        load.SetActive(true);
        Invoke("load6", 2f);
    }
    public void load6()
    {
        Application.LoadLevel(6);
    }
    void AdCallbackHandler(ShowResult res)
    {
        if (res == ShowResult.Finished)
        {
            PlayerPrefs.SetInt("money",PlayerPrefs.GetInt("money")+30);
        }
        else if(res==ShowResult.Skipped)
        {
            Debug.Log("skipped");
        }
        else if (res == ShowResult.Skipped)
        {
            Debug.Log("error");
        }
    }

    public void addMoney()
    {
        ShowOptions options = new ShowOptions();
        options.resultCallback = AdCallbackHandler;
        if (Advertisement.IsReady("rewardedVideo"))
        {
            Advertisement.Show("rewardedVideo",options);
        }
    }

    public void raiting()
    {
        load.SetActive(true);
        Invoke("load7", 2f);
    }
    public void load7()
    {
        Application.LoadLevel(7);
    }



    public void openCurrencyScene(int id){
        load.SetActive(true);
        Application.LoadLevel(id);
    }
}
