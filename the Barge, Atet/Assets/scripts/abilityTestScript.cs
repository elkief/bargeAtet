using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class abilityTestScript : MonoBehaviour {

    public Solid solid;
    public Clear clear;
    public Heavy heavy;

    public Collider s_Collider;
    public Collider c_Collider;
    
    public Rigidbody Crb;
    public Rigidbody Srb;
    public Rigidbody Hrb;
    
    public Material c_Material;
    public Material s_Material;
 
    public Camera mainCamera;
	
	// Update is called once per frame
    void Update(){
//	void OnCollisionEnter(Collision collision) {
       
        Ray ray = mainCamera.GetComponent<Camera>().ScreenPointToRay(new Vector3());
            RaycastHit hit;
        
        //determines available distance
            if (Physics.Raycast(ray, out hit))
            {
        Clear c = hit.collider.GetComponent<Clear>();
        Solid s = hit.collider.GetComponent<Solid>();
        Heavy h = hit.collider.GetComponent<Heavy>();
        
       if (c != null){
            testClear();
                }
                
        else if (s != null){
            testSolid();
                }
                
         else if (h != null){
            testHeavy();
                }
            }
    }
    
    public void testClear(){
        
//        Crb.isKinematic = true;  // Deactivated
//        Crb.isKinematic = false; // Activated  

        c_Material = GetComponent<Renderer>().material;
        
        Crb.detectCollisions = true;
    }
    
    public void testSolid(){
        
//        Srb.isKinematic = true;  // Deactivated
//        Srb.isKinematic = false; // Activated 
        
        Srb.detectCollisions = true;
                
        s_Material = GetComponent<Renderer>().material;
    }
    
    public void testHeavy(){
       
//        Hrb.isKinematic = true;  // Deactivated
//        Hrb.isKinematic = false; // Activated 
    }
    
    

}
