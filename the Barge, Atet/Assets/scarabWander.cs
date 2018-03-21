using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class scarabWander : StateMachineBehaviour {

   
    GameObject Artifact;
    GameObject[] waypoints;
    int currentWP;
    
    void Awake(){
        
        waypoints = GameObject.FindGameObjectsWithTag("point");
        
    }
    
	 // OnStateEnter is called when a transition starts and the state machine starts to evaluate this state
	override public void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex) {
        
        Artifact = animator.gameObject;
        currentWP = 0;
	
	}

	// OnStateUpdate is called on each Update frame between OnStateEnter and OnStateExit callbacks
	override public void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex) {
	
        if(waypoints.Length == 0) return;
        if(Vector3.Distance(waypoints[currentWP].transform.position, Artifact.transform.position) < 3.0f){
            
            currentWP++;
            if(currentWP >= waypoints.Length){
                
                currentWP = 0;
                
            }
            
            //rotate towards target
            var direction = waypoints[currentWP].transform.position - Artifact.transform.position; Artifact.transform.rotation = Quaternion.Slerp(Artifact.transform.rotation, Quaternion.LookRotation(direction), 1.0f * Time.deltaTime); Artifact.transform.Translate(0, 0, Time.deltaTime * 2.0f);
        }
        
	}

	// OnStateExit is called when a transition ends and the state machine finishes evaluating this state
	override public void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex) {
	
	}

	// OnStateMove is called right after Animator.OnAnimatorMove(). Code that processes and affects root motion should be implemented here
	//override public void OnStateMove(Animator animator, AnimatorStateInfo stateInfo, int layerIndex) {
	//
	//}

	// OnStateIK is called right after Animator.OnAnimatorIK(). Code that sets up animation IK (inverse kinematics) should be implemented here.
	//override public void OnStateIK(Animator animator, AnimatorStateInfo stateInfo, int layerIndex) {
	//
	//}
}
