using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class HealthScript : MonoBehaviour{
	
	public class PlayerStats {	//creating a new class for my Player's Health Stats
		public float Health = 100f; //seting the starting health value of the player
		public Text healthReadOut; //creating the variable for the text that shows the player's current health
		//public bool isGameOver; //game over bool
	} //END PUBLIC CLASS PlayerStats

	public PlayerStats playerStats = new PlayerStats ();  //defining my player stats

		void Start () { //START FUNCTION
//		bool isGameOver = false; //set bool to false
		playerStats.healthReadOut = GameObject.Find ("PlayerHealthText").GetComponent<Text> (); //setting my readout to the text object
		} // END START


		void Update () {//UPDATE FUNCTION
		playerStats.healthReadOut.text = " " + playerStats.Health.ToString(); //telling the text to include the current health value fo the player
//			if (playerStats.Health <= 0f) { //if the player's health runs out, THEN
//			bool isGameOver = true; //set game over bool to true
//			} // END GAMEOVER
		} //END UPDATE
	} //END HEALTHSCRIPT
