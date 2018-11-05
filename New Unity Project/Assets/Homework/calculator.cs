using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class calculator : MonoBehaviour {

	//these are my 3 variables
	public int addMe1;
	public int addMe2;
	//without stating public or private it automatically is private
	int Total;
	//public void means 
	public void Add(int One, int Two){

		Total = One + Two;

		print(Total);
	}
}
