using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MinigameTextManager : MonoBehaviour {

    public Text UIText;
    public TextDescriptionJunkyard3 mainText = null;

    float min = 5;
    float sec = 0;

    float startTime = 0;

    // Use this for initialization
    void Start () {
        UIText.text = "";
        startTime = Time.time;
	}
	
	// Update is called once per frame
	void Update () {
        float t = Time.time - startTime;

        string minutes = "5";
        string seconds = "00";

        if (t < 300)
        {
            minutes = (4 - ((int)t / 60)).ToString();
            seconds = (60 - (t % 60)).ToString();
        }
        else
        {
            minutes = "0";
            seconds = "00.0000";
            mainText.subtractBugs(-100);
        }

        UIText.text = "Time Left:\n" + minutes + ":" + seconds;
		
	}
}
