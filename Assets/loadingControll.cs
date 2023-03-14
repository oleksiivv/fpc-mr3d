using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class loadingControll : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject fst, sec;
    int act = -1;
    void Start()
    {
        StartCoroutine(load());
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    IEnumerator load()
    {
        while (true)
        {
            

            if (act > 2) act = -1;

            if (act == -1)
            {
                fst.SetActive(true);
                sec.SetActive(true);
                
            }
            else if (act == 0)
            {
                fst.SetActive(true);
                sec.SetActive(false);
            }
            else if (act == 1)
            {
                fst.SetActive(false);
                sec.SetActive(false);
            }
            else if (act == 2)
            {
                fst.SetActive(true);
                sec.SetActive(false);
            }
            act++;
            yield return new WaitForSeconds(0.5f);
        }
    }
}
