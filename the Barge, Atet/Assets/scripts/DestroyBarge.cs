using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyBarge : MonoBehaviour {

    public Score scoreManager;
    
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.layer == 8)
        {
            Destroy(collision.gameObject);
            scoreManager.AddPoint(-10);
        }
    }
}
