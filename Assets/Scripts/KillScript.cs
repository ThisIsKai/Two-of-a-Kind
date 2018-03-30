﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class KillScript : MonoBehaviour {
	public int damageCounter = 1; //how much damage


	void OnTriggerEnter2D (Collider2D coll) { // when the collider is triggered, THEN run this code:

		HealthScript collHealth = coll.gameObject.GetComponent<HealthScript> (); //find the HealthScript
		if(collHealth != null) { //if there IS a HealthScript attached to the object, THEN
			Debug.Log ("Hurt Player"); //run the debug log to say "Hurt Player" so I know it's working, 
			collHealth.playerStats.Health -= damageCounter; // and take the player's health value and subtract the damage amount
			Debug.Log("Subtracting health.");
			} // END if collheatlh 
	}//END ontrigger function
}// END SCRIPT
