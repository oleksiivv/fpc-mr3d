using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class oneFoodIsActive : MonoBehaviour
{
    public bool defaultFood=false;
    // Start is called before the first frame update
    void Start()
    {
        if (defaultFood) 
        {
            gameObject.SetActive(PlayerPrefs.GetInt("Collected_"+gameObject.name, 0) == 0);
        } 
        else if (PlayerPrefs.GetInt(gameObject.name + "Destroyed") == 1)
        {
            gameObject.SetActive(false);
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            PlayerPrefs.SetInt(gameObject.name + "Destroyed", 1);
            PlayerPrefs.SetInt("Collected_"+gameObject.name, 1);
        }
    }
}
