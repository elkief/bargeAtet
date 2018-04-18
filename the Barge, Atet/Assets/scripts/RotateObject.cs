using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateObject : MonoBehaviour {

    public GameObject rotateObject;
    public int forward = 0;
    private Vector3 rotateRight = new Vector3(0, 10, 0);
    private Vector3 rotateRightFast = new Vector3(0, 15, 0);
    private Vector3 rotateLeft = new Vector3(0, -10, 0);
    private Vector3 rotateLeftFast = new Vector3(0, -15, 0);

    private void OnTriggerStay(Collider other)
    {
        if(Input.GetKey(KeyCode.V))
        {
            rotateObject.transform.Rotate(rotateRightFast * Time.deltaTime);
        }
        else if (Input.GetKey(KeyCode.C))
        {
            rotateObject.transform.Rotate(rotateLeftFast * Time.deltaTime);
        }
    }
}
