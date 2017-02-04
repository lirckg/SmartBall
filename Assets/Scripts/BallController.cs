using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.UI;

public class BallController : MonoBehaviour {

	// クリアテキスト
	private GameObject clearText;


	// Ballオブジェクト
	private GameObject ball;

	// Use this for initialization
	void Start () {
		// クリアテキストを取得
		this.clearText = GameObject.Find ("ClearText");

		// ball オブジェクトを取得
		this.ball = GameObject.Find ("Ball");
	}
	
	// Update is called once per frame
	void Update () {
		// Ball が落ちると
		if (this.ball.transform.position.y < -10) {
			this.clearText.GetComponent<Text> ().text = "GAME OVER";
		}
	}

	// 衝突判定
	void OnTriggerEnter(Collider other) {
		//Debug.Log (other.gameObject.tag);

		// ゴール
		if (other.gameObject.tag == "GoalTag") {

			this.clearText.GetComponent<Text> ().text = "CLEAR";
		}
	}
}
