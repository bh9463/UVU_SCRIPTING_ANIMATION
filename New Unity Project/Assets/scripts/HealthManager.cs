using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthManager : MonoBehaviour {

	public int MaxPlayerHealth;

	public static int PlayerHealth;

	Text text;

	private Level1Manager LevelManager;

	public int GameOver;

	public Text GameOverText;
	

	public bool isDead;
	
	private LifeManager LifeSystem;

	void Start () {
		text = GetComponent<Text>();

		GameOverText.GetComponent<Text>().enabled = false;	

		PlayerHealth = MaxPlayerHealth;

		LevelManager = FindObjectOfType<Level1Manager>();

		LifeSystem = FindObjectOfType<LifeManager>();

		isDead = false;
	}

	void Update () {
		if(PlayerHealth <= 0 && !isDead)
		{
			LevelManager.RespawnJimmy();
			isDead = true;
		}
		if(PlayerHealth <= 0 ){
			print("Player Dead Reached = " + PlayerHealth);
			GameOverText.GetComponent<Text>().enabled = true;
			Time.timeScale = 0;
		}
		

		text.text = "" + PlayerHealth;
	}

	public static void HurtPlayer(int damageToGive)
	{
		PlayerHealth -= damageToGive;
	}
	// public void FullHealth()
	// {
	// 	PlayerHealth = MaxPlayerHealth;
	// }
}