using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
public class spidersbehavior : MonoBehaviour
{

    public GameObject wall;
    public GameObject player;
    private Text message;

    String mess;
    // Use this for initialization
    void Start()
    {

        message = GameObject.Find("message").GetComponent<Text>();


        if (PlayerPrefs.GetString("Language") == "Eng")
        {


            mess = "Spiders are close to you!";

        }
        else if (PlayerPrefs.GetString("Language") == "Ukr")
        {
            mess = "Павуки близько!";

        }
        else if (PlayerPrefs.GetString("Language") == "Esp")
        {

            mess = "¡Las arañas están cerca de ti!";

        }
        else if (PlayerPrefs.GetString("Language") == "Fra")
        {

            mess = "Les araignées sont proches de vous!";

        }
    }

    // Update is called once per frame
    void Update()
    {

        //Vector3 newDir = Vector3.RotateTowards(transform.forward, (player.transform.position - transform.position), 1, 0.0F);

        //transform.position = Vector3.MoveTowards(transform.position, player.transform.position, 0.05f);
        //Vector3 dir = new Vector3(0, 180, newDir.z);
        //transform.rotation = Quaternion.LookRotation(dir);
        //wall.transform.position.x<=127 && 


        //Vector3 newDir = Vector3.RotateTowards(transform.forward, (player.transform.position - transform.position), 1, 0.0F);

        //transform.position = Vector3.MoveTowards(transform.position, player.transform.position, 0.15f);
        //Vector3 dir = new Vector3(newDir.x, 0, newDir.z);
        //transform.rotation = Quaternion.LookRotation(dir);
        //Debug.Log(walls.day);


       

        if (wall.transform.position.x!=140&&player.transform.position.z <= -52)
        {
            Vector3 newDir = Vector3.RotateTowards(transform.forward, (player.transform.position - transform.position), 1, 0.0F);

            transform.position = Vector3.MoveTowards(transform.position, player.transform.position, 0.4f* Time.timeScale);
            Vector3 dir = new Vector3(0,0,0);
            transform.rotation = Quaternion.LookRotation(newDir);
            //transform.position = Vector3.MoveTowards(transform.position, player.transform.position, Time.deltaTime * 2f);

        }
        if (wall.transform.position.x == 140)
        {
            transform.position = new Vector3(transform.position.x,- 10, transform.position.z);
        }
        else
        {
            transform.position = new Vector3(transform.position.x, 0, transform.position.z);
        }
        Debug.Log("x: "+ Convert.ToString(Math.Abs(player.transform.position.x - transform.position.x))+"| y: "+ Convert.ToString(Math.Abs(player.transform.position.z - transform.position.z)));

        //if(Math.Abs(player.transform.position.x-transform.position.x)<30 && Math.Abs(player.transform.position.z - transform.position.z) < 30 && wall.transform.position.x != 140)
        //{
        //    message.text = mess;
        //}
        //if (Math.Abs(player.transform.position.x - transform.position.x) < 10 && Math.Abs(player.transform.position.z - transform.position.z) < 10)
        //{
        //    message.text = "";
        //}


        //else if (wall.transform.position.x >= 127)
        //{
        //    transform.position = new Vector3(transform.position.x, -9, transform.position.z);
        //}
        //else if (wall.transform.position.x <= 127)
        //{
        //    transform.position = new Vector3(transform.position.x, 0, transform.position.z);
        //}
    }

}
