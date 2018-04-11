using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class openwithcube : MonoBehaviour {


    public GameObject door;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "Door")
        {
            Destroy(door);
            Destroy(gameObject);
        }
    }

}
