using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class abilityTrigger : MonoBehaviour {

    public abilityScript ability;
    
    
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        
       if (Input.GetKeyDown("space")){
            ability.abilityClear();
                }
                
        else if (Input.GetKeyDown("enter")){
            ability.abilitySolid();
                }
                
         else if (Input.GetKeyDown("shift")){
            ability.abilityHeavy();
                }
            }
}
     
    
                
