using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Create different wave types
public class waveTypes //: MonoBehaviour
{

	//Sinus waves
	public static float SinXWave(
		Vector3 position, 
		float speed, 
		float scale,
		float waveDistance,
		float noiseStrength, 
		float noiseWalk,
        float timeSinceStart) 
	{
        float x = position.x;
        float y = 0f;
        float z = position.z;

        //Using only x or z will produce straight waves
		//Using only y will produce an up/down movement
		//x + y + z rolling waves
		//x * z produces a moving sea without rolling waves

		float waveType = z;

        y += Mathf.Sin((timeSinceStart * speed + waveType) / waveDistance) * scale;

        //Add noise to make it more realistic
        y += Mathf.PerlinNoise(x + noiseWalk, y + Mathf.Sin(timeSinceStart * 0.1f)) * noiseStrength;

        return y;
	}
}	
//// Use this for initialization
//	void Start () {
//		
//	}
//	
//	// Update is called once per frame
//	void Update () {
//		
//	}
//}
