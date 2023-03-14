using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ontrig2 : MonoBehaviour {
    // Use this for initialization
    private GameObject sp1;
    private GameObject sp2;
    private GameObject player;
    public GameObject loadCnt;
	void Start () {
        sp1 = GameObject.FindGameObjectWithTag("spawmpoint1");
        sp2 = GameObject.FindGameObjectWithTag("spawmpoint2");
        player = GameObject.FindGameObjectWithTag("Player");
        
    }

    // Update is called once per frame
    void Update () {
        
	}
    void OnTriggerEnter(Collider other)
    {
        if (other.name == "doorout")
        {
            if (SceneManager.GetActiveScene().name == "SampleScene")
            {
                PlayerPrefs.SetInt("Settings",1);
               
                //player.transform.position = sp1.transform.position;
                //Application.LoadLevelAsync(1);
                loadCnt.SetActive(true);
                //PlayerPrefs.SetInt("Settings", 1);
                Application.LoadLevel(1);

            }

            
            //walls.tm = 0;
        }
        
        if (other.tag == "homeDno")
        {
            Application.LoadLevel(Application.loadedLevel);
        }
    }
    void load()
    {
        Application.LoadLevelAsync(1);
    }
}
