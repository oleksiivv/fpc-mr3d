using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveTypeController : MonoBehaviour
{
    // Start is called before the first frame update
    int type = 0;
    public GameObject firstType, secondType;
    void Start()
    {
        type = PlayerPrefs.GetInt("MoveType");
        if (PlayerPrefs.GetInt("MoveType")==1){
            

            firstType.gameObject.SetActive(false);
            secondType.gameObject.SetActive(true);
        }
        else
        {
            firstType.gameObject.SetActive(true);
            secondType.gameObject.SetActive(false);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
        PlayerPrefs.SetInt("MoveType",type);
        if (type == 0)
        {
            firstType.gameObject.SetActive(true);
            secondType.gameObject.SetActive(false);
        }
        else
        {
            firstType.gameObject.SetActive(false);
            secondType.gameObject.SetActive(true);
        }
    }

    public void changeType()
    {
        type++;
        if (type>1)
        {
            type = 0;
        }
    }
}
