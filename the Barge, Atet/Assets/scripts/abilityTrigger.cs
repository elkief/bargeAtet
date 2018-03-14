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
        
       if (Input.GetKeyDown("1")){
            ability.abilityClear();
                }
                
        else if (Input.GetKeyDown("2")){
            ability.abilitySolid();
                }
                
         else if (Input.GetKeyDown("3")){
            ability.abilityHeavy();
                }
            }
}
     
    
                
