using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//only Sia player

public class revealScript : MonoBehaviour {
    
    public Renderer rend;
    
    public bool solid;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        
	}
    
    public void open () {
        
        if (solid == true){
        rend = GetComponent<Renderer>();
        rend.enabled = false;
        }
        
    }
}
