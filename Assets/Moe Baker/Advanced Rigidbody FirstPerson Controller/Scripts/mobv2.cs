using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class mobv2 : MonoBehaviour {

    private bool ismove = false;
    private bool isrun = false,backM=false;
    float slVV = 0;
    public Slider slRotate;
    public GameObject cmr;
    public static int speed;
    void Start()
    {
        backM = false;
        isrun = false;
        speed = 0;

    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0, slVV * 5, 0);
        
        if (Input.GetMouseButtonUp(0))
        {
            speed = 0;
            slRotate.value = 0.5f;
            backM = false;
            isrun = false;
        }
        else if (isrun)
        {
            speed = 1;
            //transform.Translate(new Vector3(1,0,1) * 5 * Time.deltaTime);
            //if(transform.position.x<= -56) { transform.Translate(new Vector3(1, 0, 1) * 10 * Time.deltaTime); }
        }
        else if (backM)
        {
            //transform.Translate(new Vector3(-1, 0, -1) * 5 * Time.deltaTime);
            speed = -1;
        }
        slVV -= 0.5f - slRotate.value;
        


        
    }
    public void MoveForward()
    {
        isrun = true;

        //transform.Translate(Vector3.forward * 8 * Time.deltaTime);
    }

    public void reverMove()
    {
        backM = true;
    }
}
