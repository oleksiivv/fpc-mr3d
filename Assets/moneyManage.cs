using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class moneyManage : MonoBehaviour
{
    // Start is called before the first frame update
    public Text moneyText;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        moneyText.GetComponent<Text>().text = Convert.ToString(PlayerPrefs.GetInt("money"));
    }
}
