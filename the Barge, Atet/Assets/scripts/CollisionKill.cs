using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionKill : MonoBehaviour {

    void OnParticleCollision(GameObject other)
    {
        if(other.layer == 11)
        {
            Destroy(other);
        }        
    }
}
