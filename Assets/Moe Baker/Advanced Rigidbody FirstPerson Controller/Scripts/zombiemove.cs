using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class zombiemove : MonoBehaviour {

    public GameObject player;
    private Animator anm;
	// Use this for initialization
	void Start () {
        anm = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
        //transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z);
        transform.position = Vector3.MoveTowards(transform.position, player.transform.position, Time.deltaTime*3);
        Vector3 newDir = Vector3.RotateTowards(transform.forward, (player.transform.position - transform.position), 1, 0.0F);

        //transform.position = Vector3.MoveTowards(transform.position, player.transform.position, 0.1f);
        transform.rotation = Quaternion.LookRotation(newDir);
    }
    void OnTriggerEnter(Collider other)
    {
        //transform.position += new Vector3(0,1,0);
        //transform.Rotate(-90,0,0);
        gameObject.SetActive(false);

    }
}
