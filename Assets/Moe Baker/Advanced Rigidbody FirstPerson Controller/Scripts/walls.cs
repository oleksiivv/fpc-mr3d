using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class walls : MonoBehaviour {
    // Use this for initialization
    int door=-1;
    public int tm=0;
    public Vector3 contexm;
    public float xps;
    public Text txt;
    public static float day=0;

    public Material[] skyDay;
    public Material[] skyNight;
    int materialN = 0;

    public AnimationCurve skyCurve;
    int skyDayId;
    int skyNightId;
    void Start()
    {
        skyDayId=UnityEngine.Random.Range(0,skyDay.Length);
        skyNightId=UnityEngine.Random.Range(0,skyNight.Length);

        txt = GameObject.Find("PlayerDay").GetComponent<Text>();
        //if (PlayerPrefs.GetInt("dr") == 100) { day = PlayerPrefs.GetInt("d"); }
        //else if (PlayerPrefs.GetInt("dr") != 100) { day = 0; }

        day = PlayerPrefs.GetInt("d");

        materialN = UnityEngine.Random.Range(0, skyDay.Length);
        

        if(PlayerPrefs.GetInt("d") % 24 - 12<0){

            RenderSettings.skybox = skyDay[0];
            door=-1;
        }
        else{
            RenderSettings.skybox = skyNight[0];
            door=1;

        }
        tm=PlayerPrefs.GetInt("d")*400;

    }
	
    float time=0f;
	// Update is called once per frame
	void Update () {
        print(tm);
        time+=Time.deltaTime/30f;
        if(time>=1)time-=1;
        tm += 1*Convert.ToInt16(Time.timeScale);

        //RenderSettings.skybox.Lerp(skyNight[0],skyDay[0],skyCurve.Evaluate((((day+12f) % 24f-12f)/12f+1f)/2f));
        //DynamicGI.UpdateEnvironment();


        if (tm % 400.0f == 0)
        {
            day += 1;
            PlayerPrefs.SetInt("d", Convert.ToInt16(day));
        }
            //skyDay[materialN].color = new Color(skyDay[materialN].color.r * (1 - tm), skyDay[materialN].color.g * (1 - tm), skyDay[materialN].color.b * (1 - tm), skyDay[materialN].color.a);
            if (tm % (4800.0f) == 0)
        {
            
            door = -door;
            //day += 1f;
            
            /*if (door <= 0)
            {
                RenderSettings.skybox = skyDay[UnityEngine.Random.Range(0, skyDay.Length)];
            }
            else if (door > 0)
            {
                RenderSettings.skybox = skyNight[UnityEngine.Random.Range(0, skyNight.Length)];
                
            }*/
        }
        else if (door <= 0)
        {
            //skyDay[materialN].color= new Color(skyDay[materialN].color.r * (1 - (tm/60)*door), skyDay[materialN].color.g * (1 - (tm / 60) * door), skyDay[materialN].color.b * (1 - (tm / 60) * door), skyDay[materialN].color.a);
            //RenderSettings.skybox = skyDay[UnityEngine.Random.Range(0, skyDay.Length)];
            gameObject.isStatic = false;
            transform.position = new Vector3(140, transform.position.y, transform.position.z);
            gameObject.isStatic = true;
        }
        else if (door > 0)
        {
            //RenderSettings.skybox = skyNight[UnityEngine.Random.Range(0, skyNight.Length)];
            gameObject.isStatic = false;
            transform.position = new Vector3(126, transform.position.y, transform.position.z);
            gameObject.isStatic = true;
        }

        if (Input.GetKey(KeyCode.I)) { PlayerPrefs.SetInt("d",Convert.ToInt32(day)); PlayerPrefs.SetInt("dr",100); }
        
        txt.text = Convert.ToString(Convert.ToInt16(day));
        
	}
    void OnApplicationQuit()
    {
        tm = 0;
    }







}
