using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemypatrol : MonoBehaviour {

	// Movement Variables
	public float MoveSpeed;
	public bool MoveRight;

	// Wall Check
	public Transform WallCheck;
	public float WallCheckRadius;
	// items in layer = LayerMask
	public LayerMask WhatIsWall;
	private bool HittingWall;

	// Edge Check
	private bool NotAtEdge;
	public Transform EdgeCheck;



	void Update () {
		NotAtEdge = Physics2D.OverlapCircle(EdgeCheck.position, WallCheckRadius, WhatIsWall);

		HittingWall = Physics2D.OverlapCircle(WallCheck.position, WallCheckRadius, WhatIsWall);

		
		// turn around when hitting the wall or the edge
		if (HittingWall || !NotAtEdge){
			MoveRight = !MoveRight; 
		}

		if (MoveRight){
			transform.localScale = new Vector3(-6f,6f,1f);
			GetComponent<Rigidbody2D>().velocity = new Vector2(MoveSpeed, GetComponent<Rigidbody2D>().velocity.y);
		}
		else{
			transform.localScale = new Vector3(6f,6f,1f);
			GetComponent<Rigidbody2D>().velocity = new Vector2(-MoveSpeed, GetComponent<Rigidbody2D>().velocity.y);
		}
	}
}
