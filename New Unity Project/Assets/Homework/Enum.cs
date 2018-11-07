using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enum : MonoBehaviour {

		enum Inventory: ulong {bread = 1, meat = 10, sword = 1, shield = 2, map = 0, backpack = 12, bow = 3, arrows = 20};
		
		// int coins[] = new int{1,20,15,7, 2};
		

	// Use this for initialization
	void Start () {
		
		print("Bread = " + Inventory.bread);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
