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

	// プッシュフラグ
	private bool isFlag = true;

	// Use this for initialization

	// target
	private Vector3 targetPosition;
	Vector3 v = new Vector3(0, 0, 0);

	float SPRING = 10;
	float DAMPING = 0.8f;

	void Start () {
		// Rigidbody取得
		rb = this.GetComponent<Rigidbody> ();

		// y軸の傾きを取得
		localY = this.gameObject.transform.localEulerAngles.y;



	}
	
	// Update is called once per frame
	void Update () {



		if (Input.GetKey (KeyCode.UpArrow)) {
			


		}
	}
	void OnTriggerEnter(Collider other) {
		// Ball
		Debug.Log (other.gameObject.tag );

		if ((other.gameObject.tag == "BallTag") && (this.isFlag == true)) {
			localY = localY / (float)(2 * Math.PI);
			float a = (float)(1000 * Mathf.Sin (localY));
			float b = (float)(1000 * Mathf.Cos (localY));



			this.rb.AddForce (a, 0, -b);

			this.isFlag = false;
		}
	}
}
