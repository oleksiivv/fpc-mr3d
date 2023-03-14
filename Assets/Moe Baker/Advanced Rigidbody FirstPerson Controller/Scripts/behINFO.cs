using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Advertisements;

public class behINFO : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject toMute,load;

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
        //_l.transform.Rotate(-90,0,0);

        if (PlayerPrefs.GetInt("Mute") == 1) toMute.GetComponent<AudioSource>().enabled = false;
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void HOME()
    {
        load.SetActive(true);
        Invoke("loadS",2);
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

    public void openScene(int id){
        load.SetActive(true);
        Application.LoadLevel(7);
    }
}
