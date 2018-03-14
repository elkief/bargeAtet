using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class boxTrigger : MonoBehaviour {

    public Vector3 objectOffset;
    public GameObject player;

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Entered the obstacle to the left");
        player.GetComponent<CharacterController>().objectOffset = gameObject.transform.position - player.transform.position;
        player.GetComponent<CharacterController>().objectName = gameObject.name;

    }

    private void OnTriggerExit(Collider other)
    {
        Debug.Log("Exited the obstacle to the left");
        player.GetComponent<CharacterController>().objectName = null;
    }
}
