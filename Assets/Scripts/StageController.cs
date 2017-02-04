using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StageController : MonoBehaviour {

	// 回転速度
	private float rotSpeed = 0.5f;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey (KeyCode.LeftArrow)) {
			this.transform.Rotate (0, 0, 0.5f);
		}
		if (Input.GetKey(KeyCode.RightArrow)) {
			this.transform.Rotate (0, 0, -0.5f);
		}
	}
}
