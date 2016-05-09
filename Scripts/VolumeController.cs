using UnityEngine;
using System.Collections;

public class VolumeController : MonoBehaviour {

	public AudioClip bkgdClip;
	static public float volumeLevel;

	private bool toggleAudio = true;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		audio.volume = volumeLevel;

		audio.enabled = toggleAudio;
	
	}

	void OnGUI(){

		//volumeLevel = GUI.HorizontalSlider( new Rect(30,30,110, 30), volumeLevel, 0.0f, 10.0f);

		//toggleAudio = GUI.Toggle(new Rect(10, 10, 100, 30), toggleAudio, "Toggle Audio");

	}
}