using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class runawayTest : MonoBehaviour {

    public Transform player;
    private UnityEngine.AI.NavMeshAgent agent;

    //public float speed;
    public float distance;

	// Use this for initialization
	void Start ()
    {
            agent = GetComponent<UnityEngine.AI.NavMeshAgent>();
	}
	
	// Update is called once per frame
	void Update ()
    {
        Run();
	}

    void Run()
    {
        if (player.position.y < distance)
        {
            Vector3 moveDirection = this.transform.position - player.transform.position;
            agent.SetDestination(moveDirection);
            //transform.Translate(moveDirection.normalized * speed * Time.deltaTime);
        }

        else
        {
            //transform.Translate()
        }

                


        //agent.SetDestination(runPosition);

    }
}

