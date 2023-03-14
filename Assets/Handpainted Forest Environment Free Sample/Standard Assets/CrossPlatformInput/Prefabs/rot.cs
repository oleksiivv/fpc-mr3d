using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rot : MonoBehaviour {

	// Use this for initialization
	public void left()
    {
        transform.Rotate(transform.rotation.x, transform.rotation.y + 50, transform.rotation.z);
    }
    public void right()
    {
        transform.Rotate(transform.rotation.x, transform.rotation.y - 50, transform.rotation.z);
    }
}
