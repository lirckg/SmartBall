using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneController : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetMouseButtonDown (0)) {
			
			//Application.LoadLevel ("GameScene");
		}
	}

	public void GetMyStage1ButtonDown(){
		Application.LoadLevel ("GameScene");
	}

}
