using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class abilityScript : MonoBehaviour {

    public Solid solid;
    public Clear clear;
    public Heavy heavy;

    public Collider s_Collider;
    public Collider c_Collider;
    
    public Rigidbody Crb;
    public Rigidbody Srb;
    public Rigidbody Hrb;
    
    public Material c1_Material;
    public Material c2_Material;
    public Material s1_Material;
    public Material s2_Material;
    
    public GameObject carriedObject;
    public Camera mainCamera;
    
    
//    void start(){
//        
//        Crb = GetComponent<Rigidbody>();
////        Crb.isKinematic = false; // Activated
//          Crb.detectCollisions = true;
//       
//        Srb = GetComponent<Rigidbody>();
////        Srb.isKinematic = true;  // Deactivated
//        
//        Hrb = GetComponent<Rigidbody>();
////        Hrb.isKinematic = false; // Activated
//        
//    }
    
    //triggers Sia' dispell-illusion ability
        public void abilityClear(){
            
               //allows object to trigger an effect when within sight and range
		Ray ray = mainCamera.GetComponent<Camera>().ScreenPointToRay(new Vector3());
            RaycastHit hit;
        
        //determines available distance
            if (Physics.Raycast(ray, out hit))
            {
               
            Clear c = hit.collider.GetComponent<Clear>();
                
            if (c != null){
//                 
//                Crb.isKinematic = true;  // Deactivated
//                Crb.isKinematic = false; // Activated
                
                c2_Material = GetComponent<Renderer>().material;
                Crb.detectCollisions = false;
            
//         c2_Material = GetComponent<Renderer>().material;
                
            } 
        }}
    
    
        //triggers Hu's create-solid ability
        public void abilitySolid(){
               //allows object to trigger an effect when within sight and range
		Ray ray = mainCamera.GetComponent<Camera>().ScreenPointToRay(new Vector3());
            RaycastHit hit;
        
        //determines available distance
            if (Physics.Raycast(ray, out hit))
            {
              
                
            Solid s = hit.collider.GetComponent<Solid>();
            
            if (s != null){
                
                Srb.isKinematic = false; // Activated
                Srb.isKinematic = true;  // Deactivated
                
         s1_Material = GetComponent<Renderer>().material;
       
            }
        } }
    
    
    //triggers heka's heavy-lifting ability 
        public void abilityHeavy(){
               //allows object to trigger an effect when within sight and range
		Ray ray = mainCamera.GetComponent<Camera>().ScreenPointToRay(new Vector3());
            RaycastHit hit;
        
        //determines available distance
            if (Physics.Raycast(ray, out hit))
            {
              
            
            Heavy h = hit.collider.GetComponent<Heavy>();
                
            if (h != null){
                    Hrb.isKinematic = true;  // Deactivated
                    Hrb.isKinematic = false; // Activated
                }
        }}
}