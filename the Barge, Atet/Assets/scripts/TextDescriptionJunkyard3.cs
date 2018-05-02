using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextDescriptionJunkyard3 : MonoBehaviour {

    public Text UIText;
    public int currentText = 0;
    public int scene = 0;
    public GameObject barge = null;

    public GameObject destroyDoor = null;

    public string GameObjective = "Game Objective:\n" + "Open all of the gates so that the barge can make it through the level.\n";
    public string GameOver = "Game Over. :(\n";
    public string winMessage = "You won!\n" + " \n" + "Use the 'Back to Menu' button to return to the menu.\n";
    public string buttonInstructions = "press 1 to toggle the green walls and platforms\n" + "press Tab to toggle UI\n" + "hold shift to run.\n";
    private string pointZero = "Current Objective: Cross the bridge and use the toggle ability to find the bug in the puzzle.";
    private string pointOne = "Current Objective: Enter the beam puzzle room and step on the blue platform in front of one of the towers.\n"
                           + "Use the 'c' and 'v' keys to rotate the tower so that the beam connects with the door and then collect the bug.\n";
    private string pointTwo = "Current Objective: Move to the platform puzzle area and capture the bug.\n";


    private string networkedGameObjective = "Goal of the game for blue, red, and gree: find all of the bugs and get to the barge before time runs out.\n" +
                                            "Goal of the game for white: stop the other players from reaching their goal.\n" +
                                            "The White player has a cube that can be used to capture players and send them to the respawn point.\n" +
                                            "Press 'I' to hide text, or ESC to open the menu.\n";

    // Use this for initialization
    void Start()
    {
        currentText = 0;
        if(scene == 1)
        {
            UIText.text = GameObjective + " \n" + pointZero + " \n" + buttonInstructions;
        }
        else if(scene == 0)
        {
            UIText.text = networkedGameObjective + "Bugs left to catch: 10\n";
        }

    }

    public int bugsLeft = 10;
    public bool whiteWon = true;

    public void minichangeMessage()
    {
        if (bugsLeft > 0 && bugsLeft <= 10)
        {
            UIText.text = networkedGameObjective + "Bugs left to catch: " + bugsLeft + "\n";
        }
        else if (bugsLeft == 0)
        {
            UIText.text = networkedGameObjective + "All bugs caught, now go through the newly Opened passage.\n";
            Destroy(destroyDoor);
        }
        else if (bugsLeft < 0)
        {
            whiteWon = false;
            UIText.text = networkedGameObjective + "blue, red, and green win!!\n";
        }
        else if (whiteWon == true)
        {
            UIText.text = networkedGameObjective + "white wins!!\n";
        }
    }

    public void subtractBugs(int amount)
    {
        bugsLeft = bugsLeft - amount;
        minichangeMessage();
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
