using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GhostTarget : MonoBehaviour {

    public GameObject ghostTarget;
    private float timer = 0.5f;

    bool activated = false;

    void Update()
    {
        if (activated)
        {
            if (timer > 0)
            {
                timer -= Time.deltaTime;
            }
            if (timer <= 0)
            {
                UpdatePosition();
                timer = 0.5f;
            }
        }
    }

    public void activate()
    {
        activated = true;
    }

    void UpdatePosition()
    {

        ghostTarget.transform.position = transform.position;
    }
}
