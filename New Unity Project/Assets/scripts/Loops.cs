using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Loops : MonoBehaviour {

		public int Num = 40;

	// be sure to do "+=" 
	void Start () {
		//for(int i=0; i <= 100; i++){

			//print(i + "Ants Marching");

		//}
		while(Num >= 0){
			print("Countdown" + Num);
			Num --;


		}
	
	
	
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
