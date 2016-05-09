using UnityEngine;
using System.Collections;

public class Texter : MonoBehaviour {

	private string wonText;
	
	void Start () {

		wonText = "Congratulations \n Level Complete";
		GetComponent<TextMesh>().text = wonText;
	
	}

	void OnGUI() {
		/*
		if(GUI.Button(new Rect (120, 120, 150, 30), "Home")){
			Application.loadedLevel("home");
		}
		*/
	}
}
