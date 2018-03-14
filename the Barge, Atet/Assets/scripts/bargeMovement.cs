using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bargeMovement : MonoBehaviour {

    public GameObject thisObject;
    public float startX;
    public float startY;
    public float startZ;
    public float endX;
    public int zDirection = 1;
    public float speed = 1;
    public float delay = 0;
    public float delayTime = 0.25f;

    // Update is called once per frame
    void Update()
    {
        if (Time.time > delay)
        {
            delay = Time.time + delayTime;
            thisObject.GetComponent<Rigidbody>().velocity = new Vector3( speed, 0, (speed / 10) * zDirection);
        }
        else if (thisObject.transform.position.x > endX)
        {
            thisObject.transform.position = new Vector3(startX, startY, startZ);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        zDirection *= -1;
    }
}
