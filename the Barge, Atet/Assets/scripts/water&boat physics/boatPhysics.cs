using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace BoatTutorial{

public class boatPhysics : MonoBehaviour {
    
     //Drags
    public GameObject boatMeshObj;
    public GameObject underWaterObj;
    public GameObject aboveWaterObj;

    //Change the center of mass
    public Vector3 centerOfMass;

    //Script that's doing everything needed with the boat mesh, such as finding out which part is above the water
    private ModifyBoatMesh modifyBoatMesh;

    //Meshes for debugging
    private Mesh underWaterMesh;
    private Mesh aboveWaterMesh;

    //The boats rigidbody
    private Rigidbody boatRB;

    //The density of the water the boat is traveling in
    private float rhoWater = boatPhysicsMath.RHO_OCEAN_WATER;
    private float rhoAir = boatPhysicsMath.RHO_AIR;

    void Awake() 
    {
        boatRB = this.GetComponent<Rigidbody>();
    }

	void Start() 
	{
        //Init the script that will modify the boat mesh
        modifyBoatMesh = new ModifyBoatMesh(boatMeshObj, underWaterObj, aboveWaterObj, boatRB);

        //Meshes that are below and above the water
        underWaterMesh = underWaterObj.GetComponent<MeshFilter>().mesh;
        aboveWaterMesh = aboveWaterObj.GetComponent<MeshFilter>().mesh;
    }

    
    
    void Update()
    {
        //Generate the under water and above water meshes
        modifyBoatMesh.GenerateUnderwaterMesh();

        //Display the under water mesh - is always needed to get the underwater length for forces calculations
        modifyBoatMesh.DisplayMesh(underWaterMesh, "UnderWater Mesh", modifyBoatMesh.underWaterTriangleData);

        //Display the above water mesh
        //modifyBoatMesh.DisplayMesh(aboveWaterMesh, "AboveWater Mesh", modifyBoatMesh.aboveWaterTriangleData);
    }

   
    void FixedUpdate() 
	{
        //Change the center of mass - experimental - move to Start() later
        boatRB.centerOfMass = centerOfMass;

        //Add forces to the part of the boat that's below the water
        if (modifyBoatMesh.underWaterTriangleData.Count > 0)
        {
            AddUnderWaterForces();
        }

        //Add forces to the part of the boat that's above the water
        if (modifyBoatMesh.aboveWaterTriangleData.Count > 0)
        {
            AddAboveWaterForces();
        }
    }
    
    
     //Add all forces that act on the squares below the water
    void AddUnderWaterForces()
    {
        //The resistance coefficient - same for all triangles
        float Cf = boatPhysicsMath.ResistanceCoefficient(
            rhoWater, 
            boatRB.velocity.magnitude,
            modifyBoatMesh.CalculateUnderWaterLength());

        //To calculate the slamming force we need the velocity at each of the original triangles
        List<slammingForceData> slammingForceData = modifyBoatMesh.slammingForceData;

        CalculateSlammingVelocities(slammingForceData);

        //Need this data for slamming forces
        float boatArea = modifyBoatMesh.boatArea;
        float boatMass = 475; //Replace this line with your boat's total mass

        //To connect the submerged triangles with the original triangles
        List<int> indexOfOriginalTriangle = modifyBoatMesh.indexOfOriginalTriangle;

        //Get all triangles
        List<triangleData> underWaterTriangleData = modifyBoatMesh.underWaterTriangleData;
       
        for (int i = 0; i < underWaterTriangleData.Count; i++)
        {
            triangleData triangleData = underWaterTriangleData[i];
            

            //Calculate the forces
            Vector3 forceToAdd = Vector3.zero;

            //Force 1 - The hydrostatic force (buoyancy)
            forceToAdd += boatPhysicsMath.BuoyancyForce(rhoWater, triangleData);

            //Force 2 - Viscous Water Resistance
            forceToAdd += boatPhysicsMath.ViscousWaterResistanceForce(rhoWater, triangleData, Cf);

            //Force 3 - Pressure drag
            forceToAdd += boatPhysicsMath.PressureDragForce(triangleData);

            //Force 4 - Slamming force
            //Which of the original triangles is this triangle a part of
            int originalTriangleIndex = indexOfOriginalTriangle[i];
            slammingForceData slammingData = slammingForceData[originalTriangleIndex];

            forceToAdd += boatPhysicsMath.slammingForce(slammingData, triangleData, boatArea, boatMass);


            //Add the forces to the boat
            boatRB.AddForceAtPosition(forceToAdd, triangleData.center);
        }
    }


    //Add all forces that act on the squares above the water
    void AddAboveWaterForces()
    {
        //Get all triangles
        List<triangleData> aboveWaterTriangleData = modifyBoatMesh.aboveWaterTriangleData;

        //Loop through all triangles
        for (int i = 0; i < aboveWaterTriangleData.Count; i++)
        {
            triangleData triangleData = aboveWaterTriangleData[i];
//Calculate the forces
            Vector3 forceToAdd = Vector3.zero;

            //Force 1 - Air resistance 
			//Replace VisbyData.C_r with your boat's drag coefficient
            forceToAdd += boatPhysicsMath.AirResistanceForce(rhoAir, triangleData, 0);

            //Add the forces to the boat
            boatRB.AddForceAtPosition(forceToAdd, triangleData.center);


            if (triangleData.cosTheta > 0f)
            {
                //Debug.DrawRay(triangleCenter, triangleVelocityDir * 3f, Color.black);
            }

            //Air resistance
            //-3 to show it in the opposite direction to see what's going on
            //Debug.DrawRay(triangleCenter, airResistanceForce.normalized * -3f, Color.blue);
        }
    }
    


    //Calculate the current velocity at the center of each triangle of the original boat mesh
    private void CalculateSlammingVelocities(List<slammingForceData> slammingForceData)
    {
        for (int i = 0; i < slammingForceData.Count; i++)
        {
            //Set the new velocity to the old velocity
            slammingForceData[i].previousVelocity = slammingForceData[i].velocity;

            //Center of the triangle in world space
            Vector3 center = transform.TransformPoint(slammingForceData[i].triangleCenter);

            //Get the current velocity at the center of the triangle
            slammingForceData[i].velocity = boatPhysicsMath.GetTriangleVelocity(boatRB, center);
        }
    }
}
}
    
    
//        //Drags
//        public GameObject underWaterObj;
//
//        //Script that's doing everything needed with the boat mesh, such as finding out which part is above the water
//        private modifyBoatMesh modifyBoatMesh;
//
//        //Mesh for debugging
//        private Mesh underWaterMesh;
//
//        //The boats rigidbody
//        private Rigidbody boatRB;
//
//        //The density of the water the boat is traveling in
//        private float rhoWater = 1027f;
//
//
//	// Use this for initialization
//	void Start () {
//		
//            //Get the boat's rigidbody
//            boatRB = gameObject.GetComponent<Rigidbody>();
//
//            //Init the script that will modify the boat mesh
//            modifyBoatMesh = new modifyBoatMesh(gameObject);
//
//            //Meshes that are below and above the water
//            underWaterMesh = underWaterObj.GetComponent<MeshFilter>().mesh;
//	}
//	
//	// Update is called once per frame
//	void Update () {
//        
//		 //Generate the under water mesh
//            modifyBoatMesh.GenerateUnderwaterMesh();
//
//            //Display the under water mesh
//            modifyBoatMesh.DisplayMesh(underWaterMesh, "UnderWater Mesh", modifyBoatMesh.underWaterTriangleData);
//	}
//    
//     void FixedUpdate()
//        {
//            //Add forces to the part of the boat that's below the water
//            if (modifyBoatMesh.underWaterTriangleData.Count > 0)
//            {
//                AddUnderWaterForces();
//            }
//        }
//
//    
//        //Add all forces that act on the squares below the water
//        void AddUnderWaterForces()
//        {
//            //Get all triangles
//            List<triangleData> underWaterTriangleData = modifyBoatMesh.underWaterTriangleData;
//
//            for (int i = 0; i < underWaterTriangleData.Count; i++)
//            {
//                //This triangle
//                triangleData triangleData = underWaterTriangleData[i];
//
//                //Calculate the buoyancy force
//                Vector3 buoyancyForce = BuoyancyForce(rhoWater, triangleData);
//                  //Add the force to the boat
//                boatRB.AddForceAtPosition(buoyancyForce, triangleData.center);
//
//
//                //Debug
//
//                //Normal
//                Debug.DrawRay(triangleData.center, triangleData.normal * 0.5f, Color.white);
//
//                //Buoyancy
//                Debug.DrawRay(triangleData.center, buoyancyForce.normalized * -0.2f, Color.blue);
//            }
//        }
//
//        //The buoyancy force so the boat can float
//        private Vector3 BuoyancyForce(float rho, triangleData triangleData)
//        {
//            //Buoyancy is a hydrostatic force - it's there even if the water isn't flowing or if the boat stays still
//
//            // F_buoyancy = rho * g * V
//            // rho - density of the mediaum you are in
//            // g - gravity
//            // V - volume of fluid directly above the curved surface 
//
//            // V = z * S * n 
//            // z - distance to surface
//            // S - surface area
//            // n - normal to the surface
//            Vector3 buoyancyForce = rho * Physics.gravity.y * triangleData.distanceToSurface * triangleData.area * triangleData.normal;
//             //The vertical component of the hydrostatic forces don't cancel out but the horizontal do
//            buoyancyForce.x = 0f;
//            buoyancyForce.z = 0f;
//
//            return buoyancyForce;
//        }
//
//}
//}
