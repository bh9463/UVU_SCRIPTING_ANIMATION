using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class HurtPlayer : MonoBehaviour {

	public int damageToGive;

	void Start () {

	}


	void Update () {

	}

	void OnTriggerEnter2D(Collider2D other){
		if(other.name == "Jimmy"){
			HealthManager.HurtPlayer(damageToGive);
			}
		

		}
	}