using UnityEngine;
using System.Collections;

public class ActorControls : MonoBehaviour {

	public float jumpHeight;
	public GameObject ps;


	// Use this for initialization
	void Start () {

		if(jumpHeight == 0)
			jumpHeight = 3.0f;
	
	}
	
	// Update is called once per frame
	void Update () {

		if( Input.GetKeyDown(KeyCode.UpArrow)){
			rigidbody.velocity += Vector3.up * jumpHeight;
		}
	
	}

	void OnCollisionEnter(Collision c){
		if(c.gameObject.tag == "coll"){
			Instantiate (ps,c.transform.position,Quaternion.identity);
			GameObject.Destroy(c.gameObject);
		}
	}
}
