using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class sceneTrigger : MonoBehaviour {


public void goToScene(string chosenScene){

    SceneManager.LoadScene(chosenScene);
}


}
