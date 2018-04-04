using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//To save space so we don't have to send millions of parameters to each method
public struct triangleData
{
    //The corners of this triangle in global coordinates
    public Vector3 p1;
    public Vector3 p2;
    public Vector3 p3;

    //The center of the triangle
    public Vector3 center;

    //The distance to the surface from the center of the triangle
    public float distanceToSurface;

    //The normal to the triangle
    public Vector3 normal;

    //The area of the triangle
    public float area;

    //The velocity of the triangle at the center
    public Vector3 velocity;

    //The velocity normalized
    public Vector3 velocityDir;

    //The angle between the normal and the velocity
    //Negative if pointing in the opposite direction
    //Positive if pointing in the same direction
    public float cosTheta;
	
    public triangleData(Vector3 p1, Vector3 p2, Vector3 p3, Rigidbody boatRB, float timeSinceStart)
    {
        this.p1 = p1;
        this.p2 = p2;
        this.p3 = p3;

        //Center of the triangle
        this.center = (p1 + p2 + p3) / 3f;

        //Distance to the surface from the center of the triangle
        this.distanceToSurface = Mathf.Abs(waterController.current.DistanceToWater(this.center, timeSinceStart));

        //Normal to the triangle
        this.normal = Vector3.Cross(p2 - p1, p3 - p1).normalized;

        //Area of the triangle
        this.area = boatPhysicsMath.GetTriangleArea(p1, p2, p3);

        //Velocity vector of the triangle at the center
        this.velocity = boatPhysicsMath.GetTriangleVelocity(boatRB, this.center);

        //Velocity direction
        this.velocityDir = this.velocity.normalized;

        //Angle between the normal and the velocity
        //Negative if pointing in the opposite direction
        //Positive if pointing in the same direction
        this.cosTheta = Vector3.Dot(this.velocityDir, this.normal);
    }
}
//namespace BoatTutorial
//{
//   
//    //To save space so we don't have to send millions of parameters to each method
//public class triangleData : MonoBehaviour {
//
//    //The corners of this triangle in global coordinates
//        public Vector3 p1;
//        public Vector3 p2;
//        public Vector3 p3;
//
//        //The center of the triangle
//        public Vector3 center;
//
//        //The distance to the surface from the center of the triangle
//        public float distanceToSurface;
//
//        //The normal to the triangle
//        public Vector3 normal;
//
//        //The area of the triangle
//        public float area;
//
//        public triangleData(Vector3 p1, Vector3 p2, Vector3 p3)
//        {
//            this.p1 = p1;
//            this.p2 = p2;
//            this.p3 = p3;
//
//            //Center of the triangle
//            this.center = (p1 + p2 + p3) / 3f;
//
//            //Distance to the surface from the center of the triangle
//            this.distanceToSurface = Mathf.Abs(waterController.current.DistanceToWater(this.center, Time.time));
//            
//            //Normal to the triangle
//             this.normal = Vector3.Cross(p2 - p1, p3 - p1).normalized;
//
//            //Area of the triangle
//            float a = Vector3.Distance(p1, p2);
//
//            float c = Vector3.Distance(p3, p1);
//
//            this.area = (a * c * Mathf.Sin(Vector3.Angle(p2 - p1, p3 - p1) * Mathf.Deg2Rad)) / 2f;
//        }
//    }
//}
//
//    
////	// Use this for initialization
////	void Start () {
////		
////	}
////	
////	// Update is called once per frame
////	void Update () {
////		
////	}
////}
