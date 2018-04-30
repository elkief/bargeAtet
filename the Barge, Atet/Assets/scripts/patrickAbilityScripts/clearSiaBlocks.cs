using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class clearSiaBlocks : MonoBehaviour {

    private AudioSource SiaAbilitySound = null;

    GameObject[] visibles = null;
    GameObject[] negVisibles = null;

    public float range = 20;

    public float negRange = 20;

    // Use this for initialization
    void Start()
    {


        if (visibles == null)
        {
            visibles = GameObject.FindGameObjectsWithTag("SiaObject");
        }
        if (negVisibles == null)
        {
            negVisibles = GameObject.FindGameObjectsWithTag("SiaObject1");

        }

    }


    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "hu4")
        {
            if (visibles != null)
            {
                foreach (GameObject vis in visibles)
                {
                    if (vis != null)
                    {
                        if (range > Vector3.Distance(this.transform.position, vis.transform.position))
                        {
                            Destroy(vis);
                        }
                    }
                }

            }

            if (negVisibles != null)
            {
                foreach (GameObject vis in negVisibles)
                {
                    if (vis != null)
                    {
                        if (negRange > Vector3.Distance(this.transform.position, vis.transform.position))
                        {
                            Destroy(vis);
                        }
                    }
                }

            }
        }
    }
    // Update is called once per frame
}
