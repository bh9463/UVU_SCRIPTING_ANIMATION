using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level1Manager : MonoBehaviour {

	public GameObject CurrentCheckPoint;
	private Rigidbody2D Player;

	//Death and respawn animation effect
	public GameObject DeathParticle;
	public GameObject RespawnParticle;

	//Respawn Delay so 3, 2, 1 RESPAWN
	public float RespawnDelay;

	//Point Penalty on Death
	public int PointPenaltyOnDeath;

	// Store Gravity means reseting the gravity after you die so you don't just die again
	private float GravityStore;


	//Beginning of game, happens once
	void Start () {
		player = FindObjectOfType<Rigidbody2D> ();
	}
	//Co Routine means a cycle that can happen multiple times that is activated multiple times by the player 
	//for example, you won't have a respawn timer unless you die. When you die, you have the same amount of time
	//or it's a cycle that can be interrupted 
	public void RespawnPlayer(){
		StartCoroutine ("RespawnPlayerCo");
	}

	public IEnumerator RespawnPlayerCo(){
		//instantiate is used to initiate effects or triggers
		//Generate Death Particle
		//This allows for the effect to happen wherever the character dies
		Instantiate (deathParticle, player.transform.position, player.transform.rotation);
		//Hide Player
		player.enabled = false;
		player.GetComponent<Renderer> ().enabled = false;
		//This is the Store Gravity in use, resetting the gravity
		gravityStore = player.GetComponent<Rigidbody2D>().gravityScale;
		player.GetComponent<Rigidbody2D>().gravityScale = 0f;
		player.GetComponent<Rigidbody2D>().velocity = Vector2.zero;
		//Point Death Penalty
		ScoreManager.addPoints(-pointPenaltyOnDeath);
		//Respawn Text Message on screen
		Debug.Log("Player Respawn");

	}
}
