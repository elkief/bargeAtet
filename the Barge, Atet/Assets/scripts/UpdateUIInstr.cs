using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpdateUIInstr : MonoBehaviour {

    public TextDescriptionJunkyard3 TextManager = null;
    public int textNumber = 0;

    private void OnTriggerEnter(Collider other)
    {
        TextManager.changeMessage(textNumber);
    }
}
