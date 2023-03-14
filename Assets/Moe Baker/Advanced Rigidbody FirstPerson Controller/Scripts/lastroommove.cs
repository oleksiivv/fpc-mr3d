using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class lastroommove : MonoBehaviour {
    float i = 0;
    int v = 100;
    public Slider sld;
    private Text txt1;
    private Text txt2;
    // Use this for initialization
    void Start () {
        /*txt1 = GameObject.Find("PlayerRecord").GetComponent<Text>();
        txt2 = GameObject.Find("PlayerRecord2").GetComponent<Text>();
        //txt1.text = Convert.ToString(PlayerPrefs.GetFloat("Day"));
        //txt2.text = Convert.ToString(PlayerPrefs.GetFloat("Day"));
        txt1.text = Convert.ToString(GameObject.Find("PlayerDay").GetComponent<Text>());
        txt2.text = Convert.ToString(GameObject.Find("PlayerDay").GetComponent<Text>());*/
    }
	
	// Update is called once per frame
	void Update () {


        sld.value = v;
        
	}
    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "hell")
        {
            other.transform.position -= new Vector3(3,0,3);
            v -= 30;
            if (v == 10)
            {
                PlayerPrefs.SetInt("Value", 1);
                PlayerPrefs.SetFloat("X", 32);
                PlayerPrefs.SetFloat("Y", 4);
                PlayerPrefs.SetFloat("Z", 150);
                Application.LoadLevel(1);
            }
        }
        else if (other.gameObject.tag == "lastw")
        {
            Application.LoadLevel(5);
        }
    }
    
}
