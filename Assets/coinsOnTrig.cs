using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coinsOnTrig : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        if (PlayerPrefs.GetInt(gameObject.name + "destroyed") == 1) gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player"||other.tag=="blaster")
        {
            PlayerPrefs.SetInt(gameObject.name + "destroyed",1);
        }
    }
}
