using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class patTriggerSia : MonoBehaviour {

    public GameObject SiaAudioSource;
    private AudioSource SiaAbilitySound = null;

    GameObject[] visibles = null;
    GameObject[] negVisibles = null;

    public float range = 5;

    public float negRange = 10;

    // Use this for initialization
    void Start()
    {

        if (visibles == null) {
            visibles = GameObject.FindGameObjectsWithTag("SiaObject");
            foreach (GameObject vis in visibles)
            {
                //tan.transform.localScale = new Vector3(0, 0, 0);
                Renderer rend = vis.GetComponent<Renderer>();
                rend.enabled = false;
            }
        }
        if (negVisibles == null)
        {
            negVisibles = GameObject.FindGameObjectsWithTag("SiaObject1");
            foreach (GameObject vis in negVisibles)
            {
                Renderer rend = vis.GetComponent<Renderer>();
                rend.enabled = true;
            }

        }

        SiaAbilitySound = SiaAudioSource.GetComponent<AudioSource>();

    }

    // Update is called once per frame
    void Update()
    {

        if (visibles != null)
        {
            foreach (GameObject vis in visibles)
            {
                if (vis != null)
                {
                    Renderer rend = vis.GetComponent<Renderer>();
                    if (range > Vector3.Distance(this.transform.position, vis.transform.position))
                    {
                        rend.enabled = true;
                    }
                    else
                    {
                        rend.enabled = false;
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
                    Renderer rend = vis.GetComponent<Renderer>();

                    if (negRange > Vector3.Distance(this.transform.position, vis.transform.position))
                    {
                        rend.enabled = false;
                    }
                    else
                    {
                        rend.enabled = true;
                    }
                }
            }

        }


    //GameObject.Find("HuCube").transform.localScale = new Vector3(0, 0, 0);

        
    }
}
