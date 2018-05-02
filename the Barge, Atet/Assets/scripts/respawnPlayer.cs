using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class respawnPlayer : MonoBehaviour {

    public GameObject thisPlayer = null;

    public float xPlace = 0;
    public float yPlace = 0;
    public float zPlace = 0;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.layer == 12)
        {
            other.GetComponentInParent<Rigidbody>().transform.position = new Vector3(xPlace, yPlace, zPlace);
        }
    }
}
