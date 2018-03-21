using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GhostFollow : MonoBehaviour {

    public GameObject ghostTarget;
    private Vector3 targetPosition;

    private float speed = 5f;

	// Use this for initialization
	void Start () {
        //ghostTarget = GameObject.Find("ghostTarget");
	}
	

	void Update () {
        
        //targetPosition = new Vector3(ghostTarget.transform.position.x, ghostTarget.transform.position.y, ghostTarget.transform.position.z);
        targetPosition = ghostTarget.GetComponent<Transform>().position;

        this.transform.position = Vector3.MoveTowards(this.transform.position, targetPosition, speed * Time.deltaTime);

    }
}
