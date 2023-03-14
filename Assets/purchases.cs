using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Advertisements;

public class purchases : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject armor20, armor40, armor60;
    public GameObject map;
    public GameObject food_, barels;
    public Text money;
    string gameId = "3507082";


    int barelsNum = 40;
    int foodNum = 26;

    void Awake()
    {
        Advertisement.Initialize(gameId, false);
    }
    void Start()
    {
        if (PlayerPrefs.GetInt("MAP") == 1)
        {
            map.SetActive(true);
        }

        if(PlayerPrefs.GetInt("armor20") == 1)
        {
            armor20.SetActive(true);
        }
        if (PlayerPrefs.GetInt("armor40") == 1)
        {
            armor40.SetActive(true);
        }
        if (PlayerPrefs.GetInt("armor60") == 1)
        {
            armor60.SetActive(true);
        }
        if (PlayerPrefs.GetInt("barels") == 1)
        {
            barels.SetActive(true);
        }
        if (PlayerPrefs.GetInt("food") == 1)
        {
            food_.SetActive(true);
        }

        money.GetComponent<Text>().text = Convert.ToString(PlayerPrefs.GetInt("money"));
    }

    // Update is called once per frame
    void Update()
    {
        if (PlayerPrefs.GetInt("MAP") == 1)
        {
            
            map.SetActive(true);
        }

        if (PlayerPrefs.GetInt("armor20") == 1)
        {
            armor20.SetActive(true);
        }
        if (PlayerPrefs.GetInt("armor40") == 1)
        {
            armor40.SetActive(true);
        }
        if (PlayerPrefs.GetInt("armor60") == 1)
        {
            armor60.SetActive(true);
        }
        if (PlayerPrefs.GetInt("barels") == 1)
        {
            barels.SetActive(true);
        }
        if (PlayerPrefs.GetInt("food") == 1)
        {
            food_.SetActive(true);
        }

        money.GetComponent<Text>().text = Convert.ToString(PlayerPrefs.GetInt("money"));

    }

    public void buyTune()
    {
        gameObject.GetComponent<AudioSource>().Play();
    }
    public void barelsGet()
    {
        if (PlayerPrefs.GetInt("money") >= 330)
        {
            PlayerPrefs.SetInt("skill", PlayerPrefs.GetInt("skill") + 7);
            PlayerPrefs.SetInt("money", PlayerPrefs.GetInt("money") - 330);
            PlayerPrefs.SetInt("barels", 1);
            for (int i = 0; i < barelsNum; i++)
            {
                PlayerPrefs.SetInt("Barrel (" + i + ")Destroyed", 0);
            }
            buyTune();
        }
        else
        {
            Debug.Log("-");
        }
    }

    public void foodGet()
    {
        if(PlayerPrefs.GetInt("money") >= 440)
        {
            PlayerPrefs.SetInt("skill", PlayerPrefs.GetInt("skill") + 10);
            PlayerPrefs.SetInt("money", PlayerPrefs.GetInt("money") -440);
            PlayerPrefs.SetInt("food", 1);
            for(int i = 0; i < foodNum; i++)
            {
                PlayerPrefs.SetInt("food"+i+"Destroyed",0);
            }
            buyTune();
        }
        else
        {
            Debug.Log("-");
        }
    }
    public void mapGet()
    {
        if (PlayerPrefs.GetInt("MAP") != 1)
        {
            if (PlayerPrefs.GetInt("money") >= 180)
            {
                PlayerPrefs.SetInt("skill", PlayerPrefs.GetInt("skill") + 10);
                PlayerPrefs.SetInt("money", PlayerPrefs.GetInt("money") - 180);
                PlayerPrefs.SetInt("MAP", 1);
                buyTune();
            }
            else
            {
                Debug.Log("-");
            }
        }
        else
        {
            Debug.Log("-");
        }
    }

    public void armor20Get()
    {
        if (PlayerPrefs.GetInt("armor20") != 1)
        {
            if (PlayerPrefs.GetInt("money") >= 1000)
            {
                PlayerPrefs.SetInt("skill", PlayerPrefs.GetInt("skill") + 30);
                PlayerPrefs.SetInt("money", PlayerPrefs.GetInt("money") - 1000);
                PlayerPrefs.SetInt("armor20", 1);
                buyTune();
            }
            else
            {
                Debug.Log("-");
            }
        }
        else
        {
            Debug.Log("-");
        }
    }

    public void armor40Get()
    {
        if (PlayerPrefs.GetInt("armor40") != 1)
        {
            if (PlayerPrefs.GetInt("money") >= 1500)
            {
                PlayerPrefs.SetInt("skill", PlayerPrefs.GetInt("skill") + 50);
                PlayerPrefs.SetInt("money", PlayerPrefs.GetInt("money") - 1500);
                PlayerPrefs.SetInt("armor40", 1);
                buyTune();
            }
            else
            {
                Debug.Log("-");
            }
        }
        else
        {
            Debug.Log("-");
        }
    }

    public void armor60Get()
    {
        if (PlayerPrefs.GetInt("armor60") != 1)
        {
            if (PlayerPrefs.GetInt("money") >= 2500)
            {
                PlayerPrefs.SetInt("skill", PlayerPrefs.GetInt("skill") + 100);
                PlayerPrefs.SetInt("money", PlayerPrefs.GetInt("money") - 2500);
                PlayerPrefs.SetInt("armor60", 1);
                buyTune();
            }
            else
            {
                Debug.Log("-");
            }
        }
        else
        {
            Debug.Log("-");
        }
    }


    public void buyPatrons()
    {

        if (PlayerPrefs.GetInt("money") >= 800)
        {
            PlayerPrefs.SetInt("skill", PlayerPrefs.GetInt("skill") + 50);
            PlayerPrefs.SetInt("money", PlayerPrefs.GetInt("money") - 800);
            PlayerPrefs.SetInt("patron", PlayerPrefs.GetInt("patron") + 10);
            buyTune();
        }

    }







    void AdCallbackHandler(ShowResult res)
    {
        if (res == ShowResult.Finished)
        {
            PlayerPrefs.SetInt("money", PlayerPrefs.GetInt("money") + 30);
        }
        else if (res == ShowResult.Skipped)
        {
            Debug.Log("skipped");
        }
        else if (res == ShowResult.Skipped)
        {
            Debug.Log("error");
        }
    }
    public void addMoney()
    {
        ShowOptions options = new ShowOptions();
        options.resultCallback = AdCallbackHandler;
        if (Advertisement.IsReady("rewardedVideo"))
        {
            Advertisement.Show("rewardedVideo", options);
        }
    }

    


}
