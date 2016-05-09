using UnityEngine;
using System.Collections;

public class PS_Manager : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		if(!audio.isPlaying){
			Destroy(this.gameObject);
		}
	
	}
}
