using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionKill : MonoBehaviour {

    public GameObject Gate;

    void OnParticleCollision(GameObject other)
    {
        if(other.layer == 11)
        {
            Destroy(other);
            Gate.transform.position += new Vector3(0, 1, 0);
        }        
    }
}
