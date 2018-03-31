using System.Collections;
using System.Collections.Generic;
using UnityEngine;


//https://www.youtube.com/watch?v=KU2CKBlCAxQ
//Related code tutorial https://www.youtube.com/watch?v=GANwdCKoimU
public class ClickToMoveApep : MonoBehaviour {


    //private Animator mAnimator;

    public LayerMask whatCanBeClickedOn;

    private UnityEngine.AI.NavMeshAgent mNavMeshAgent;

	// Use this for initialization
	void Start () {

        mNavMeshAgent = GetComponent<UnityEngine.AI.NavMeshAgent>();


    }
	
	// Update is called once per frame
	void Update () {

        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

        RaycastHit hit;

        if (Input.GetMouseButtonDown(0))
            if (Physics.Raycast(ray, out hit, 100))
            {
                mNavMeshAgent.destination = hit.point;
                //mNavMeshAgent.SetDestination(hit.point);
            }

        if (mNavMeshAgent.remainingDistance <= mNavMeshAgent.stoppingDistance)
        {
            //mRunning = false;
        }
	}
}
