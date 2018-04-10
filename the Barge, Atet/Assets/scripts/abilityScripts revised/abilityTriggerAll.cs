using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class abilityTriggerAll : MonoBehaviour {

     public createScript create;
     //public moveScript move;
     public revealScript reveal;
    
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
//<<<<<<< HEAD
////                    move.Update ();
//=======
//                    //move.update ();
//>>>>>>> 199f6a18716278f7ba43b8aebbe3cacf2334f7d3
//                        
                }
                
                else if (gameObject.tag == "blue"){
                  
                    reveal.open();
                    
                }
                
                else if (gameObject.tag == "green"){
                    
                    create.spawn();
                    
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
