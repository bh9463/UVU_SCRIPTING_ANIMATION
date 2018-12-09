using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerShoot : MonoBehaviour {

	public Transform FirePoint;
	public GameObject Projectile;
	public int AmmoQuantity;
	public int Ammo;
	Text AmmoQuantityText;



	void Start () {
	// 	//Projectile = Resources.Load("Prefab/Projectile") as GameObject;
	AmmoQuantity = 20;
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKeyDown(KeyCode.RightControl))
			if(AmmoQuantity >0){
				AmmoQuantity --;
				var projectile = Instantiate(Projectile, FirePoint.position, FirePoint.rotation);
			}
			
		}
	}

