using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeftRotate : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject player;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnMouseDown()
    {
        player.transform.Rotate(0,2,0);
    }
}
