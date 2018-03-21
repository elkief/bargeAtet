using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Solid : MonoBehaviour {

	  
    public Material s_Material;
    
    public void changeSolid(){
        
        if(Input.GetKey(KeyCode.Alpha2)){
          
            GetComponent<Renderer>().material = s_Material;
            
        }
        
        
    }
}
