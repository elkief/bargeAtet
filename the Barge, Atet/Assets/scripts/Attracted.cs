using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//https://answers.unity.com/questions/599949/3d-gravity-towards-one-object.html
public class Attracted : MonoBehaviour {


    public GameObject[] attractedTo;
    public float strengthOfAttraction = 5.0f;

	// Use this for initialization
	void Start () {
        if (attractedTo == null)
        {
            attractedTo = GameObject.FindGameObjectsWithTag("pulled");
            Debug.Log(attractedTo);
        }

        foreach (GameObject obj in attractedTo)
        {

            Vector3 direction = obj.transform.position - transform.position;
            obj.GetComponent<Rigidbody>().AddForce(strengthOfAttraction * direction);
            Debug.Log(obj);
        }

    }
	
	// Update is called once per frame
	void Update () {


        foreach (GameObject obj in attractedTo)
        {
            
            Vector3 direction = obj.transform.position - transform.position;
            obj.GetComponent<Rigidbody>().AddForce(strengthOfAttraction * direction);
            Debug.Log(obj);
        }

        Destroy(gameObject, 5);
    }


}
