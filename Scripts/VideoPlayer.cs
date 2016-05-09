using UnityEngine;
using System.Collections;

public class VideoPlayer : MonoBehaviour {



	// Use this for initialization
	void Start () {

		MovieTexture mt = (MovieTexture)renderer.material.mainTexture;
		mt.Play();
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
