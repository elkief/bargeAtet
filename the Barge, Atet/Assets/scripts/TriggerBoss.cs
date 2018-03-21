using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerBoss : MonoBehaviour {

    public GameObject boss;
    public GameObject spawner;

    public GameObject door;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnCollisionEnter(Collision collision)
    {
        GameObject newBoss = GameObject.Instantiate(boss, spawner.transform.position, spawner.transform.rotation) as GameObject;
        Destroy(door);
        Destroy(gameObject);
    }

}
