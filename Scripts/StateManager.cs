using UnityEngine;
using System.Collections;

public class StateManager : MonoBehaviour {

	private PlatManager platScript;
	private Runner runScript;
	
	private static StateManager instance;

	public static StateManager Instance
	{
		get
		{
			if(instance == null)
			{
				instance = new GameObject("StateManager").AddComponent<StateManager> ();
			}
			return instance;
		}
	}	

	public void OnApplicationQuit()
	{
		instance = null;
	}

	public void StartState()
	{
		Debug.Log ("New scene is being created...");
	}

	void Start(){

		//platScript = GameObject.Find("plat_manager").GetComponent<PlatManager>();
		//runScript = GameObject.Find ("runner").GetComponent<Runner>();
	}

	void Update(){

		/*
		if (platScript.lives == 0){

			DontDestroyOnLoad(StateManager.Instance);
			Application.LoadLevel("game_over");
		}

		if(runScript.collected == 5){

			DontDestroyOnLoad(StateManager.Instance);
			Application.LoadLevel("game_won");
		}
		*/
	}


}
