using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//https://www.youtube.com/watch?v=Nc7h5-pLFqg

public class MobaCam : MonoBehaviour {

    public float scrollSpeed;

    public float topbarrier;
    public float botBarrier;
    public float leftBarrier;
    public float rightBarrier;

	// Use this for initialization
	void Start () {
		
    }
	
	// Update is called once per frame
	void Update () {

        //Vector3 pos = transform.position;

        //if (Input.GetKey("w"))
        //{
        //    pos.z += scrollSpeed * Time.deltaTime;
        //}

        //transform.position = pos;



        if (Input.mousePosition.y >= Screen.height * topbarrier)
        {
            transform.Translate(Vector3.up * Time.deltaTime * scrollSpeed, Space.World);
        }

        if (Input.mousePosition.y <= Screen.height * botBarrier)
        {
            transform.Translate(Vector3.down * Time.deltaTime * scrollSpeed, Space.World);
        }


        if (Input.mousePosition.x >= Screen.width * rightBarrier)
        {
            transform.Translate(Vector3.right * Time.deltaTime * scrollSpeed, Space.World);
        }

        if (Input.mousePosition.x <= Screen.width * leftBarrier)
        {
            transform.Translate(Vector3.left * Time.deltaTime * scrollSpeed, Space.World);
        }

    }
}
