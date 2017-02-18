using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Runtime.CompilerServices;
using System;

public class BoardMoveController: MonoBehaviour {

	private float direction = 1.0f;

	// Use this for initialization
	void Start () {
		this.direction = UnityEngine.Random.Range (0, 2) > 0 ? 1.0f : -1.0f;
		//Debug.Log (UnityEngine.Random.Range (0, 2));
	}
	
	// Update is called once per frame
	void Update () {
		this.transform.Translate (0.01f * this.direction, 0, 0);
	}

	void OnTriggerEnter(Collider other) {
		Debug.Log (other.gameObject.tag);
		if (other.gameObject.tag == "WallEndTag") {
			this.direction = this.direction > 0 ? 1.0f : -1.0f;
		}
	}
}
