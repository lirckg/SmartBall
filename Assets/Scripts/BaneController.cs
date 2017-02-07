using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.SocialPlatforms;

public class BaneController : MonoBehaviour {

	// Rigidbody
	private Rigidbody rb; 

	// localY
	private float localY;
	float yVelocity = 0.0F;
	// Use this for initialization
	void Start () {
		rb = this.GetComponent<Rigidbody> ();
		Debug.Log (this.gameObject.transform.localEulerAngles);
		localY = this.gameObject.transform.localEulerAngles.y;
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey (KeyCode.UpArrow)) {
			


		}
	}
	void OnTriggerEnter(Collider other) {
		// Ball
		Debug.Log (other.gameObject.tag);
		if (other.gameObject.tag == "BallTag") {
			localY = localY / (float)(2 * Math.PI);
			float a = (float)(1000 * Mathf.Sin (localY));
			float b = (float)(1000 * Mathf.Cos (localY));
			Debug.Log (localY);
			Debug.Log (Mathf.Sin (localY));
			Debug.Log (Mathf.Cos (localY));


			this.rb.AddForce (a, 0, -b);
		}
	}
}
