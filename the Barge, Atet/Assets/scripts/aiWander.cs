﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class aiWander : MonoBehaviour {
    
     public Transform[] points;
     public int destPoint = 0;
     public NavMeshAgent agent;


    void Start () {
//          
        agent = GetComponent<NavMeshAgent>();
//
//        // Disabling auto-braking allows for continuous movement
//        // between points (ie, the agent doesn't slow down as it
//        // approaches a destination point).
         agent.autoBraking = false;

        GotoNextPoint();
//        
//        NavMeshHit closestHit;
// 
//        if (NavMesh.SamplePosition(gameObject.transform.position, out closestHit, 500f, NavMesh.AllAreas))
//            gameObject.transform.position = closestHit.position;
//        else
//            Debug.LogError("Could not find position on NavMesh!");
//        }
        
//        agent = GetComponent<NavMeshAgent> ();
//if(!agent.isOnNavMesh) {
//    transform.position = somewhereOnmeshPosition;
//    agent.enabled = false;
//    agent.enabled = true;
//}
    }
    

    void GotoNextPoint() {
         // Returns if no points have been set up
        if (points.Length == 0)
            return;

        // Set the agent to go to the currently selected destination.
         agent.destination = points[destPoint].position;

        // Choose the next point in the array as the destination,
        // cycling to the start if necessary.
         destPoint = (destPoint + 1) % points.Length;
        }


    void Update () {
        // Choose the next destination point when the agent gets
        // close to the current one.
         if (!agent.pathPending && agent.remainingDistance < 0.5f)
             GotoNextPoint();
        }
    }
	

