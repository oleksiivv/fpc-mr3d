using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Shoot : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject pool;
    public GameObject player;
    public AudioSource source;
    bool ISshoot = false;

    public GameObject fire;


    void Start()
    {
        source = GetComponent<AudioSource>();
        fire.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        //if (Application.loadedLevel != 1)
        //{

        //    if (Input.GetMouseButton(0))
        //    {
        //        //shoot();
        //        Instantiate(pool, transform.position, transform.rotation);
        //        //pool.transform.Translate(-Vector3.forward * 3);
        //        source.Play();

        //    }
        //}
        if (ISshoot)
        {
            //shoot();
            Instantiate(pool, transform.position, transform.rotation);
            //pool.transform.Translate(-Vector3.forward * 3);
            source.Play();

        }
        if (Input.GetMouseButtonUp(0))
        {
            ISshoot = false;

        }

  


    }
    public void shoot()
    {
        if (PlayerPrefs.GetInt("Gun") == 1 && PlayerPrefs.GetInt("patron")>0)
        {
            
            Instantiate(pool, player.transform.position, transform.rotation);
            //Instantiate(pool, transform.position, transform.rotation);
            //pool.transform.Translate(-Vector3.forward * 3);
            source.Play();
            //Instantiate(fire,transform.position,Quaternion.identity);
            fire.SetActive(true);
            //fire.transform.position = transform.position;
            Invoke("fireDes", 0.1f);
            //pool.transform.Translate(-Vector3.forward * 3);
            //source.Play();
            PlayerPrefs.SetInt("patron", PlayerPrefs.GetInt("patron") - 1);
        }
    }

    public void fireDes()
    {
        fire.SetActive(false);
    }
}
