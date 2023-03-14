using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mobvlastroom : MonoBehaviour
{
    // Start is called before the first frame update
    bool leftRR = false;
    bool rightRR=false;
    public GameObject camera;
    public float y = 0;
    bool run = false;
    bool backM = false;

    public static int speed = 0;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        if (Input.GetMouseButtonUp(0))
        {
            backM = false;
            leftRR = false;
            rightRR = false;
            run = false;
            speed = 0;
        }
        else if (rightRR==true)
        {
            //transform.position += new Vector3(0.03f,0,0);
           y =2.5f;
            gameObject.transform.Rotate(0, y, 0);
        }
        else  if (leftRR==true)
        {
            y =-2.5f;
            gameObject.transform.Rotate(0, y, 0);
            //transform.position -= new Vector3(0.03f, 0, 0);
        }
        
        else if (run)
        {
            transform.Translate(Vector3.forward /10);
            //speed = 1;
        }
        else if (backM)
        {
            transform.Translate(-Vector3.forward / 10);
            //speed = -1;
        }
        //gameObject.transform.Rotate(0, y, 0);
    }
    public void leftLR()
    {
        //transform.position += new Vector3(2,0,0);
        rightRR = false;
        leftRR = true;
        
        
    }
    public void rightLR()
    {
        leftRR = false;
        rightRR = true;
        
        //transform.position -= new Vector3(2, 0, 0);
        //transform.Translate(Vector3.right *10* Time.deltaTime);
    }

    public void moveForward()
    {
        
        run = true;
    }
    public void reverseMove()
    {
        backM = false;
    }


    
}
