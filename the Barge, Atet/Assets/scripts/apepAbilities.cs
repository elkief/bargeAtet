using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class apepAbilities : MonoBehaviour {

    public GameObject abilityOne;
    public GameObject abilityTwo;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {


        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            Instantiate(abilityOne, transform.position + (transform.forward * 20), transform.rotation);
        }

        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            Instantiate(abilityTwo, transform.position + (transform.forward * 20), transform.rotation);
        }


        if (Input.GetKeyDown(KeyCode.E))
        {
            Instantiate(abilityOne, transform.position + (transform.forward * 20), transform.rotation);
        }

    }
}
