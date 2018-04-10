using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//only Hu character

public class createScript : MonoBehaviour {
    
    public Renderer rend;
    
    public bool solid;

	// Use this for initialization
	void Start () {
        GetComponent<Collider>().isTrigger = true;
	}
	
	// Update is called once per frame
	void Update () {

	}
    
    
    
    public void spawn() {
        
        if (solid == false){
        rend = GetComponent<Renderer>();
        rend.enabled = true;
        
        GetComponent<Collider>().isTrigger = false;
            
        }
      
        
    }  
}
