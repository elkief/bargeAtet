using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextDescriptionJunkyard3 : MonoBehaviour {

    public Text UIText;
    public int currentText = 0;
    public GameObject barge = null;

    public string GameObjective = "Game Objective:\n" + "Open all of the gates so that the barge can make it through the level.\n";
    public string GameOver = "Game Over. :(\n";
    public string winMessage = "You won!\n" + " \n" + "Use the 'Back to Menu' button to return to the menu.\n";
    public string buttonInstructions = "press 1 to toggle the green walls and platforms\n" + "press Tab to toggle UI\n" + "hold shift to run.\n";
    private string pointZero = "Current Objective: Cross the bridge and use the toggle ability to find the bug in the puzzle.";
    private string pointOne = "Current Objective: Enter the beam puzzle room and step on the blue platform in front of one of the towers.\n"
                           + "Use the 'c' and 'v' keys to rotate the tower so that the beam connects with the door and then collect the bug.\n";
    private string pointTwo = "Current Objective: Move to the platform puzzle area and capture the bug.\n";

    // Use this for initialization
    void Start()
    {
        currentText = 0;
        UIText.text = GameObjective + " \n" + pointZero + " \n" + buttonInstructions;

    }

    public void changeMessage(int place)
    {
        string newMessage = " \n";

        if(place == 0)
        {
            newMessage = pointZero + newMessage;
        }
        else if (place == 1)
        {
            newMessage = pointOne + newMessage;
        }
        else if (place == 2)
        {
            newMessage = pointTwo + newMessage;
        }

        UIText.text = GameObjective + " \n" +  newMessage + " \n" + buttonInstructions;

        if (place == 50)
        {
            UIText.text = winMessage;
        }
    }
}
