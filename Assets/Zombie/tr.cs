﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tr : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "finish")
        {
            
        }
        else if (other.tag == "zombie")
        {

        }
    }
}
