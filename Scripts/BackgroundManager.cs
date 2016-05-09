using UnityEngine;
using System.Collections.Generic;

public class BackgroundManager : MonoBehaviour {

	public Transform backBrick; //prefab to be used for background
	private Transform thisChar; //used to store the reference to the char for distance check

	private Transform[] backArray=new Transform[3]; //array used to store background panels
	private float distance; //used to check distance between ship and bricks
	private float farDistance;
	private Vector3 brickScale; //scale for bricks

	void Start(){

		thisChar = GameObject.Find ("runner").GetComponent<Transform>();
		farDistance = 30.0f;
		brickScale=new Vector3(60,60,1);

		float xPosition; //used to store the sum-subtraction-multiplication to make Instantiate more readable

		for (int i=0; i<3; i++) {
			xPosition = (brickScale.x * i);
			backArray[i] = (Transform)Instantiate(backBrick,new Vector3 (xPosition,0,farDistance),Quaternion.identity); //instantiate the bricks
			backArray[i].localScale = brickScale; //set bricks scale
		}
	}
	
	// Update is called once per frame
	void Update () {

		CheckDistance (); //I use a function inside Update() to avoid using a for inside update.
	}

	void CheckDistance(){

		for (int i=0; i<3; i++) {
			distance=thisChar.transform.position.x-backArray[i].transform.position.x;

			if(Mathf.Abs (distance) > (brickScale.x * 1.5) && distance > 0){ //check that a new brick needs to be inst. L/R
				backArray[i].Translate(3 * brickScale.x,0,0); //I multiply by 3 because we are using 3 bricks for the background
				break;
			}
			if(Mathf.Abs (distance) > (brickScale.x * 1.5) && distance < 0){ 
				backArray[i].Translate(-3 * brickScale.x,0,0);
				break;
			}
		}
	}
}