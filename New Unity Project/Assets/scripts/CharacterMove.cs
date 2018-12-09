using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMove : MonoBehaviour {


	// Player Movement Variables
	public int MoveSpeed; 
	public float JumpHeight; 
	private bool doubleJump;
	

	// Player grounded variables
	public Transform GroundCheck;
	public float GroundCheckRadius;
	public LayerMask WhatIsGround;
	private bool Grounded;
	private float moveVelocity;


	// Use this for initialization or in game startup
	void Start () {
		 
	}
	

	void FixedUpdate () {
		Grounded = Physics2D.OverlapCircle(GroundCheck.position, GroundCheckRadius, WhatIsGround);
	}
	// Update is called once per frame or recycles every frame
	void Update () {
	
	// This code makes the character jump 
	// "If" is when you click a specific key to make something do a certain action
	if(Input.GetKeyDown (KeyCode.Space)&& Grounded){
		Jump();
	}

	// double jump
	if(Grounded)
		doubleJump = false;

	if(Input.GetKeyDown (KeyCode.Space)&& !doubleJump && !Grounded){
			Jump();
			doubleJump = true;
	}
	

	moveVelocity = 0f;

	// This code makes the character move from side to side with A/D keyboard keys
	if(Input.GetKey (KeyCode.D)) {
			//GetComponent<Rigidbody2D>().velocity = new Vector2(MoveSpeed, GetComponent<Rigidbody2D>().velocity.y);
			moveVelocity = MoveSpeed;
	}
	if(Input.GetKey (KeyCode.A)){
			//GetComponent<Rigidbody2D>().velocity = new Vector2(-MoveSpeed, GetComponent<Rigidbody2D>().velocity.y);
			moveVelocity = -MoveSpeed;
	}

	GetComponent<Rigidbody2D>().velocity = new Vector2(moveVelocity, GetComponent<Rigidbody2D>().velocity.y);

	//Player flip
	if (GetComponent<Rigidbody2D>().velocity.x > 0)
		transform.localScale = new Vector3(.1f,.1f,1f);

	else if (GetComponent<Rigidbody2D>().velocity.x < 0)
	transform.localScale = new Vector3(-.1f,.1f,1f);
	


}


public void Jump(){
		GetComponent<Rigidbody2D>().velocity = new Vector2(GetComponent<Rigidbody2D>().velocity.x, JumpHeight);
	}
}

