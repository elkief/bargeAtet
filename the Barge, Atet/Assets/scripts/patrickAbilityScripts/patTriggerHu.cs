using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class patTriggerHu : MonoBehaviour {


    GameObject[] tangibles = null;
    bool active;
    public float range = 5;

    // Use this for initialization
    void Start () {
        active = false;
        if (tangibles == null)
            tangibles = GameObject.FindGameObjectsWithTag("ShareButton");
    }

    // Update is called once per frame
    void Update () {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            if (active == false)
            {
                if (tangibles != null)
                {
                    foreach (GameObject tan in tangibles)
                    {
                        
                        if (range > Vector3.Distance(this.transform.position, tan.transform.position))
                        {
                            tan.transform.localScale = new Vector3(0, 0, 0);
                        }
                    }
                }
                active = true;
            }
            else
            {
                if (tangibles != null)
                {
                    foreach (GameObject tan in tangibles)
                    {
                        if (range > Vector3.Distance(this.transform.position, tan.transform.position))
                        {
                            tan.transform.localScale = new Vector3(1, 1, 1);
                        }
                    }
                }
                active = false;
            }

            //GameObject.Find("HuCube").transform.localScale = new Vector3(0, 0, 0);

        }

        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            if (tangibles != null)
            {
                foreach (GameObject tan in tangibles)
                {
                    tan.transform.localScale = new Vector3(1, 1, 1);
                }
            }
            //GameObject.Find("HuCube").transform.localScale = new Vector3(1, 1, 1);

        }
    }
}
