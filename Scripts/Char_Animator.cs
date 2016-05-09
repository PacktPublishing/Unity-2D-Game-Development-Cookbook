using UnityEngine;
using System.Collections;

public class Char_Animator : MonoBehaviour {

	private Animator charAnimator;
	private Rigidbody charRef;

	private float fTimePassed;

	// Use this for initialization
	void Start () {

		charAnimator= this.GetComponent<Animator>();
		charRef = this.GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update () {

		if(Input.GetKey(KeyCode.Space)){
			charAnimator.SetTrigger("tJump");
		}

		if(charAnimator.GetCurrentAnimatorStateInfo(0).IsName("Idle")){
			fTimePassed+=(Time.deltaTime);
			charAnimator.SetFloat("fWait",fTimePassed);
		}

		if(charAnimator.GetCurrentAnimatorStateInfo(0).IsName("Idle2")){
			fTimePassed=0.0f;
			charAnimator.SetFloat("fWait",fTimePassed);
		}

		charAnimator.SetFloat("fSpeed", charRef.rigidbody.velocity.x);
	}
}