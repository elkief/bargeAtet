using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class abilityTestScript : MonoBehaviour {

    public Clear clear;
    public Collider c_Collider;  
    public Rigidbody Crb;
    public Material c_Material;
    public Camera mainCamera;
    
    public static bool queriesHitTriggers;
       
//    public GameObject clearBlock1;
//    public GameObject clearBlock2;
//    public GameObject solidBlock;
    
    
	
	// Update is called once per frame
    void Update(){
       
        Ray ray = mainCamera.GetComponent<Camera>().ScreenPointToRay(new Vector3());
            RaycastHit hit;
        
        //determines available distance
            if (Physics.Raycast(ray, out hit))
            {
//                OnMouseDown();
        Clear c = hit.collider.GetComponent<Clear>(); 
         if (c != null){
            testClear();
//             clear.matClear();
             clear.changeClear();
                }
            }
    }
        
//    
//    void OnMouseDown(){
//            
//        Ray ray = mainCamera.GetComponent<Camera>().ScreenPointToRay(new Vector3());
//        RaycastHit hit;
////        
//        //determines available distance
//        if (Physics.Raycast(ray, out hit)){
//          
//        Clear c = hit.collider.GetComponent<Clear>(); 
//        
//            if (c != null){
//                Crb.detectCollisions = true;
//                clear.changeClear();
//                }
//            }
//        }
//        
//    }
    public void testClear(){
        
        if(Input.GetKey(KeyCode.Alpha1)){ 

        Crb.detectCollisions = false;
    }
    }
//    public void changeClear(){
//        
//        if(Input.GetKey(KeyCode.Space)){
//         
//        GameObject clearBlock1 = (GameObject) GameObject.Instantiate( clearBlock2, transform.position, Quaternion.identity ) ;     
//        
//        Destroy(clearBlock1);  
//        }
//        
//        
//    }
}

