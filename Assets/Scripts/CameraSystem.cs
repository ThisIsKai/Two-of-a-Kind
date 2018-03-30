using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraSystem : MonoBehaviour {
	private GameObject Player1; //player 1
	private GameObject Player2; //player 2
	private GameObject[] Player; //the array for the players
	private GameObject cameraAnchor; //the camera anchor

	public float xMin;//posistion parameters: x minimum
	public float xMax;//posistion parameters: x maximum
	public float yMin;//posistion parameters: y minimum
	public float yMax;//posistion parameters: y maximum

	Camera mainCamera; //the main camera


	// Use this for initialization
	void Start () {
		mainCamera = Camera.main; //assigning the camera
		Player = GameObject.FindGameObjectsWithTag ("Player");//associates it with variables with the tag 'player'
		Player1 = Player[0]; //assigning the players
		Player2 = Player[1]; //assigning the players
		cameraAnchor = GameObject.FindGameObjectWithTag ("CameraAnchorTag"); //find the camera anchor object
		mainCamera.transform.position = cameraAnchor.transform.position;


	}//END START FUNCTION
	
	// Update is called once per frame
	void Update () {
		Vector3 m_pos = cameraAnchor.transform.position; //assigning m_pos to the camera anchor pos
		//m_pos.x = (.5f * ((Player1.transform.position.x) + (Player2.transform.position.x))); //finding the midpoint between the players for m_pos
		m_pos.x = (((Player1.transform.position.x) + (Player2.transform.position.x))); //finding the midpoint between the players for m_pos
		m_pos.z = ((Player1.transform.position.z) - 10); //the z value should always be negative
	//	m_pos.y = (.5f * ((Player1.transform.position.y) + (Player2.transform.position.y)));
		m_pos.y = (((Player1.transform.position.y) + (Player2.transform.position.y)));
		cameraAnchor.transform.position = m_pos; // camera posistion equals m_pos


	} //END UPDATE FUNCTION

} //END CAMERA SYESTEM SCRIPT

