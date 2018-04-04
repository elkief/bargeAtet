using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RunawayWithTag : MonoBehaviour {
    // Use this for initialization
    UnityEngine.AI.NavMeshAgent agent;
    public int multiplier;
    public float range;
    public GameObject player;

    void Start()
    {
        agent = GetComponent<UnityEngine.AI.NavMeshAgent>();
        player = GameObject.FindGameObjectWithTag("apep");

    }

    // Update is called once per frame
    void Update()
    {
        Vector3 moveDirection = this.transform.position + ((this.transform.position - player.GetComponent<Transform>().position) * multiplier);
        float distance = Vector3.Distance(this.transform.position, player.GetComponent<Transform>().position);

        if (distance < range)
            agent.SetDestination(moveDirection);
    }
}
