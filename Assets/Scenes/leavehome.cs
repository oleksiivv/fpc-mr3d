using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class leavehome : MonoBehaviour {
    public GameObject txt;
    public GameObject loadCnt;
	// Use this for initialization
	void Start () {
        if (PlayerPrefs.GetInt("Settings") == 1)
        {
            txt.transform.localScale = new Vector3(0,0,0);
        }
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    public void leave()
    {
        loadCnt.SetActive(true);
        PlayerPrefs.SetInt("Settings",1);
        Invoke("load",2f);
        
    }

    void load()
    {
        Application.LoadLevel(1);
    }
}
