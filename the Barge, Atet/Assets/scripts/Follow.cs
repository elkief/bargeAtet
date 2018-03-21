using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Follow : MonoBehaviour {

    UnityEngine.AI.NavMeshAgent agent;
    public Transform target;

    void Start()
    {
        agent = GetComponent<UnityEngine.AI.NavMeshAgent>();
    }

    void Update()
    {
        if(target.position.y < 3)
        {
            agent.SetDestination(target.position);
        }
        else
        {
            agent.SetDestination(new Vector3(0, 0, 0));
        }        
    }
}
