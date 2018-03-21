using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class abilityTestScript : MonoBehaviour {

    public float range;

    public Clear clear;
    public Solid solid;
    public Collider c_Collider;  
    public Collider s_Collider;  
    public Rigidbody Crb;
    public Rigidbody Srb;
    public Material c_Material;
    public Material s_Material;
    public Camera mainCamera;
    
    public static bool queriesHitTriggers;
       
//    public GameObject clearBlock1;
//    public GameObject clearBlock2;
//    public GameObject solidBlock;
    
    
	
	// Update is called once per frame
    void Update(){
        int x = Screen.width / 2;
        int y = Screen.height / 2;
        Ray ray = mainCamera.GetComponent<Camera>().ScreenPointToRay(new Vector3(x, y));
            RaycastHit hit;
        
        //determines available distance
            if (Physics.Raycast(ray, out hit, range))
            {
//                OnMouseDown();
        Clear c = hit.collider.GetComponent<Clear>(); 
        Solid s = hit.collider.GetComponent<Solid>(); 
        
        if (c != null){
            testClear();
//             clear.matClear();
             clear.changeClear();
                }
        
         else if (s != null){
            testSolid();
//             clear.matClear();
             solid.changeSolid();
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
//     
    public void testSolid(){
        
        if(Input.GetKey(KeyCode.Alpha2)){ 

        Crb.detectCollisions = true;
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

