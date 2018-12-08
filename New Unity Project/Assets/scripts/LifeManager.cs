using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LifeManager : MonoBehaviour {

	public int StartingLives;
	private int LifeCounter;

	private Text TheText;

	void Start () {
		TheText = GetComponent<Text>();

		LifeCounter = StartingLives;
	}

	void Update (){
		TheText.text = "x " + LifeCounter;
	}

	public void GiveLife()
	{
		LifeCounter++;
	}
	public void TakeLife()
	{
		LifeCounter--;
	}
}