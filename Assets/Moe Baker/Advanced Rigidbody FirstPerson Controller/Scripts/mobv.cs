using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using UnityStandardAssets.CrossPlatformInput;

using UnityEngine.Advertisements;


public class mobv : MonoBehaviour
{

    //public GameObject player;
    // Use this for initialization
    public float y = 0;
    private bool ismove=false;

    private bool isrightrotate = false;
    private bool isleftrotate = false;
    private bool isrun = false;
    public GameObject camera;
    int xR = 0;

    bool isRightRotate=true;
    bool isLeftRotate=true;
    bool isUpRotate = false;
    bool isDownRotate = false;
    int yAngle=0;
    int backM = 0;
    public GameObject gun;

    public GameObject load;

    public static bool runable=false;

#if UNITY_IOS
    string gameId = "3507083";
#else
    string gameId = "3507082";
#endif

    public Button btnRun;


    public AdmobController admob;
    //public Button btnD;

    void Start () {
        //btnRun.GetComponent<Image>().material.color=new Color32(255,255,255,255);
        runable=false;
        //btnD.gameObject.SetActive(false);
        pausePanel.SetActive(false);
        Time.timeScale = 1;
        Advertisement.Initialize(gameId, false);



        if(PlayerPrefs.GetInt("firstOpen")== 1)
        {
            startPanel.SetActive(false);
        }
        else
        {
            startPanel.SetActive(true);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            xR ++;   
        }
        
        //if (Input.GetMouseButtonDown(0))
        //{
        //    isRightRotate = true;
        //    isLeftRotate=true;

        //}
        if (Input.GetMouseButtonUp(0))
        {
            backM = 0;
            ismove = false;
            isleftrotate = false;
            isrightrotate = false;
            isUpRotate = false;
            isDownRotate = false;
        }
        transform.Rotate(0, y, 0);
        //y+= 3*CrossPlatformInputManager.GetAxis("Vertical");
        camera.gameObject.transform.Rotate(xR, 0, 0);
        
        if(isrightrotate)
        {
            y += 4f;
            
            //transform.rotation *= Quaternion.Euler(0f, 20f * Time.deltaTime, 0f);
        }
        else if (isleftrotate)
        {
            y -=4f;
            
            //
            //y += -50;
        }
       

        if (isUpRotate)
        {
            if(xR>=-45)xR-=1;
        }
        else if (isDownRotate)
        {
            if(xR<=45)xR+=1;
        }
        
        gun.transform.rotation= camera.gameObject.transform.rotation;

        //transform.rotation *= Quaternion.Euler(0f, 50f * Time.deltaTime*yAngle, 0f);

        gameObject.transform.Translate(-Vector3.forward * 5 * Time.deltaTime*backM);
        


        /////
        if(runable){
            health.health1-=0.05f;
          btnRun.GetComponent<Image>().color=new Color32(70,255,0,255);
        }
        else{
          btnRun.GetComponent<Image>().color=new Color32(255,255,255,255);
        }




    }
    public void rightrotate()
    {
        isrightrotate = true;
        isleftrotate = false;
        //yAngle += 8;
        

    }
    public void leftrotate()
    {

        //yAngle -= 8;
        isleftrotate = true;
        isrightrotate = false;

    }
    public void rightrotateUp()
    {
        yAngle = 0;
        
        
    }
    public void leftrotateUp()
    {
        yAngle = 0;

    }
    public void m()
    {
        Time.timeScale = 1;
        PlayerPrefs.SetInt("Value1", 100);
        PlayerPrefs.SetFloat("Health", health.health1);
        load.SetActive(true);
        Invoke("home",3f);
    }
    public void back()
    {
        //transform.Translate(-Vector3.forward * 25 * Time.deltaTime);
        backM = 1;
    }
    public void UpX()
    {
        //xR--;
        isUpRotate = true;
    }
    public void DownX()
    {
        //xR++;
        isDownRotate = true;
    }

    void home()
    {
        Application.LoadLevel(0);
    }


    public GameObject pausePanel;

    int cnt = 1;

    public static int addCnt=0;
    public void pause()
    {
         //if (addCnt%2==0 /*&& Advertisement.IsReady("video")*/)
         //{
             //if(PlayerPrefs.GetInt("noads")!=1)admob.showIntersitionalAd();//Advertisement.Show("video");
         //}else{
             if(PlayerPrefs.GetInt("noads")!=1){
                 if(!admob.showIntersitionalAd()){
                    Advertisement.Show("video");
                 }
             }
        //}
        //addCnt++;
        pausePanel.SetActive(true);
        Time.timeScale = 0;

    }

    public void playInv()
    {
        pausePanel.SetActive(false);
        Time.timeScale = 1;
    }

    public void settingsLoad()
    {
        Time.timeScale = 1;
        PlayerPrefs.SetInt("Value1", 100);
        PlayerPrefs.SetFloat("Health", health.health1);
        load.SetActive(true);
        
        Invoke("sett", 3f);
    }
    void sett()
    {
        Application.LoadLevel(5);
    }


    public GameObject startPanel;
    


    

    public void startGame()
    {
        startPanel.SetActive(false);
        PlayerPrefs.SetInt("firstOpen", 1);
    }

    public QuestsPanelController quests;

    public void runrun(){
        runable=!runable;

        quests.CompleteQuest(BasicQuests.LEARN_TO_RUN);
    }
}