using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level1Manager : MonoBehaviour {

	public GameObject CurrentCheckPoint;
	public Rigidbody2D Jimmy;

	public GameObject Jimmy2;

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
	public void RespawnJimmy(){
		StartCoroutine ("RespawnJimmyCo");
	}

	public IEnumerator RespawnJimmyCo(){
		//instantiate is used to initiate effects or triggers
		//Generate Death Particle
		//This allows for the effect to happen wherever the character dies
		Instantiate (DeathParticle, Jimmy.transform.position, Jimmy.transform.rotation);
		Jimmy2.SetActive(false);
		//Hide Player
		//player.enabled = false;
		Jimmy.GetComponent<Renderer> ().enabled = false;
		//This is the Store Gravity in use, resetting the gravity
		GravityStore = Jimmy.GetComponent<Rigidbody2D>().gravityScale;
		Jimmy.GetComponent<Rigidbody2D>().gravityScale = 0f;
		Jimmy.GetComponent<Rigidbody2D>().velocity = Vector2.zero;
		//Point Death Penalty
		ScoreManager.AddPoints(-PointPenaltyOnDeath);
		//Respawn Text Message on screen
		Debug.Log("Jimmy Respawn");
		//Respawn dealay timer
		yield return new WaitForSeconds (RespawnDelay);
		//gavity restore
		Jimmy.GetComponent<Rigidbody2D>().gravityScale = GravityStore;
		//take player back to last checkpoint
		Jimmy.transform.position = CurrentCheckPoint.transform.position;
		Jimmy2.SetActive(true);
		//re applying the same character back to original state
		Jimmy.GetComponent<Renderer> ().enabled = true;
		//spawn particle effect initiate
		Instantiate (RespawnParticle, CurrentCheckPoint.transform.position, CurrentCheckPoint.transform.rotation);

	}
}
