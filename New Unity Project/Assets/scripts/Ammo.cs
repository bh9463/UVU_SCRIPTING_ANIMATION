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

		AmmoQuantity = 20;
		
	}
	
	// Update is called once per frame
	void Update () {
		
		if (AmmoQuantity < 0)
			AmmoQuantity = 0;
		AmmoQuantityText.text = " " + AmmoQuantity;

		if(Input.GetKeyDown(KeyCode.T)){
			AmmoQuantity += 1;
		}
		if(Input.GetKeyDown(KeyCode.RightControl)){
			AmmoQuantity -=1;
			AmmoQuantityText.GetComponent<Text> ().text = AmmoQuantity.ToString();
		}
		
		
	}

	void OnTriggerEnter2D (Collider2D other){
	 	if (other.GetComponent<Rigidbody2D> () == null)
	 		return;

		//ScoreManager.AddPoints (PointsToAdd);
		AmmoQuantity += 1;

		// Destroy (gameObject);
	}	

}


