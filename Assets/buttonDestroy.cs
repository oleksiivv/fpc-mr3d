using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class buttonDestroy : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
         if(Application.loadedLevel==2)
        {
            gameObject.SetActive(false);
        }
    }
}
