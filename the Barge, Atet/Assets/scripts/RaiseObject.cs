using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RaiseObject : MonoBehaviour {

    public GameObject rasieObject;
    public float force = 10f; 
    public int forward = 0;
    private Vector3 rotateRight = new Vector3(0, 10, 0);
    private Vector3 rotateRightFast = new Vector3(0, 15, 0);
    private Vector3 rotateLeft = new Vector3(0, -10, 0);
    private Vector3 rotateLeftFast = new Vector3(0, -15, 0);

    Rigidbody rb;
    Transform t;

    // Use this for initialization
    void Start()
    {
        rb = rasieObject.GetComponent<Rigidbody>();
        t = rasieObject.GetComponent<Transform>();
    }

    private void OnTriggerStay(Collider other)
    {
        rasieObject.GetComponent<Rigidbody>().AddForce(t.up * force);
    }
}
