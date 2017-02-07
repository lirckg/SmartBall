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

		// 左矢印で左に傾く
		if (Input.GetKey (KeyCode.LeftArrow)) {
			this.transform.Rotate (0, 0, 0.5f);
		}
		// 右矢印で右に傾く
		if (Input.GetKey(KeyCode.RightArrow)) {
			this.transform.Rotate (0, 0, -0.5f);
		}
	}
}
