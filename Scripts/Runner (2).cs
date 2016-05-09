using UnityEngine;
using System.Collections;

public class Runner : MonoBehaviour {

	public static float distTraveled;
	public static bool bIsTouch;
	public int collected, levelGoal;

	private float horAcceleration;
	private Animator charAnimator;
	private Vector3 jumpVel;
	private Transform nextPlat;
	
	// Use this for initialization
	void Start () {
		charAnimator = GameObject.Find("runner").GetComponent<Animator>();
		horAcceleration = 4f;
		bIsTouch = false;
		jumpVel = new Vector3 (0,10,0);
		collected = 0;
		levelGoal= 5;
	}
	
	// Update is called once per frame
	void Update () {

		if(rigidbody.velocity.x > 6f){
			Vector3 v = new Vector3(6f, 0, 0);
			rigidbody.velocity=v;
		}
		if(rigidbody.velocity.x < -6f){
			Vector3 v = new Vector3(-6f, 0, 0);
			rigidbody.velocity=v;
		}

		distTraveled=transform.localPosition.x;
		//Debug.Log (rigidbody.velocity.x);
		if(collected == levelGoal){
			Time.timeScale = 0;
			Debug.Log("level complete!");
		}
	}

	void OnCollisionEnter(Collision c){
		if(c.gameObject.tag == "platform"){
			bIsTouch = true;
			charAnimator.SetBool("bJump",false);
		}
		if(c.gameObject.tag == "collectible"){
			Destroy(c.gameObject);
			collected += 1;
			Debug.Log(collected);
		}
	}

	void OnCollisionExit(Collision c){
		//Debug.Log(bIsTouch);

		if(c.gameObject.tag == "platform"){
			bIsTouch = false;
			charAnimator.SetBool("bJump",true);
		}
	}
	
	void FixedUpdate(){

		//rigidbody.velocity=(Input.GetAxis("Horizontal")*transform.right+Input.GetAxis("Vertical")*transform.forward).normalized*acceleration;
		rigidbody.velocity = new Vector3 (Input.GetAxis("Horizontal") * horAcceleration, rigidbody.velocity.y, rigidbody.velocity.z);
		charAnimator.SetFloat("fSpeed",rigidbody.velocity.x);

		if(rigidbody.velocity.x > 0f){
			Quaternion rot = Quaternion.Euler(new Vector3(0,90,0));
			rigidbody.rotation = rot; 
		}
		if(rigidbody.velocity.x < 0f){
			Quaternion rot = Quaternion.Euler(new Vector3(0,-90,0));
			rigidbody.rotation = rot;  
		}
		if(bIsTouch == true && Input.GetKeyDown(KeyCode.Space)){
			rigidbody.AddForce(jumpVel,ForceMode.VelocityChange);
			bIsTouch=false;
		}
	}
}
