using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class SimpleApep : MonoBehaviour {

    private Animator mAnimator;

    public GameObject Apep;

    private Vector3 lastLocation;

    private bool mMove;

	// Use this for initialization
	void Start () {
        mAnimator = GetComponent<Animator>();
        lastLocation = Apep.transform.position;
        mMove = false;
	}
	
	// Update is called once per frame
	void Update () {
		if(lastLocation != Apep.transform.position)
        {
            lastLocation = Apep.transform.position;
            mMove = true;
        }
        else
        {
            mMove = false;
        }

        mAnimator.SetBool("Move", mMove);
	}
}
