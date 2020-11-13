using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WinSceneScript : MonoBehaviour {

	// Use this for initialization
	void Start () {

		// Invoke GotoMainMenu method in 1 second
		Invoke ("GotoMainMenu", 8f);
	}

	// Load MainMenu scene
	void GotoMainMenu()
	{
		SceneManager.LoadScene ("juegoQuiz");
	}

}
