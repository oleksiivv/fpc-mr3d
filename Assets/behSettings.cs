using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.Advertisements;

public class behSettings : MonoBehaviour
{
    // Start is called before the first frame update
    int vForMute=1;
    public GameObject b1;
    public GameObject b2;
    public GameObject toMute;
    public GameObject load;

#if UNITY_IOS
    string gameId = "3507081";
#else
    string gameId = "3507082";
#endif

    public AdmobController admob;

    // Use this for initialization
    void Start()
    {
        Advertisement.Initialize(gameId, false);
        
        if(PlayerPrefs.GetInt("noads")!=1){
            if(Advertisement.IsReady("video")){
                Advertisement.Show("video");
            }else{
                admob.showIntersitionalAd();
            }
        }

        //GameObject.Find("Mute").SetActive(false);
        if (PlayerPrefs.GetInt("cntMove")>0)
            vForMute = PlayerPrefs.GetInt("cntMove");
    }

    // Update is called once per frame
    void Update()
    {
        if (PlayerPrefs.GetInt("Mute") == 1)
        {
            toMute.GetComponent<AudioSource>().enabled = false;
            b1.gameObject.SetActive(false);
            b2.gameObject.SetActive(true);
        }
        else{
            toMute.GetComponent<AudioSource>().enabled = true;
        }
            if ((vForMute % 2 == 0))
        {
            b1.gameObject.SetActive(false);
            b2.gameObject.SetActive(true);
            PlayerPrefs.SetInt("Mute",1);
        }
        else
        {
            b2.gameObject.SetActive(false);
            b1.gameObject.SetActive(true);
            PlayerPrefs.SetInt("Mute", 0);
        }
    }
    public void Like()
    {
        //load.SetActive(true);
        Application.OpenURL("https://www.instagram.com/vertex.studio.games/");
    }
    public void HOME()
    {
        load.SetActive(true);
        Invoke("loadS",2);

    }
    public void mute()
    {
        //GameObject.Find("Mute").gameObject.SetActive(true);
        //GameObject.Find("NonMute").SetActive(false);
        vForMute++;
        PlayerPrefs.SetInt("cntMove", vForMute);


    }
    public void unMute()
    {
        vForMute++;
        PlayerPrefs.SetInt("cntMove", vForMute);
    }
    void loadS()
    {
        Application.LoadLevel(0);
    }
    void OnMouseDown()
    {
        //if (Advertisement.IsReady("baner"))
        //{
        //    Advertisement.Show("baner");
        //}
    }

    public GameObject yes, no;
    public void sureQ()
    {
        yes.SetActive(!yes.activeSelf);
        no.SetActive(!no.activeSelf);
    }

    public void noQ()
    {
        yes.SetActive(false);
        no.SetActive(false);
    }


    public void clearProgress()
    {

        gameObject.GetComponent<AudioSource>().Play();
        int skill = PlayerPrefs.GetInt("skill");
        int pro=PlayerPrefs.GetInt("noads");
        PlayerPrefs.DeleteAll();
        
        PlayerPrefs.SetInt("skill", skill);
        yes.SetActive(false);
        no.SetActive(false);
        PlayerPrefs.SetInt("asked",1);
        PlayerPrefs.SetInt("history",1);
        PlayerPrefs.SetInt("noads",pro);
    }
}
