using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Switches : MonoBehaviour {

	public int num;
	public string name;



	// Use this for initialization
	void Start () {
		
		//if(num == 10)
			//print("Hurray you picked ten!");
		
		//else
			//print("Boo you stink!")
//}
		
		

		//switch (num){
			
			//case 1:
				//print("you picked " + num );
				//break; 
			//case 2:
			//	print("you picked " + num );
			//	break; 
			//case 5:
			//	print("you picked " + num );
			//	break; 
			//case 8:
			//	print("you picked " + num );
			//	break; 
			//case 10:
			//	print("you picked " + num );
			//	break; 
			//default:
			//	print("I don't understand" + num);
			//break;
			
		//}

		switch(name){
			case "Jason":
				print("Welcome to camp crystal lake"+name);
				break;

				case "Michael":
					print("Welcome to Haddonfield, Ill " + name);
				break;
				case "Freddie":
					print("Welcome to Elm Street "+ name);
				break; 

				case "Leatherface":
					print("The stars and stripes are big at night...deep in the heart of Texas");
				break;
				
				default:
					print("I don't know" + name);
				break; 
		}
	}

	// Update is called once per frame
	void Update () {
		
	}
}
