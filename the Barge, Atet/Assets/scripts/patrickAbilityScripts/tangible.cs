using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tangible : MonoBehaviour {

    // Use this for initialization
    //GameObject[] tangibles;
    void Start()
    {
        //GetComponent<Collider>.isTrigger = false;
        //if (tangibles == null)
        //    tangibles = GameObject.FindGameObjectsWithTag("ShareButton");
    }
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            //if (tangibles == null)
            //{
            //    foreach (GameObject tan in tangibles)
            //    {
            //        tan.transform.localScale = new Vector3(0, 0, 0);
            //    }
            //}
            GameObject.Find("HuCube").transform.localScale = new Vector3(0, 0, 0);

        }

        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            GameObject.Find("HuCube").transform.localScale = new Vector3(1, 1, 1);

        }
    }
}
