using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpiderAI : MonoBehaviour
{
    public Vector3 destination;

    public UnityEngine.AI.NavMeshAgent nav;

    // Update is called once per frame
    void Update()
    {
        nav.SetDestination(destination);
    }
}
