#Unity 2D Game Development Cookbook


This is the code repository for [Unity 2D Game Development Cookbook](https://www.packtpub.com/game-development/unity-2d-game-development-cookbook?utm_source=github&utm_medium=repository&utm_campaign=9781783553594), published by Packt. It contains all the supporting project files necessary to work through the book from start to finish.

##Instructions and Navigation
All of the code is organized into folders. Each folder starts with Chapter followed by Chapter Number. For example, Chapter1.
Packages have been made with Unity Pro 3.4.3. Recommended Unity version for book: 3.3 and up. XNView available at: http://www.xnview.com/.
Maya version used: Maya 2014.
Photoshop version used: CS6.
Each Chapter contains code files. You will see code something similler to the following:

```
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

```


##Related Entity Framework Products:
* [Learning Unity 2D Game Development by Example](https://www.packtpub.com/game-development/learning-unity-2d-game-development-example?utm_source=github&utm_medium=repository&utm_campaign=9781783559046)
* [Unity 2D Game Development](https://www.packtpub.com/game-development/unity-2d-game-development?utm_source=github&utm_medium=repository&utm_campaign=9781849692564)
* [Mastering Unity 2D Game Development](https://www.packtpub.com/game-development/mastering-unity-2d-game-development?utm_source=github&utm_medium=repository&utm_campaign=9781849697347)### Download a free PDF

 <i>If you have already purchased a print or Kindle version of this book, you can get a DRM-free PDF version at no cost.<br>Simply click on the link to claim your free PDF.</i>
<p align="center"> <a href="https://packt.link/free-ebook/9781783553594">https://packt.link/free-ebook/9781783553594 </a> </p>