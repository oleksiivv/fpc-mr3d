using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kill : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject dust;
    int speed = 5;
    void Start()
    {
        dust.SetActive(false);
        Invoke("destr",25f);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward*speed);
    }
    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "hell")
        {
            other.gameObject.SetActive(false);
        }
    }
    void OnTriggerEnter(Collider o)
    {//Android

        Debug.Log(o.gameObject.name);
        if (o.tag == "spider")
        {
            PlayerPrefs.SetInt("skill", PlayerPrefs.GetInt("skill") + 220);
            //o.tag = "killed";
            o.transform.position += new Vector3(0, o.transform.localScale.y/2, 0);
            o.transform.rotation = new Quaternion(180, 0, 0, 0);
            o.GetComponent<AudioSource>().Play();

            o.GetComponent<spidersbehavior>().Die();
            
            //StartCoroutine(dieObj(o.gameObject));
            o.tag = "killed";
        }
       

    }
    IEnumerator dieObj(GameObject dieO)
    {
        yield return new WaitForSeconds(3f);
        dieO.gameObject.SetActive(false);
    }

    public void destr()
    {
        gameObject.SetActive(false);
    }

    public void dustOff()
    {
        dust.SetActive(false);
    }
}
