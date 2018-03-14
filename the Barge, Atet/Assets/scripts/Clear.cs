using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Clear : MonoBehaviour {

////    public Collider c_Collider; 
////    public Rigidbody Crb;
//	public Material c_Material;
////
        public GameObject clearBlock1;
        public GameObject clearBlock2;
////    
//    public void matClear(){
////        
////         if(Input.GetKey(KeyCode.Space)){ 
////
//        GetComponent<Renderer>().material = c_Material;
////        
////        Crb.detectCollisions = true;
////    }
//    }
    
     public void changeClear(){
        
        if(Input.GetKey(KeyCode.Space)){
         
        GameObject clearBlock1 = (GameObject) GameObject.Instantiate( clearBlock2, transform.position, Quaternion.identity ) ;     
        
        Destroy(clearBlock1);  
        }
        
        
    }
}
    