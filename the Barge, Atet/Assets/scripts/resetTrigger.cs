using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class resetTrigger : MonoBehaviour {

    public GameObject target;
    public float xStart = 0;
    public float yStart = 0;
    public float zStart = 0;

    private void OnTriggerEnter(Collider collision)
    {
        if(collision.gameObject == target)
        {
            target.transform.position = new Vector3(xStart, yStart, zStart);
        }        
    }
}
