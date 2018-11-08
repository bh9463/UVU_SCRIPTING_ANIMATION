using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KillPlayer : MonoBehaviour {

	public Level1Manager Level1Manager;

	// populating it 
	void Start () {
		Level1Manager = FindObjectOfType <Level1Manager>();
	}
	
	void OnTriggerEnter2D(Collider2D other){
		if(other.name == "Jimmy"){
			Level1Manager.RespawnJimmy();
			}

		}
	}