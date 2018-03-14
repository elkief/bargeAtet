using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Drown : MonoBehaviour {

    public GameObject player;
    public Score scoreManager;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
        if (player.transform.position.y < 0)
        {
            scoreManager.AddPoint(-8);
        }

	}
}
