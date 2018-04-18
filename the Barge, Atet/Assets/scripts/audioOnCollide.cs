using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class audioOnCollide : MonoBehaviour {

	public AudioSource playSource;
    
    void Start(){
        
        playSource = GetComponent<AudioSource> ();
        
    }
    
   void OnCollisionEnter(Collision itHit){
       
       if(itHit.gameObject.tag == "sound"){
      
        playSource.Play();
        }
    } 
}
     
