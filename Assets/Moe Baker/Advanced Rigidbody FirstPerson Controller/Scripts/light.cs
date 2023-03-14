using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
public class light : MonoBehaviour {
    int i = 0;
    int div = 0;
    public GameObject infoPanel;
    public languageManagement language;

    public float currDeg=0;
	// Use this for initialization
	void Start () {

        int deg=PlayerPrefs.GetInt("lastSavedDeg");

        if(PlayerPrefs.GetInt("d")==0){
            transform.rotation = Quaternion.Euler(60,0,0);
            currDeg=90;
        }
        else{
            transform.rotation = Quaternion.Euler(deg,0,0);
            currDeg=deg;
        }

        

        StartCoroutine(saveSunDegree());

	}
	
	// Update is called once per frame
	void Update () {
        i += 1* Convert.ToInt16(Time.timeScale);
        transform.Rotate(0.033f* Convert.ToInt16(Time.timeScale), 0, 0);
        /*if (Input.GetKey(KeyCode.I))
        {
            div = i;
            PlayerPrefs.SetInt("LocalRotate",div);
            PlayerPrefs.SetInt("Ky",100);
        }*/

        currDeg+=0.03f* Convert.ToInt16(Time.timeScale);
	}
    public void setAct()
    {
        language.UpdateLng();
        infoPanel.SetActive(!infoPanel.activeSelf);
    }

    IEnumerator saveSunDegree(){
        while(true){

            PlayerPrefs.SetInt("lastSavedDeg",(int)currDeg);
            yield return new WaitForSeconds(5);

        }
    }
}
