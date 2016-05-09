using UnityEngine;
using System.Collections;

public class PlatManager : MonoBehaviour {
	
	public Transform platBrick;
	public Transform collectPref;
	public int lives;

	private Transform thisChar;
	private Transform actualPlat, prevPlat, nextPlat;
	private Vector3 platScale;
	private Transform collectible;
	private Vector3 nextPos;
	private float charX, charY, charZ;
	private float gap, delta, yGap;
	private float maxY, minY;


	void Start(){

		thisChar = GameObject.Find("runner").GetComponent<Transform>();
		lives = 3;
		maxY = 30f;
		minY = -10f;
		delta = 2; //we use this to define intervals
		nextPos = new Vector3(charX, charY - 1.5f, charZ); //we use a fixed position to begin with
		actualPlat = (Transform)Instantiate(platBrick, nextPos, Quaternion.identity );
		SetScalesAndGaps();
		actualPlat.localScale = platScale;
		prevPlat = null;
		nextPlat = null;
	}

	void FixedUpdate(){

		UpdatePos();

		if(actualPlat != null && charX > actualPlat.transform.position.x + delta){ //char is moving right
			float strict = actualPlat.transform.position.x; //compact formula
			prevPlat = actualPlat;
			actualPlat = null;
			SetScalesAndGaps();
			nextPos = new Vector3(strict + platScale.x + gap, yGap, charZ); //set next position for plat
			nextPlat = (Transform)Instantiate(platBrick, nextPos, Quaternion.identity );
			nextPlat.localScale = platScale; //set plat scale
			TossCollectible();
		}
		
		if(actualPlat != null && charX < actualPlat.transform.position.x - delta){
			float strict = actualPlat.transform.position.x;
			prevPlat = actualPlat;
			actualPlat = null;
			SetScalesAndGaps();
			nextPos = new Vector3(strict - platScale.x - gap, yGap, charZ);
			nextPlat = (Transform)Instantiate(platBrick, nextPos, Quaternion.identity );
			nextPlat.localScale = platScale;
			TossCollectible();
		}

		if(prevPlat != null){
			float strict = prevPlat.transform.position.x; 
			if(charX > strict - delta && charX < strict + delta){ //char has turned back
				Destroy(nextPlat.gameObject);
				nextPlat = null;
				actualPlat = prevPlat;
				prevPlat = null;
			}
		}

		if(nextPlat != null){
			float strict = nextPlat.transform.position.x;
			if(charX > strict - delta && charX < strict + delta){ //char has reached next plat
				actualPlat = nextPlat;
				nextPlat = null;
				Destroy(prevPlat.gameObject);
			}
		}

		if(thisChar.position.y < -37){
		
			lives -= 1;

			Vector3 v = new Vector3 (0,0,0);
			if(nextPlat){
				v = nextPlat.position;
			}
			else{
				v = actualPlat.position;
			}

			v.y += 40;
			thisChar.position = v;
		}

	}

	void UpdatePos(){ //update char pos
		charX = thisChar.transform.position.x;
		charY = thisChar.transform.position.y;
		charZ = thisChar.transform.position.z;
	}

	void SetScalesAndGaps(){
		platScale = new Vector3(Random.Range(8,14),1,1);
		gap = Random.Range(4,7);
		if(prevPlat != null){
			yGap = prevPlat.transform.position.y + (Random.Range (-delta,delta));
			CheckYGap();
		}
	}

	void CheckYGap(){ //we set top and bottom vertical limits
		if (yGap > maxY){
			yGap = maxY;
		}
		if(yGap < minY){
			yGap = minY;
		}
	}

	void TossCollectible(){
		float f = Random.Range(0f,1f);
		//Debug.Log(f);
		if (f > 0.5){
			Vector3 v = new Vector3 (nextPos.x, nextPos.y + 2 * delta, 0);
			collectible = (Transform)Instantiate(collectPref, v, Quaternion.identity);
		}
	}



	/*
	void SetPlatScale(){
		platScale = new Vector3(Random.Range(20,28),1,1);
	}

	void GenerateGap(){ //random distance between platforms
		gap = Random.Range(8f,16f);
		//gap=0f;
	} 

	void GenerateYGap(){ //random vertical gap between plats.
		yGap = prevPlat.transform.position.y + (Random.Range (-delta,delta));
		CheckYGap();
	}

	void OnGUI(){
		GUI.Box(new Rect(10,10,100,50),charX.ToString());
	}

*/


	
}
