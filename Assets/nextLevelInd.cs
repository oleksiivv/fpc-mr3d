using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class nextLevelInd : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Invoke("Ind",9f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Ind()
    {
        Application.LoadLevel(4);
    }
}
