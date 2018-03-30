﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeSceneScript : MonoBehaviour {
	public bool isGameOver;

		void Start () {
		
	}//END START FUNCTION
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown(KeyCode.P)){ //if the spacebar is pressed, THEN
			SceneManager.LoadScene(1); //load the scene assigned as number 1 in the build (should be the platformer scene)
		}// END LOAD GAME

		if (Input.GetKeyDown (KeyCode.R)){ // if the R key is pressed, THEN 
			SceneManager.LoadScene (0); //load the scene assigned as number 0 in the build (should be the 'press P to start' page)
		} //END RESTART

//		if (isGameOver = true) {
//			SceneManager.LoadScene (3);
//		}

	}//END UPDATE
}// END CHANGE SCENE SCRIPT