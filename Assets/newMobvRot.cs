using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class newMobvRot : MonoBehaviour
{

    //public GameObject player;
    // Use this for initialization
    public float y = 0;
    private bool ismove = false;

    private bool isrightrotate = false;
    private bool isleftrotate = false;
    private bool isrun = false;
    public GameObject camera;
    int xR = 0;

    bool isRightRotate = true;
    bool isLeftRotate = true;
    bool isUpRotate = false;
    bool isDownRotate = false;
    int yAngle = 0;
    int backM = 0;
    public GameObject gun;

    public GameObject load;
    //public Button btnD;

    void Start()
    {
        //btnD.gameObject.SetActive(false);

    }

    // Update is called once per frame
    void Update()
    {
        //if (Input.GetKey(KeyCode.Space))
        //{
        //    xR++;
        //}

        ////if (Input.GetMouseButtonDown(0))
        ////{
        ////    isRightRotate = true;
        ////    isLeftRotate=true;

        ////}
        ////if (Input.GetMouseButtonUp(0))
        ////{
        ////    backM = 0;
        ////    ismove = false;
        ////    isleftrotate = false;
        ////    isrightrotate = false;
        ////    isUpRotate = false;
        ////    isDownRotate = false;
        ////}
        //camera.transform.Rotate(0, y, 0,Space.World);
        //camera.gameObject.transform.Rotate(xR, 0, 0,Space.World);

        //if (isrightrotate)
        //{
        //    y += 4f;

        //    //transform.rotation *= Quaternion.Euler(0f, 20f * Time.deltaTime, 0f);
        //}
        //else if (isleftrotate)
        //{
        //    y -= 4f;

        //    //
        //    //y += -50;
        //}


        //if (isUpRotate)
        //{
        //    if (xR >= -45) xR -= 1;
        //}
        //else if (isDownRotate)
        //{
        //    if (xR <= 45) xR += 1;
        //}

        //gun.transform.rotation = camera.gameObject.transform.rotation;

        ////transform.rotation *= Quaternion.Euler(0f, 50f * Time.deltaTime*yAngle, 0f);

        //gameObject.transform.Translate(-Vector3.forward * 5 * Time.deltaTime * backM);



        ///////




    }
    public void rightrotate()
    {
        isrightrotate = true;
        isleftrotate = false;
        y += 4;
        transform.Rotate(0, 4, 0, Space.World);
        //yAngle += 8;


    }
    public void leftrotate()
    {

        //yAngle -= 8;
        isleftrotate = true;
        isrightrotate = false;
        
        transform.Rotate(0, -4, 0, Space.World);

    }
    public void leftUp()
    {
        isleftrotate = false;


    }
    public void rightUp()
    {
        isrightrotate = false;

    }
    public void m()
    {
        load.SetActive(true);
        Invoke("home", 3f);
    }
    public void back()
    {
        //transform.Translate(-Vector3.forward * 25 * Time.deltaTime);
        backM = 1;
    }
    public void UpX()
    {
        //xR--;
        isUpRotate = true;
    }
    public void DownX()
    {
        //xR++;
        isDownRotate = true;
    }

    void home()
    {
        Application.LoadLevel(0);
    }

}
