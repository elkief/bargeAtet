using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class openDoor : MonoBehaviour {


    public GameObject door;
    public GameObject chime;
    public GameObject rock;
    private AudioSource chimeSound;
    private AudioSource rockSound;
    // Use this for initialization
    void Start()
    {
        chimeSound = chime.GetComponent<AudioSource>();
        rockSound = rock.GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "hu4")
        {
            if (chimeSound != null)
                chimeSound.Play();
            if (rockSound != null)
                rockSound.Play();

            Destroy(door);
            Destroy(gameObject);
        }
    }

}
