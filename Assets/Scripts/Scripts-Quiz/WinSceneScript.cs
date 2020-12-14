using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WinSceneScript : MonoBehaviour {

	// Use this for initialization
	void Start () {

		// Invoke GotoMainMenu method in 1 second
		Invoke ("IrMenu", 8f);
	}

	// Load MainMenu scene
	void IrMenu()
	{
		SceneManager.LoadScene ("juegoQuiz");
	}

}
