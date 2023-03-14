using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Advertisements;
public class health : MonoBehaviour {
    public static float health1;
    public Slider slider1;
    public Text txt;
    public Text alert;
    private float pause = 0;
    int v2 = 0;

    
    // Use this for initialization
#if UNITY_IOS
    string gameId = "3507081";
#else
    string gameId = "3507082";
#endif

    // Use this for initialization
    void Start()
    {
        //_l.transform.Rotate(-90,0,0);

        Advertisement.Initialize(gameId, true);


        if (PlayerPrefs.GetInt("Value1") == 100)
        {
            health1 = PlayerPrefs.GetFloat("Health");
        }
        else
        {
            health1 = 100;
        }
        alert.gameObject.SetActive(false);
        
	}
	
	// Update is called once per frame
	void FixedUpdate () {
        slider1.value = health1;
        health1 -= 0.001f*Time.timeScale;
        if (health1 <5) {
            txt.gameObject.SetActive(true);
            alert.text="";
            PlayerPrefs.SetInt("armor20",0);
            PlayerPrefs.SetInt("armor40", 0);
            PlayerPrefs.SetInt("armor60", 0);
            PlayerPrefs.SetInt("Value1", 1);
            Invoke("die",3);



        }
        if (Input.GetKey(KeyCode.I))
        {
            PlayerPrefs.SetInt("Value1",100);
            PlayerPrefs.SetFloat("Health",health1);
        }

        if(health1<15){
            alert.gameObject.SetActive(true);
        }
    }
    public void save()
    {
        PlayerPrefs.SetInt("Value1", 100);
        PlayerPrefs.SetFloat("Health", health1);
    }

    public void die()
    {
        Application.LoadLevel(0);
    }
}
