//using UnityEngine;
//using System.Collections;

//public class AudioLevelControl : MonoBehaviour {

	//public AudioClip carpet;

	//private float volumeLevel = 5.0f ;

	// Use this for initialization
	//void Start () {
	
	//}
	
	// Update is called once per frame
	//void Update () {

		//audio.volume = volumeLevel;
	
	//}

	/*
	void OnGUI(){

		Rect volumeArea = new Rect (30, 30, 120, 30);
		volumeArea = GUILayout.HorizontalSlider(volumeLevel, 0.0f, 10.0f);

	}
	*/

using UnityEngine;	
using System.Collections;
	
public class Example : MonoBehaviour {
	public float hSliderValue = 0.0F;

	void OnGUI() {
		//hSliderValue = GUI.HorizontalSlider(new Rect(25, 25, 100, 30), hSliderValue, 0.0F, 10.0F);
	}
}
