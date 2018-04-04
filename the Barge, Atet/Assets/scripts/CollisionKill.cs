using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionKill : MonoBehaviour {

    public GameObject Gate;
    public GameObject Beam;
    public GameObject target;
    private bool check = false;
    private int numChecks = 0;

    public void Update()
    {
        if(check && numChecks < 100)
        {
            Gate.transform.position += new Vector3(0, .01f, 0);
            check = false;
            numChecks++;
        }
        if(numChecks >= 100)
        {
            Destroy(target);
            Destroy(Beam);
        }
    }

    void OnParticleCollision(GameObject other)
    {
        if(other.layer == 11)
        {
            //Destroy(other);
            //Gate.transform.position += new Vector3(0, 1, 0);
            check = true;
        }        
    }
}
