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

    public Score scoreManager;

    // Update is called once per frame
    void Update()
    {
        if (thisObject.transform.position.x > endX)
        {
            thisObject.GetComponent<Rigidbody>().velocity = new Vector3(0, 0, 0);
            scoreManager.AddPoint(10);
        }
        else if (Time.time > delay)
        {
            delay = Time.time + delayTime;
            thisObject.GetComponent<Rigidbody>().velocity = new Vector3( speed, 0, (speed / 10) * zDirection);
        }

        if (thisObject.transform.position.z > 6.24)
        {
            zDirection = -1;
        }
        else if (thisObject.transform.position.z < 2.15)
        {
            zDirection = 1;
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.layer == 10)
        {
            scoreManager.AddPoint(-10);
            Destroy(thisObject);            
        }
        else
            zDirection *= -1;
    }
}
