using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class abilityTriggerAll : MonoBehaviour {

     public createScript spawn;
     public moveScript update;
     public revealScript open;
    
    public GameObject mainCamera;
    public float distance;
    public float smooth;
    public float range;
    
    bool carrying;
    bool visable;
    
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
        if (Input.GetKeyDown(KeyCode.I))
        {
            int x = Screen.width / 2;
            int y = Screen.height / 2;

            Ray ray = mainCamera.GetComponent<Camera>().ScreenPointToRay(new Vector3(x, y));
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit, range))
            {
              
                if (gameObject.tag == "red"){
//                    myObject.GetComponent<MyScript>().MyFunction();
                    
                }
                
                else if (gameObject.tag == "blue"){
                    
                }
                
                else if (gameObject.tag == "green"){
                    
                }
                
            }
            
//            else {
//                
//                if (Heka.carrying)
//        {
//
//            carry(carriedObject);
//            checkDrop();
//           
//        }
//            }
        }
        
	}
}
