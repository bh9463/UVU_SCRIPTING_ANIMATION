using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class MainMenu : MonoBehaviour {

	public int level1ToLoad;

	public void LoadLevel(){
		SceneManager.LoadScene(level1ToLoad);
	}

	public void Level1Exit(){
		Application.Quit();
	}
}

