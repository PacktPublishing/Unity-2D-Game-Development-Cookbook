using UnityEngine;
using System.Collections;

public class animateUV : MonoBehaviour {
	
	public float scrollSpeed;
	public float offSet;
	
	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		offSet=scrollSpeed*Time.time;
		renderer.material.SetTextureOffset("_MainTex",new Vector2(0,offSet));
	}
}
