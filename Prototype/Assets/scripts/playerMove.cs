using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMove : MonoBehaviour {

	public float speed;
    public float turnspeed;
    
    public GameObject laserBullet;
    
//    public int laserHit = 0;
    
    public float bulletSpeed;
    public float mouseHoldCount;
	// Use this for initialization

	
	// Update is called once per frame
	void Update () {
       
        transform.Translate(0f, 0f, Input.GetAxis("Vertical") * speed);
        transform.Rotate(0f, Input.GetAxis("Horizontal"), 0f);
    }
}
