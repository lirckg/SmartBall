using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.UI;

public class BallController : MonoBehaviour {

	private GameObject clearText;

	private GameObject ball;

	// Use this for initialization
	void Start () {
		this.clearText = GameObject.Find ("ClearText");

		this.ball = GameObject.Find ("Ball");
	}
	
	// Update is called once per frame
	void Update () {
		if (this.ball.transform.position.y < -10) {
			this.clearText.GetComponent<Text> ().text = "GAME OVER";
		}
	}

	void OnTriggerEnter(Collider other) {
		Debug.Log (other.gameObject.tag);
		if (other.gameObject.tag == "GoalTag") {

			this.clearText.GetComponent<Text> ().text = "CLEAR";
		}
	}
}
