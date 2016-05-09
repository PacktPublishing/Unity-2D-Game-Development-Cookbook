using UnityEngine;
using System.Collections;

public class CollAudioPlayer : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnCollisionEnter(Collision other){
		if(other.gameObject.tag == "player"){
			Debug.Log("audio!");
			audio.Play();
		}
	}
}
