using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Security.Cryptography;
using DG.Tweening;
using System;


public class StageSelectController : MonoBehaviour {

	private GameObject img;

	// stagePrefabを入れる
	public GameObject stagePrefabRight;
	public GameObject stagePrefabLeft;

	// 初期img
	private string[] stageName = { "StageLEFT", "StageMIDDLE", "StageRIGHT"};

	// stageList
	private List<GameObject> stageList = new List<GameObject> ();

	// canvas オブジェクト
	private GameObject canvas;

	// 遷移方向
	private float direction = 1.0f;

	// Use this for initialization
	void Start () {

		this.canvas = GameObject.Find ("Canvas");
		

		for (int i = 0; i < stageName.Length; i++) {
			stageList.Add (GameObject.Find (stageName [i]));

		}
		
	}
	
	// Update is called once per frame
	void Update () {
		// 左矢印で左に
		if (Input.GetKey (KeyCode.LeftArrow)) {
			this.direction = 1.0f;
		}
		// 右矢印で右に
		if (Input.GetKey(KeyCode.RightArrow)) {
			this.direction = -1.0f;
		}

		Debug.Log (this.direction);


		if (Input.GetMouseButtonDown (0)) {

			// 移動
			for (int i = 0; i < stageList.Count; i++) {
				GameObject stage = stageList [i];
				//stage.transform.Translate ( -300, 0, 0);

				stage.transform.DOLocalMoveX (stage.transform.localPosition.x - (this.direction * 300f), 0.5f);
			}

			// 消去
			GameObject destroyObject;
			int argMax = 0;
			int argMin = 0;

			for (int i = 0; i < stageList.Count; i++) {
				if (stageList [i].transform.localPosition.x == -300)
					argMin = i;
				if (stageList [i].transform.localPosition.x ==  300)
					argMax = i;
			}

			// 遷移方向
			if (direction == 1.0f) {
				destroyObject = stageList [argMin];

			} else {
				destroyObject = stageList [argMax];
			}
			this.stageList.Remove (destroyObject);
			Destroy (destroyObject);

			// 作成
			GameObject newStage = makeNewStage ();
			this.stageList.Add (newStage);


		}

		//this.img.transform.Translate ( 0.1f, 0, 0);

		//Debug.Log (this.img.transform.position);
	}


	GameObject makeNewStage(){
		GameObject newStage;

		if (this.direction == 1.0f) {
			// stageインスタンスを作成
			newStage = Instantiate (stagePrefabRight) as GameObject;
		} else {
			newStage = Instantiate (stagePrefabLeft) as GameObject;
		}

		newStage.transform.parent = this.canvas.transform;



		return newStage;


	}
}
