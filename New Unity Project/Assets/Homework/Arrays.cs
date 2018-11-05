using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arrays : MonoBehaviour {

		public int[] Eggs = new int[11];

		public string[] Jedi;
		public string[] Soda;
		public string[] Alchemist;




	// Use this for initialization
	void Start () {
		

		Eggs[0] = 1;
		Eggs[1] = 2;
		Eggs[2] = 3;
		Eggs[3] = 4;
		Eggs[4] = 5;
		Eggs[5] = 6;
		Eggs[6] = 7;
		Eggs[7] = 8;
		Eggs[8] = 9;
		Eggs[9] = 10;
		Eggs[10] = 11;
		Eggs[11] = 12;
		
		print(Eggs[8]); 

		Jedi = new string[4];

		Jedi[0] = "Obi Wan Kenobi";
		Jedi[1] = "Yoda";
		Jedi[2] = "Mace Windu";
		Jedi[3] = "Kit Fisto";
		Jedi[4] = "Luke Skywalker";

		foreach(string item in Jedi){
			print("Jedi master " + item);
		}

		Soda[0] = "Cherry";
		Soda[1] = "Dr. Pepper";
		Soda[2] = "Coke";
		Soda[3] = "Pepsi";
		Soda[4] = "Root Beer";
		Soda[5] = "Sprite";
		Soda[6] = "Ginger Ale";

		foreach(string item in Soda){
			print("Go get me a  " + item);
		}

		Alchemist[0] = "Full Metal Alchemist";
		Alchemist[1] = "Flame";
		Alchemist[2] = "Armstrong";
		

		foreach(string item in Soda){
			print("Go get me a  " + item);
		}
	}

	
	// Update is called once per frame
	void Update () {
		
	}
}
