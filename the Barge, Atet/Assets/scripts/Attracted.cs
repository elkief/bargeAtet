using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//https://answers.unity.com/questions/599949/3d-gravity-towards-one-object.html
public class Attracted : MonoBehaviour {


    public GameObject attractedTo;
    public float strengthOfAttraction = 5.0f;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        Vector3 direction = attractedTo.transform.position - transform.position;
        GetComponent<Rigidbody>().AddForce(strengthOfAttraction * direction);
	}
}
