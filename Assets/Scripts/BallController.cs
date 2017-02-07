using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.UI;


public class BallController : MonoBehaviour {

	// クリアテキスト
	private GameObject clearText;

	// コインUI
	private GameObject coinUI;


	// Ballオブジェクト
	private GameObject ball;

	public Sprite img2;

	// Use this for initialization
	void Start () {
		// クリアテキストを取得
		this.clearText = GameObject.Find ("ClearText");

		// コインUI
		this.coinUI = GameObject.Find ("CoinUI"); 

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

		// コイン
		if (other.gameObject.tag == "CoinTag") {
			this.coinUI.GetComponent<Image> ().sprite = img2;
			Destroy (other.gameObject);
		}
	}
}
