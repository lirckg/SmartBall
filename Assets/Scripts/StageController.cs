﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StageController : MonoBehaviour {

	// 回転速度
	private float rotSpeed = 0.5f;

	// Use this for initialization
	void Start () {

		// ジャイロセンサON
		Input.gyro.enabled = true;
	}
	
	// Update is called once per frame
	void Update () {
		// ジャイロを取得
		float gy = Input.gyro.rotationRateUnbiased.y;

		this.transform.Rotate (0, 0, -gy);

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
