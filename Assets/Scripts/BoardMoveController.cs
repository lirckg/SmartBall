using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Runtime.CompilerServices;
using System;

public class BoardMoveController: MonoBehaviour {

	private float direction = 1.0f;


	public double maxPositionX = 0.398;
	public double minPositionX = -0.398;

	private float positionX;

	public double distanceFromWall;

	// Use this for initialization
	void Start () {
		this.direction = UnityEngine.Random.Range (0, 2) > 0 ? 1.0f : -1.0f;
		//Debug.Log (UnityEngine.Random.Range (0, 2));

		this.positionX = this.transform.localPosition.x;
	}
	
	// Update is called once per frame
	void Update () {
		this.positionX = this.transform.localPosition.x;;

		Debug.Log (this.positionX);
		if (this.positionX > this.maxPositionX)
			this.direction *= -1;
		if (this.positionX < this.minPositionX)
			this.direction *= -1;



		this.transform.Translate(0.01f * this.direction, 0, 0);

	}

	void OnTriggerEnter(Collider other) {
		Debug.Log (other.gameObject.tag);
		if (other.gameObject.tag == "WallEndTag") {
			this.direction = this.direction > 0 ? 1.0f : -1.0f;
			Debug.Log ("aaaaaa");
		}
	}
}
