using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class DoorController : MonoBehaviour {

	// バーの状態
	private bool barFlag = true;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

		// バーを上げる
		if ((Input.GetMouseButtonDown (0)) && this.barFlag) {
			this.transform.Translate( 0, 1, 0);
			this.barFlag = false;
		}

	}
}
