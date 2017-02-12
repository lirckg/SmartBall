using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.UI;
using System.Runtime.CompilerServices;
using System.Net.Sockets;


public class BallController : MonoBehaviour {

	// クリアテキスト
	private GameObject clearText;

	// コインUI
	private GameObject coinUI;


	// Ballオブジェクト
	private GameObject ball;

	//
	public Sprite star1;
	public Sprite star2;
	public Sprite star3;
	private Sprite[] stars = new Sprite[3];


	private int starCount;

	public Quaternion gyros;

	// Use this for initialization
	void Start () {
		// クリアテキストを取得
		this.clearText = GameObject.Find ("ClearText");

		// コインUI
		this.coinUI = GameObject.Find ("CoinUI"); 

		// ball オブジェクトを取得
		this.ball = GameObject.Find ("BallPrefab");

		starCount = -1;

		this.stars [0] = this.star1;
		this.stars [1] = this.star2;
		this.stars [2] = this.star3;
 
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

		Debug.Log (other.gameObject.tag);

		// ゴール
		if (other.gameObject.tag == "GoalTag") {

			this.clearText.GetComponent<Text> ().text = "CLEAR";
		}

		// コイン
		if (other.gameObject.tag == "StarTag") {
			starCount += 1;
			Debug.Log (stars[starCount]);
			this.coinUI.GetComponent<Image> ().sprite = this.stars[starCount];
			Destroy (other.gameObject);
		}

		// Dead
		if (other.gameObject.tag == "DeadTag") {
			this.clearText.GetComponent<Text> ().text = "GAME OVER";
		}
	}
}
