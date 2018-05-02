using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HideUI : MonoBehaviour {

    public bool isHidden;
    public bool beingPressed;
    public GameObject UIDisplay;

    public AudioSource playSource;

    // Use this for initialization
    void Start () {
        isHidden = false;
        beingPressed = false;
    }
	
	// Update is called once per frame
	void Update () {
	    if (Input.GetKey(KeyCode.I))
        {
            playSource.Play();
            if (!beingPressed)
            {
                if (isHidden)
                {
                    UIDisplay.SetActive(true);
                    isHidden = false;
                }
                else
                {
                    UIDisplay.SetActive(false);
                    isHidden = true;
                }
            }
            beingPressed = true;
        }
        else
        {

            beingPressed = false;
        }
	}
}
