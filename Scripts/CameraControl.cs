using UnityEngine;
using System.Collections;

public class CameraControl : MonoBehaviour {

	public int distance;
	private Transform follow;

	// Use this for initialization
	void Start () {

		follow = GameObject.Find("runner").GetComponent<Transform>();
	}
	
	// Update is called once per frame
	void Update () {

		Vector3 v = new Vector3 (follow.position.x, follow.position.y, distance);
		transform.position = v;
	
	}
}
