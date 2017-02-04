using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LuncherController : MonoBehaviour {
	
	// 回転速度
	private float rotSpeed = 0.5f;

	// 最大回転角度
	private float maxAngle = 30;

	// 回転方向
	private bool directionFlag = true;


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		Debug.Log (this.transform.localEulerAngles.y);

		float angleY = this.transform.localEulerAngles.y;

		if (directionFlag) {
			this.transform.Rotate (0, this.rotSpeed, 0);
		} else {
			this.transform.Rotate (0, -this.rotSpeed, 0);
		}

		if ((angleY > 45) && (angleY < 60)) {
			directionFlag = false;
		}

		if ((angleY < 315) && (angleY > 300)) {
			directionFlag = true;
		}
	}

}
