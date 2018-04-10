using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateObject : MonoBehaviour {

    public GameObject rotateObject;
    public int forward = 0;
    private Vector3 rotateRight = new Vector3(0, 1, 0);
    private Vector3 rotateLeft = new Vector3(0, -10, 0);

    private void OnTriggerStay(Collider other)
    {
        if(forward == 0)
        {
            rotateObject.transform.Rotate(rotateRight * Time.deltaTime);
        }
        else
        {
            rotateObject.transform.Rotate(rotateLeft * Time.deltaTime);
        }
    }
}
