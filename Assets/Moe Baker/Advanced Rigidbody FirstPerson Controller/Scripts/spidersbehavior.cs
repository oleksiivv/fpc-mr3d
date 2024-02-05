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

    private UnityEngine.AI.NavMeshAgent nav;

    // Use this for initialization
    void Start()
    {

        nav = GetComponent<UnityEngine.AI.NavMeshAgent>();

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

    public void Die(){
        nav.enabled = false;
        player.GetComponent<mobv>().quests.CompleteQuest(ExtraQuests.KILL_THREE_SPIDER);

        gameObject.GetComponent<spidersbehavior>().enabled = false;
        gameObject.GetComponent<Animation>().enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (wall.transform.position.x!=140 && player.transform.position.z <= -52)
        {
            try{
                nav.SetDestination(player.transform.position);
            } catch {
                Debug.Log("Error navmesh "+gameObject.name);
            }
            // Vector3 newDir = Vector3.RotateTowards(transform.forward, (player.transform.position - transform.position), 1, 0.0F);

            // transform.position = Vector3.MoveTowards(transform.position, player.transform.position, 0.4f* Time.timeScale);
            // Vector3 dir = new Vector3(0,0,0);
            // transform.rotation = Quaternion.LookRotation(newDir);
        }

        if (wall.transform.position.x == 140)
        {
            //nav.isStopped=true;
            transform.position = new Vector3(transform.position.x,- 10, transform.position.z);
        }
        else
        {
            //nav.isStopped=false;
            transform.position = new Vector3(transform.position.x, 0, transform.position.z);
        }
        //Debug.Log("x: "+ Convert.ToString(Math.Abs(player.transform.position.x - transform.position.x))+"| y: "+ Convert.ToString(Math.Abs(player.transform.position.z - transform.position.z)));
    }

}
