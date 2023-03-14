using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveController : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject right, left;

    public GameObject slider;
    void Start()
    {
        if (PlayerPrefs.GetInt("MoveType") == 0)
        {
            slider.transform.localScale = new Vector3(0, 0, 0);
        }
        else
        {
            right.transform.localScale = new Vector3(0,0,0);
            left.transform.localScale = new Vector3(0, 0, 0);
            //back.transform.localScale = new Vector3(0, 0, 0);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
