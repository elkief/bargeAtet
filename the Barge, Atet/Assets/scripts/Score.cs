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
    public string GameObjective = "Open all the gates.\n";
    public string GameOver = "Game Over. :(\n";
    public string winMessage = "You won!\n";
    public string tabInstruction = "press Tab to toggle UI\n";

    int score;

	// Use this for initialization
	void Start () {
        score = 0;
        totalScore = 0;
        scoreText.text = GameObjective + tabInstruction;

    }

    // Update is called once per frame
    public void AddPoint(int points) {
        score++;
        totalScore =+ points;
  
        if (totalScore <= -10)
        {
            scoreText.text = GameOver + tabInstruction;
        }
        else if(totalScore <= 0)
        {
            scoreText.text = GameOver + tabInstruction;
        }
        else if (totalScore >= winScore)
        {
            scoreText.text = winMessage + tabInstruction;
        }
        
	}
}
