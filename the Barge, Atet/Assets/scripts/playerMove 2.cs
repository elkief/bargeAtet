using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMove : MonoBehaviour {

	public float speed;
    public float turnspeed;

	
	// Update is called once per frame
	void Update () {
       
        transform.Translate(0f, 0f, Input.GetAxis("Vertical") * speed);
        transform.Rotate(0f, Input.GetAxis("Horizontal"), 0f);
    }
}
