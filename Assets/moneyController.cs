using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class moneyController : MonoBehaviour
{
    // Start is called before the first frame update
    public Text money;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        money.GetComponent<Text>().text = Convert.ToString(PlayerPrefs.GetInt("money"));
    }
}
