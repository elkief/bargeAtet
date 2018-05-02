using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectTransportOnTrigger : MonoBehaviour {

    public GameObject moveObject;
    public float xPlace = 0;
    public float yPlace = 0;
    public float zPlace = 0;

    private bool found = false;

    private void OnTriggerEnter(Collider other)
    {
        if(found == false)
        {
            moveObject.transform.position = new Vector3(xPlace, yPlace, zPlace);
        }        
    }
}
