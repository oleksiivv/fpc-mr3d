using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SkillManage : MonoBehaviour
{

    public Text skillCnt;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        skillCnt.GetComponent<Text>().text = PlayerPrefs.GetInt("skill").ToString();
    }
}
