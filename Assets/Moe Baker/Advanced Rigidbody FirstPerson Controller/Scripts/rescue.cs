using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class rescue : MonoBehaviour {

    private Text txt1;
    private Text txt2;

    public GameObject[] text;
	// Use this for initialization
	void Start () {
        /*GameObject.Find("PlayerRecord").GetComponent<Text>().text = GameObject.Find("PlayerDay").GetComponent<Text>().text;
        GameObject.Find("PlayerRecord2").GetComponent<Text>().text = GameObject.Find("PlayerDay").GetComponent<Text>().text;*/
        PlayerPrefs.SetInt("RV",1);
        Invoke("startAnim",1f);
        Invoke("close",15f);
        //GameObject.Find("texts").gameObject.SetActive(true);

        
        


    }

    void startAnim(){
        StartCoroutine(textAnims());
    }

int curr=0;
    IEnumerator textAnims(){
        while(true){

            if(curr<=4){
                text[curr].SetActive(true);
                curr++;
            }
            yield return new WaitForSeconds(2f);

        }
    }

    public void close(){
        restart();
    }
	
	// Update is called once per frame
	void Update () {
        
    }
    void restart()
    {
        Application.LoadLevelAsync(0);
        
    }
}
