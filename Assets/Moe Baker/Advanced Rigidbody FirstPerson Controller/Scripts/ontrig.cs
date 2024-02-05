using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.UI;
using UnityEngine.Advertisements;


public class ontrig : MonoBehaviour {
    int cntEnter = 0;
    public GameObject map;
    public GameObject spawnpoint_1;
    public GameObject spawnpoint_2;
    //public GameObject _l;
    //private Text txt1 = GameObject.FindWithTag("PlayerRecord").GetComponent<Text>();
    int x = 1, y = 1, z = 1;
    int v = 1;
    public float xp, yp, zp,xr1;
    public static int xr;
    public static int night = 0;
    Vector3 pos;
    int i;
    int time;
    public float continiusrotate;
    int saverot;
    int dooropen=1;
    public GameObject gun;
    public GameObject prutsil,buttonSh;

    public GameObject blasterGet;

    public GameObject loading,wellAudio;

    float damage = 50;

#if UNITY_IOS
    string gameId = "3507083";
#else
    string gameId = "3507082";
#endif


    public Text numOfPatrons;

    public AdmobController admob;

    public QuestsPanelController quests;

    // Use this for initialization
    void Start () {
        //_l.transform.Rotate(-90,0,0);

        if (PlayerPrefs.GetInt("armor20") == 1)
        {
            damage = 50.0f / 10.0f * 8.0f;
        }
        if (PlayerPrefs.GetInt("armor40") == 1)
        {
            damage = 50.0f / 10.0f * 6.0f;
        }
        if (PlayerPrefs.GetInt("armor60") == 1)
        {
            damage = 50.0f / 10.0f * 4.0f;
        }





        Advertisement.Initialize(gameId, false);


        Screen.orientation=ScreenOrientation.LandscapeLeft;
        if (PlayerPrefs.GetInt("MAP") == 1)
        {
            map.gameObject.SetActive(true);
        }
        if (PlayerPrefs.GetInt("Value")==2)
        {
            
            //walls.tm = 18098;
            transform.position = spawnpoint_1.transform.position;
            //_l.transform.Rotate(280, 0, 0);
        }
        else if(PlayerPrefs.GetInt("Value") == 3)
        {
            
            //walls.tm = 18098;
            transform.position = spawnpoint_2.transform.position;
            //_l.transform.Rotate(280, 0, 0);
        }
        else if (PlayerPrefs.GetInt("Value") == 100)
        {
            //walls.tm = 18098;
            transform.position = new Vector3(PlayerPrefs.GetFloat("XP"),
            PlayerPrefs.GetFloat("YP"),
            PlayerPrefs.GetFloat("ZP"));
            //_l.transform.Rotate(280, 0, 0);

            //_l.transform.rotation=Quaternion.Euler(PlayerPrefs.GetInt("XR"),180,0);

        }
        else if (PlayerPrefs.GetInt("Value") == 666)
        {
            Application.LoadLevel(3);

        }
        else if (PlayerPrefs.GetInt("Value") == 1)
        {
            //walls.tm = 18098;
            transform.position = new Vector3(83.2f,5,351.9f);
            transform.rotation = new Quaternion(0, 140, 0,0);
            //_l.transform.Rotate(280, 0, 0);

        }
        
        else
        {
            //walls.tm = 0;
            transform.position = new Vector3(83.2f,5,351.9f);
            transform.rotation = new Quaternion(0, 140, 0, 0);
            //_l.transform.Rotate(100,0,0);
            //time = 0;
            //PlayerPrefs.SetInt("SR",1);
            //dooropen = 1;
            //xr = 1;
        }
        if (PlayerPrefs.GetInt("Gun") == 1)
        {
            blasterGet.SetActive(false);
            buttonSh.SetActive(true);
            gun.gameObject.SetActive(true);
            prutsil.gameObject.SetActive(true);
            quests.CompleteQuest(MainQuests.FIND_WEAPON);
        }
        else{
            blasterGet.SetActive(true);
            buttonSh.SetActive(false);
            gun.gameObject.SetActive(false);
            prutsil.gameObject.SetActive(false);
        }


    }

    // Update is called once per frame
    void FixedUpdate () {
        
        
        if (Input.GetKey(KeyCode.I))
        {
            v = 100;
            pos = transform.position;
            xp = pos.x;
            yp = pos.y;
            zp = pos.z;
            //xr1 = _l.transform.rotation.eulerAngles.x;
            //saverot = time;
            
            PlayerPrefs.SetInt("Value", v);
            PlayerPrefs.SetFloat("XP", xp);
            PlayerPrefs.SetFloat("YP", yp);
            PlayerPrefs.SetFloat("ZP", zp);
            //PlayerPrefs.SetFloat("XR",xr1);
            //PlayerPrefs.SetInt("SR", saverot);


        }
        else if (Input.GetKey(KeyCode.Escape))
        {
            //Application.LoadLevel(0);
        }
        else if (Input.GetKey(KeyCode.UpArrow))
        {
            gameObject.transform.Translate(Vector3.forward*12f*Time.deltaTime);
            health.health1 -= 0.02f;
        }
        else if (Input.GetKey(KeyCode.LeftArrow))
        {
            gameObject.transform.Rotate(transform.rotation.x - 5, transform.rotation.y + 5, transform.rotation.z - 5);
        }
        else if (Input.GetKey(KeyCode.RightArrow))
        {
            gameObject.transform.Rotate(transform.rotation.x + 5, transform.rotation.y - 5, transform.rotation.z + 5);
        }
        numOfPatrons.GetComponent<Text>().text = PlayerPrefs.GetInt("patron").ToString();
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.name == "sweethome")
        {
            quests.CompleteQuest(MainQuests.FIND_HOUSE);

            v=2;
            x = -29;
            y = 3;
            z = 26;
            //walls.tm = 0;

            //health.health1 = 100;

            PlayerPrefs.SetInt("Value1", 100);
            PlayerPrefs.SetFloat("Health", health.health1);
            PlayerPrefs.SetInt("MAP",1);
            PlayerPrefs.SetInt("Value",v);
            PlayerPrefs.SetFloat("X",13);
            PlayerPrefs.SetFloat("Y",1);
            PlayerPrefs.SetFloat("Z", -6);

            //Application.LoadLevel(2);
            loading.SetActive(true);
            //Invoke("load", 2f);
            Application.LoadLevel(2);
            

            PlayerPrefs.SetInt("d", Convert.ToInt32(walls.day));
            //transform.position = new Vector3(PlayerPrefs.GetFloat("X"), PlayerPrefs.GetFloat("Y"), PlayerPrefs.GetFloat("Y"));

        }
        else if (other.name == "sweethome2")
        {
            quests.CompleteQuest(MainQuests.FIND_HOUSE);

            v = 3;
            x = 85;
            y = 2;
            z = 19;
            //health.health1 = 100;
            //walls.tm = 0;

            PlayerPrefs.SetInt("Value1", 100);
            PlayerPrefs.SetFloat("Health", health.health1);

            PlayerPrefs.SetInt("MAP", 1);
            PlayerPrefs.SetInt("Value", v);
            PlayerPrefs.SetFloat("X", 13);
            PlayerPrefs.SetFloat("Y", 1);
            PlayerPrefs.SetFloat("Z", -6);

            //Application.LoadLevel(2);

            loading.SetActive(true);
            //Invoke("load", 2f);
            Application.LoadLevel(2);
            

            PlayerPrefs.SetInt("d", Convert.ToInt32(walls.day));
            PlayerPrefs.SetInt("dr", 100);
            //transform.position = new Vector3(PlayerPrefs.GetFloat("X"), PlayerPrefs.GetFloat("Y"), PlayerPrefs.GetFloat("Y"));

        }
        else if (other.tag == "hell")
        {
            PlayerPrefs.SetInt("skill", PlayerPrefs.GetInt("skill") + 2);
            wellAudio.GetComponent<AudioSource>().Play();
            health.health1 += 7;
            Destroy(other.gameObject);
        }
        else if (other.tag == "food")
        {
            quests.CompleteQuest(ExtraQuests.FIND_HEALTH_RESOURCES);

            PlayerPrefs.SetInt("skill", PlayerPrefs.GetInt("skill") + 5);
            wellAudio.GetComponent<AudioSource>().Play();
            health.health1 += 15;
            Destroy(other.gameObject);
        }
        else if (other.tag == "MAZE_ENTRY")
        {
            quests.CompleteQuest(MainQuests.FIND_MAZE);
        }
        //else if (other.tag == "spider")
        //{
        //    if (other.GetComponent<spidersbehavior>().enabled == true)
        //    {
        //        gameObject.transform.position += new Vector3(0, 5, 0);
        //        gameObject.transform.rotation = new Quaternion(-90,transform.rotation.y,transform.rotation.z,0);
        //        health.health1 -= damage;
        //        other.transform.position -= new Vector3(5,0,5);
        //    }
        //}

        
        else if (other.tag == "lastroom")
        {
            quests.CompleteQuest(MainQuests.FIND_EXIT_FROM_MAZE);

            if (cntEnter==0&&((PlayerPrefs.GetInt("Record") >  PlayerPrefs.GetInt("d"))|| PlayerPrefs.GetInt("Record")==0))
            {
                PlayerPrefs.SetInt("Record", PlayerPrefs.GetInt("d"));
            }

            walls.day=0;
            PlayerPrefs.SetInt("skill", PlayerPrefs.GetInt("skill") + 100);
            wellAudio.GetComponent<AudioSource>().Play();
            
            PlayerPrefs.SetInt("Value", 1);
            //PlayerPrefs.SetFloat("Day",walls.day);
            PlayerPrefs.SetInt("d", 0);
            //PlayerPrefs.SetInt("d",1);
            //Application.LoadLevel(3);
            loading.SetActive(true);
            Invoke("loadThird", 2f);

            cntEnter++;

        }
        else if (other.tag == "blaster")
        {
            quests.CompleteQuest(MainQuests.FIND_WEAPON);

            PlayerPrefs.SetInt("skill", PlayerPrefs.GetInt("skill") + 30);
            PlayerPrefs.SetInt("patron",PlayerPrefs.GetInt("patron")+10);
            wellAudio.GetComponent<AudioSource>().Play();
            buttonSh.SetActive(true);
            gun.gameObject.SetActive(true);
            prutsil.gameObject.SetActive(true);
     
            other.gameObject.SetActive(false);
            PlayerPrefs.SetInt("Gun",1);
        }
        else if (other.tag == "coin")
        {
            quests.CompleteQuest(ExtraQuests.FIND_GOLD);

            PlayerPrefs.SetInt("skill", PlayerPrefs.GetInt("skill") + 10);
            wellAudio.GetComponent<AudioSource>().Play();
            other.gameObject.SetActive(false);
            PlayerPrefs.SetInt("money",PlayerPrefs.GetInt("money")+90);
            
        }
        else if (other.tag == "coinlot")
        {
            quests.CompleteQuest(ExtraQuests.FIND_GOLD);

            PlayerPrefs.SetInt("skill", PlayerPrefs.GetInt("skill") + 30);
            wellAudio.GetComponent<AudioSource>().Play();
            other.gameObject.SetActive(false);
            PlayerPrefs.SetInt("money", PlayerPrefs.GetInt("money") + 500);
            
        }
    }

    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "spider")
        {
            if (other.gameObject.GetComponent<spidersbehavior>().enabled == true)
            {
                gameObject.transform.position += new Vector3(0, 5, 0);
                gameObject.transform.rotation = new Quaternion(-90, transform.rotation.y, transform.rotation.z, 0);
                health.health1 -= damage;
                other.transform.position -= new Vector3(5, 0, 5);
            }
        }
    }

    void OnApplicationQuit()
    {
        PlayerPrefs.SetInt("Value1", 100);
        PlayerPrefs.SetFloat("Health", health.health1);
        if (PlayerPrefs.GetInt("Value") != 100)
        {
            PlayerPrefs.SetInt("Value", 1);
            PlayerPrefs.SetFloat("X", 32);
            PlayerPrefs.SetFloat("Y", 4);
            PlayerPrefs.SetFloat("Z", 150);
            
            //PlayerPrefs.SetInt("Gun",0);
        }
        

    }

    public GameObject savedText;
    public void saveButton()
    {

        //if (mobv.addCnt%2==0 && Advertisement.IsReady("video"))
        // {
          //   if(PlayerPrefs.GetInt("noads")!=1)Advertisement.Show("video");
         //}else{
             if(PlayerPrefs.GetInt("noads")!=1){
                 if(!admob.showIntersitionalAd()){
                    Advertisement.Show("video");
                 }
             }
        //}
        //mobv.addCnt++;

        //admob.showIntersitionalAd();
        v = 100;
        pos = gameObject.transform.position;
        xp = pos.x;
        yp = pos.y;
        zp = pos.z;
        //xr1 = _l.transform.rotation.eulerAngles.x;
        //saverot = time;
        PlayerPrefs.SetInt("d", Convert.ToInt32(walls.day));
        PlayerPrefs.SetInt("dr", 100);

        PlayerPrefs.SetInt("Value", v);
        PlayerPrefs.SetFloat("XP", xp);
        PlayerPrefs.SetFloat("YP", yp);
        PlayerPrefs.SetFloat("ZP", zp);
        //PlayerPrefs.SetInt("Value1", 100);
        PlayerPrefs.SetInt("Value1", 100);
        PlayerPrefs.SetFloat("Health", health.health1);

        savedText.SetActive(true);
        savedText.GetComponent<AudioSource>().Play();
        Invoke("textDestroy",2f);
        
    }
    public void m()
    {

        Application.LoadLevel(0);
    }
    public void LeftR()
    {
        transform.Rotate(transform.rotation.x, transform.rotation.y+ 45, 0f);
    }
    public void RightR()
    {
        transform.Rotate(transform.rotation.x, transform.rotation.y-45, 0f);
    }
    void load()
    {
        Application.LoadLevelAsync(2);
    }
    void loadThird()
    {
        Application.LoadLevel(3);
    }

    void textDestroy()
    {
        savedText.SetActive(false);
    }
    static int cnt = 0;
    void OnMouseDown()
    {
        
    }
    
}