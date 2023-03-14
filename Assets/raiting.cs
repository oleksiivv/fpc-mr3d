using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class raiting : MonoBehaviour
{
    // Start is called before the first frame update

    public Text money;
    public Text dayTime;

    public Text raitingText;
    public Text recordMessage;
    private int raitings = 0;
    private int raitingsMessage = 0;
    void Start()
    {
        money.GetComponent<Text>().text = Convert.ToString(PlayerPrefs.GetInt("money"));
        dayTime.GetComponent<Text>().text = Convert.ToString(PlayerPrefs.GetFloat("Day") * 12);

        raitings = PlayerPrefs.GetInt("money")*10;
        //raitings += 300;

        if (PlayerPrefs.GetFloat("Day") == 1)
        {
            raitings += 10000;
        }
        else if (PlayerPrefs.GetFloat("Day") == 2)
        {
            raitings += 8000;
        }
        else if (PlayerPrefs.GetFloat("Day") == 3)
        {
            raitings += 7000;
        }
        else if (PlayerPrefs.GetFloat("Day") == 4)
        {
            raitings += 6000;
        }
        else if (PlayerPrefs.GetFloat("Day") == 5)
        {
            raitings += 5000;
        }
        else if (PlayerPrefs.GetFloat("Day") == 6)
        {
            raitings += 4000;
        }
        else if (PlayerPrefs.GetFloat("Day") == 7)
        {
            raitings += 3000;
        }
        else if (PlayerPrefs.GetFloat("Day") == 8)
        {
            raitings += 2000;
        }
        else if (PlayerPrefs.GetFloat("Day") == 9)
        {
            raitings += 1500;
        }
        else if (PlayerPrefs.GetFloat("Day") == 10)
        {
            raitings += 1000;
        }

        else if (PlayerPrefs.GetFloat("Day") >= 10 && PlayerPrefs.GetFloat("Day") < 15)
        {
            raitings += 900;
        }

        else if (PlayerPrefs.GetFloat("Day") >= 15 && PlayerPrefs.GetFloat("Day") < 25)
        {
            raitings += 700;
        }
        else if (PlayerPrefs.GetFloat("Day") >= 25 && PlayerPrefs.GetFloat("Day") < 45)
        {
            raitings += 500;
        }
        else
        {
            raitings += 100;
        }
        raitingText.GetComponent<Text>().text = Convert.ToString(raitings);

        if (raitings <= 100)
        {
            raitingsMessage = 100000;
        }
        else if (raitings <= 5000)
        {
            raitingsMessage = 10000;
        }
        else if (raitings <= 10000)
        {
            raitingsMessage = 1000;
        }
        else if (raitings <= 50000)
        {
            raitingsMessage = 100;
        }
        else if (raitings <= 70000)
        {
            raitingsMessage = 50;
        }
        else if (raitings <= 100000)
        {
            raitingsMessage = 20;
        }
        else
        {
            raitingsMessage = 10;
        }

        if(raitings>0)recordMessage.GetComponent<Text>().text = "top " + Convert.ToString(raitingsMessage);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
