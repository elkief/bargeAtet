using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class openDoor : MonoBehaviour {


    public GameObject door;
    public Score scoreManager;
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
        if (collision.gameObject.name == "hu4")
        {
            scoreManager.AddPoint(1);
            Destroy(door);
            Destroy(gameObject);
        }
    }

}
