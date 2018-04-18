using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[ExecuteInEditMode]
public class DepthTexture : MonoBehaviour {

  private Camera cam;

  void Start () {
    cam = GetComponent<Camera>();
    cam.depthTextureMode = DepthTextureMode.Depth;
  }

}
//	// Use this for initialization
//	void Start () {
//		
//	}
//	
//	// Update is called once per frame
//	void Update () {
//		
//	}
//}
