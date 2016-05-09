using UnityEngine;
using System.Collections;

public class GameStart : MonoBehaviour {

	void OnGUI(){
		if(GUI.Button(new Rect (120, 120, 150, 30), "Start Game"))
		{
			StartGame();
		}
	}
	
	void StartGame(){

		print("starting game...");
		
		DontDestroyOnLoad(StateManager.Instance);

		Application.LoadLevel("level_1");

		StateManager.Instance.StartState();
	}
}
