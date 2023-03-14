using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class oneFoodIsActive : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        if (PlayerPrefs.GetInt(gameObject.name + "Destroyed") == 1)
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
        }
    }
}
