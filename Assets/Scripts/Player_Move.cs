using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Move : MonoBehaviour {

	private Rigidbody2D rb; //the rigidbody, so I don't have to type "GetComponent<Rigidbody2D>"  over and over, now I can just type'rb'
	public int playerSpeed = 10; // player speed
	public float groundFriction; //ground friction
	private bool facingRight = true; //setting a bool for flipping the player sprite later
	public int playerJumpPower = 1400; //how strong the player jump is
	private float moveX; //movement on the x axis
	private bool grounded; // am i grounded
	private int jumpsLeft; // how many jumps are left
	public int airJumps; // how many jumps in the air are allowed
	public float groundDetectionDistance; //value of the distance being checked between the player and ground 
	public LayerMask groundLayer; //ground layer layer mask
	bool canMove = true;

	void Start(){
		rb = GetComponent<Rigidbody2D> (); //attaching the var rb to the actual rb
	}//END START



	void Update () {
		canMove = true; //set canMove bool to 'true'
		CheckIfGrounded (); //run the CheckIfGrounded function to see if the player is touching the ground
		PlayerMove (); //updates the player movement using the PlayerMove function
	}//END UPDATE



	void PlayerMove () {  //a function for telling my player movement controls

		//CONTROLS
		moveX = Input.GetAxis("Horizontal"); //find the player's x axis 
		if (Input.GetKeyDown(KeyCode.UpArrow) || Input.GetButtonDown("Jump")) { //if the up arrow is pressed,
			if(grounded || jumpsLeft >0) { //if the player is touching the ground OR there are no jumps left, THEN
				Jump(); //run my jump function
			} // END check if jump is allowed
		}// END jump if statement


	

	

		//PLAYER DIRECTION


		if (moveX < 0.0f && facingRight == false) { //if the player x axis movement is LESS THAN zero AND they are NOT facing right, THEN
			FlipPlayer (); //run the FlipPlayer function
			rb.rotation++;
		}//END if moveX

		else if (moveX > 0.0f && facingRight == true) { //if the player x axis movement is LESS THAN 0 and they ARE facing right, THEN
			FlipPlayer ();  //run the FlipPlayer function
			rb.rotation--;
		}//END else if moveX

	

		//PHYSICS
		if (canMove) { //if the canMove is true THEN
			rb.velocity = new Vector2 ((moveX * playerSpeed), rb.velocity.y); // the player can move left and right
			rb.velocity = new Vector2(rb.velocity.x * groundFriction, rb.velocity.y); //adding in ground friction
		}
	}

	void Jump() {	//jumping code

		if (!grounded) { //it the player is NOT within the detection distance of the ground, THEN
			jumpsLeft -= 1; // subtract 1 from the number of jumps left
		} // END if grounded

		rb.AddForce(Vector2.up*playerJumpPower); //gets rigidbody and adds a force equal to the jump power
			}// END JUMP FUNCTION

	void FlipPlayer () { //this is a simple script that flips the player sprite (in case I change the sprites to something that shows direction)
			
		facingRight = !facingRight; //if the player isn't facing right
		Vector2 localScale = gameObject.transform.localScale; // get the player's posistion
		localScale.x *= -1; //multiply it by -1 to reverse it
		transform.localScale = localScale; //and scale it properly
	} //END FLIP PLAYER FUNCTION

	void CheckIfGrounded(){ //function to see if the player is on the ground
		Debug.DrawRay (transform.position, Vector2.down * groundDetectionDistance, Color.red); //debug to show where the distance detection is
		if (Physics2D.Raycast (transform.position, Vector2.down, groundDetectionDistance, groundLayer)) { //if the ray detects the ground within in the set distance
			grounded = true; //then the player is on the ground
			jumpsLeft = airJumps;//and we can reste how many times the player can jump
		} else { // else
			grounded = false;  //player is not within detection distance of the ground, so the grounded bool is set to false
		}// END ELSE STATEMENT
	} // END CHECKIFGROUNDED FUNCTION

	void OnCollisionEnter2D(Collision2D collision) { 
		Debug.Log ("Collided"); //tell me if the collision actually happened
		if (collision.gameObject.tag == "CameraAnchorTag") { //if the tag on the object is 'CameraAnchor" THEN
			Debug.Log ("Player Hit Camera Anchor."); // tell me "Player Hit Camera Anchor"
			canMove = false; // and set canMove to false
		}else{ // else
			canMove = true; //set canMove to true
		}//END CAM COLLISION

	}//END ON COLLISION ENTER 2D
} // END PLAYER_MOVE SCRIPT
