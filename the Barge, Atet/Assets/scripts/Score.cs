using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour {

    public Text scoreText;
    public int maxScore = 5;
    public int totalScore = 0;
    public int winScore = 5;
    public GameObject barge = null;

    int score;

	// Use this for initialization
	void Start () {
        score = 0;
        totalScore = 0;
        scoreText.text = "Move all the obsticals.\n";
            
    }

    // Update is called once per frame
    public void AddPoint(int points) {
        score++;
        totalScore =+ points;
  
        if (totalScore == -10)
        {
            scoreText.text = "Game Over. :(";
        }
        else if (totalScore >= winScore)
        {
            scoreText.text = "You won!\n";
        }
        
	}
}
