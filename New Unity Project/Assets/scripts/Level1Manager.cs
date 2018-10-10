using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level1Manager : MonoBehaviour {

	public GameObject CurrentCheckPoint;
	public Rigidbody2D Player;

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
		//player = FindObjectOfType<Rigidbody2D> ();
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
		Instantiate (DeathParticle, Player.transform.position, Player.transform.rotation);
		//Hide Player
		//player.enabled = false;
		Player.GetComponent<Renderer> ().enabled = false;
		//This is the Store Gravity in use, resetting the gravity
		GravityStore = Player.GetComponent<Rigidbody2D>().gravityScale;
		Player.GetComponent<Rigidbody2D>().gravityScale = 0f;
		Player.GetComponent<Rigidbody2D>().velocity = Vector2.zero;
		//Point Death Penalty
		ScoreManager.AddPoints(-PointPenaltyOnDeath);
		//Respawn Text Message on screen
		Debug.Log("Player Respawn");
		//Respawn dealay timer
		yield return new WaitForSeconds (RespawnDelay);
		//gavity restore
		Player.GetComponent<Rigidbody2D>().gravityScale = GravityStore;
		//take player back to last checkpoint
		Player.transform.position = CurrentCheckPoint.transform.position;

		Player.GetComponent<Renderer> ().enabled = true;
		//spawn particle effect initiate
		Instantiate (RespawnParticle, CurrentCheckPoint.transform.position, CurrentCheckPoint.transform.rotation);

	}
}
