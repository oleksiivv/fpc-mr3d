/*/
* Script by Devin Curry
* www.Devination.com
* www.youtube.com/user/curryboy001
* Please like and subscribe if you found my tutorials helpful :D
* Twitter: https://twitter.com/Devination3D
* Google+ Community: https://plus.google.com/communities/108584850180626452949
* Facebook Page: https://www.facebook.com/unity3Dtutorialsbydevin
/*/
using UnityEngine;
using System.Collections;
using UnityStandardAssets.CrossPlatformInput;
using UnityEngine.UI;
using System;

public class FloatingPlayer2DController : MonoBehaviour
{
    /*public float moveForce = 5, boostMultiplier = 2;
	Rigidbody2D myBody;

	void Start ()
	{
		myBody = this.GetComponent<Rigidbody2D>();
	}
	
	void FixedUpdate ()
	{
		Vector3 moveVec = new Vector3(-CrossPlatformInputManager.GetAxis("Horizontal"),0,
			CrossPlatformInputManager.GetAxis("Vertical"))
			* moveForce;
		bool isBoosting = CrossPlatformInputManager.GetButton("Boost");
		//Debug.Log(isBoosting ? boostMultiplier : 1); //returns boostMultiplier if true, 1 if false
		myBody.AddForce(moveVec * (isBoosting ? boostMultiplier : 1));
	}*/
    public float moveForce = 5, boostMultiplier = 2;
    Rigidbody myBody;
    private Vector3 moveVec;
    private Vector3 moveVec1;
    
    private int val=100;

    
    void Start()
    {
        myBody = this.GetComponent<Rigidbody>();
    }
    void Update()
    {

        moveVec = Vector3.zero;
        moveVec.x = CrossPlatformInputManager.GetAxis("Horizontal");
        moveVec.z = CrossPlatformInputManager.GetAxis("Vertical");
        if (Vector3.Angle(Vector3.forward, moveVec) > 1f)
        {
            Vector3 dir = Vector3.RotateTowards(transform.forward, moveVec, 3, 0.0f);
            transform.rotation = Quaternion.LookRotation(dir);
        }
        transform.position += new Vector3(CrossPlatformInputManager.GetAxis("Horizontal") / 6, 0,
             CrossPlatformInputManager.GetAxis("Vertical") / 6);
    }


    /*public void shoot()
    {
        
        Instantiate(patron,transform.position,transform.rotation);
        patron.tag = "Patron";
        print(patron.tag);
       
    }
    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Enemy")
        {
            val -= 10;
            if (val == 0)
            {
                if (PlayerPrefs.GetInt("Record") < Score)
                {
                    PlayerPrefs.SetInt("Record",Score);
                }
                Application.LoadLevel(1);
            }

        }
    }*/
}