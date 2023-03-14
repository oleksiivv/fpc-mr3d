using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lastromrot : MonoBehaviour {
    bool ismove = false;
    bool isrun = false;
	// Use this for initialization
	void Start () {
		
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
            isrun = false;
        }
        else if (ismove && isrun)
        {
            transform.Translate(Vector3.forward * 10 * Time.deltaTime);
        }

    }
    public void MoveForward1()
    {
        isrun = true;

        //transform.Translate(Vector3.forward * 8 * Time.deltaTime);
    }
}
