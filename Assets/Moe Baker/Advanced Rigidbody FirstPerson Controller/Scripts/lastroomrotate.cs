using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lastroomrotate : MonoBehaviour {
    public int y = 0;
    private bool ismove = false;

    private bool isrightrotate = false;
    private bool isleftrotate = false;
    private bool isrun = false;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            ismove = true;

        }
        if (Input.GetMouseButtonUp(0))
        {
            ismove = false;
            isleftrotate = false;
            isrightrotate = false;
        }
        if (ismove && isrightrotate)
        {
            y += 2;
        }
        else if (ismove && isleftrotate)
        {
            y -= 2;
        }
        transform.Rotate(0, y, 0);

    }
    public void rightrotate()
    {
        isrightrotate = true;
    }
    public void leftrotate()
    {
        isleftrotate = true;

    }

}


