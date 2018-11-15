using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Ammo : MonoBehaviour{ 	

	public static int AmmoQuantity;

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
		
	}

	public static void AddPoints (int PointsToAdd) {
		AmmoQuantity += PointsToAdd;
	}
}
