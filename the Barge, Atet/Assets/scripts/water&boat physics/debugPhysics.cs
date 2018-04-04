using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class debugPhysics : MonoBehaviour {
    
    public static debugPhysics current;

    //Force 2 - Pressure Drag Force
    [Header("Force 2 - Pressure Drag Force")]
    public float velocityReference;

    [Header("Pressure Drag")]
    public float C_PD1 = 2f;
    public float C_PD2 = 2f;
    public float f_P = 0.5f;

    [Header("Suction Drag")]
    public float C_SD1 = 2f;
    public float C_SD2 = 2f;
    public float f_S = 0.5f;

    //Force 3 - Slamming Force
    [Header("Force 3 - Slamming Force")]
    //Power used to ramp up slamming force
    public float p = 2f;
    public float acc_max;
    public float slammingCheat;
    
	// Use this for initialization
	void Start () {
	       
        current = this;	
        
	}
//	
//	// Update is called once per frame
//	void Update () {
//		
//	}
}
