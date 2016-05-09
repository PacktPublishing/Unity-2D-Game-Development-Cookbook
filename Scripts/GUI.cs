using UnityEngine;
using System.Collections;

public class GUI : MonoBehaviour {

	public Texture lifeIcon;
	public Texture collIcon;
	public TextMesh tm;
	public AudioClip carpet;
	
	private PlatManager platScript;
	private Runner runScript;
	private float volumeLevel;
	//private Camera gameCam;
	//private TextMesh tm;
	
	// Use this for initialization
	void Start () {

		platScript = GameObject.Find("plat_manager").GetComponent<PlatManager>();
		runScript = GameObject.Find ("runner").GetComponent<Runner>();

		//gameCam = GameObject.Find ("MainCamera").GetComponent<Camera>();
		//tm = GameObject.Find("collText").GetComponent<TextMesh>();
	}
	
	// Update is called once per frame
	void Update () {
		tm.text = runScript.collected + " / 5";
		audio.volume = volumeLevel;
	}


	void OnGUI(){

		for(int i=0; i<platScript.lives; i++){
			Graphics.DrawTexture(new Rect(30 + (60*i), 700, 50, 50), lifeIcon);
		}

		Graphics.DrawTexture(new Rect(880, 28, 30, 30), collIcon);

		//volumeLevel = GUI.HorizontalSlider( new Rect(30,30,110, 30), volumeLevel, 0.0f, 10.0f);

	}
}
