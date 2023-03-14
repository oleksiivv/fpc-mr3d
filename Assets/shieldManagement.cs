using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class shieldManagement : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject imageShield;
    public Text textShield;
    void Start()
    {
        imageShield.SetActive(false);
        textShield.gameObject.SetActive(true);
        textShield.GetComponent<Text>().text = "";
        if (PlayerPrefs.GetInt("armor20") == 1)
        {
            imageShield.SetActive(true);
            textShield.GetComponent<Text>().text = "20%";
        }
        if (PlayerPrefs.GetInt("armor40") == 1)
        {
            imageShield.SetActive(true);
            textShield.GetComponent<Text>().text = "40%";
        }
        if (PlayerPrefs.GetInt("armor60") == 1)
        {
            imageShield.SetActive(true);
            textShield.GetComponent<Text>().text = "60%";
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
