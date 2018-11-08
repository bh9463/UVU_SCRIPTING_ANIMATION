using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour {

	public float Speed;
	public Rigidbody2D Jimmy;

	public GameObject EnemyDeath;

	public GameObject ProjectileParticle;

	public int PointsForKill;

	// Use this for initialization
	void Start () {

		Jimmy = GameObject.Find("Jimmy").GetComponent<Rigidbody2D>();
		
		if(Jimmy.transform.localScale.x < 0)
			Speed = -Speed;
	}
	
	// Update is called once per frame
	void Update () {
		GetComponent<Rigidbody2D>().velocity = new Vector2(Speed, GetComponent<Rigidbody2D>().velocity.y);
		}
		// This is the Instantiate for when the projectile hits the enemy, dissolves the projectile and applies the "AddPoints" code thus, giving you points for killing the enemy
		void OnTriggerEnter2D(Collider2D other){
			if(other.tag == "Enemy"){
				Instantiate(EnemyDeath, other.transform.position, other.transform.rotation);
				Destroy (other.gameObject);
				ScoreManager.AddPoints (PointsForKill);
			}

			//projectile delay on the projectile getting destroyed. destroy delay timer 
			Destroy (gameObject, 5);
		}

		void OnCollisionEnter2D(Collision2D other){
			
			Instantiate(ProjectileParticle, transform.position, transform.rotation);
			Destroy (gameObject);
		}
	
}

