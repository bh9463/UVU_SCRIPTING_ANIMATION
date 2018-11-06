using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour {

	public CharacterMove Jimmy;

	public bool isFollowing;

	// Camera position offset

	public float xOffset;
	public float yOffset;
	
	
	
	void Start () {
		Jimmy = FindObjectOfType<CharacterMove>();

		isFollowing = true;
	}
	
	// Update is called once per frame
	void Update () {
		if(isFollowing){
			transform.position = new Vector3(Jimmy.transform.position.x + xOffset, Jimmy.transform.position.y + yOffset, transform.position.z);
		}
	}
}
