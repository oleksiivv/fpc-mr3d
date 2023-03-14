using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mute : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject[] toMute;
    void Start()
    {
        if (PlayerPrefs.GetInt("Mute")==1)
        {
            for(int i = 0; i < toMute.Length; i++)
            {
                toMute[i].GetComponent<AudioSource>().enabled = false;
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
