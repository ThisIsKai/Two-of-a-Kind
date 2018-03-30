//using System.Collections;
//using System.Collections.Generic;
//using UnityEngine;
//
//public class GoalScript : MonoBehaviour {
//	public GameObject playerRed;
//	public GameObject playerBlue;
//	public GameObject myGoal;
//
//
//	void Start () {
//		playerRed = GameObject.Find("PlayerRedPrefab");
//		playerBlue = GameObject.Find("PlayerBluePrefab");
//	
//	}
//
//
//	void OnCollisionEnter2D(Collision2D collision) { 
//		if (collision.gameObject.myGoal) { //if the tag on the object is 'CameraAnchor" THEN
//			Debug.Log ("Player Hit their Goal!"); // tell me "Player Hit Camera Anchor"
//		}//END CAM COLLISION
//}//END SCRIPT
