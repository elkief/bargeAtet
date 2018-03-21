using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Follow : MonoBehaviour {

    UnityEngine.AI.NavMeshAgent agent;
    public GameObject target;
    public float xStart = 0;
    public float yStart = 0;
    public float zStart = 0;

    void Start()
    {
        agent = GetComponent<UnityEngine.AI.NavMeshAgent>();
    }

    void Update()
    {
        if(target.GetComponent<Transform>().position.x > 118)
        {
            agent.SetDestination(target.GetComponent<Transform>().position);
        }
        else
        {
            agent.SetDestination(new Vector3(xStart, yStart, zStart));
        }        
    }
}
