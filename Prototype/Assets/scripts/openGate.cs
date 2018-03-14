using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class openGate : MonoBehaviour {

    public GameObject thisObject;

    //public playerArtifact player;
    
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.layer == 10)
        {
            //if (player.getArtifactNum() > 0) { 
                Destroy(thisObject);
                Destroy(collision.gameObject);
            //}
        }
    }

}
