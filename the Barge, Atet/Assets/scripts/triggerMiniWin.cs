using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class triggerMiniWin : MonoBehaviour {

    public TextDescriptionJunkyard3 textToChange = null;

    private void OnTriggerEnter(Collider other)
    {
        textToChange.subtractBugs(10000);
    }
}
