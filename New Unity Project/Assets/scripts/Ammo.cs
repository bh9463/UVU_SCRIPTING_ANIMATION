using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Ammo : MonoBehaviour{ 	

	public static int AmmoQuantity;

	public int PointsToAdd;

	Text AmmoQuantityText;

	// Use this for initialization
	void Start () {
		AmmoQuantityText = GetComponent<Text>();

		AmmoQuantity = 0;
		
	}
	
	// Update is called once per frame
	void Update () {
		if (AmmoQuantity < 0)
			AmmoQuantity = 0;
		AmmoQuantityText.text = " " + AmmoQuantity;


		if(Input.GetKeyDown(KeyCode.T)){
			AmmoQuantity += 1;
		}
		
	}

	public static void AddPoints (int PointsToAdd) {
		AmmoQuantity += PointsToAdd;
	}



	void OnTriggerEnter2D (Collider2D other){
		if (other.GetComponent<Rigidbody2D> () == null)
			return;

		//ScoreManager.AddPoints (PointsToAdd);
		AmmoQuantity += 1;

		Destroy (gameObject);
	}	

}


