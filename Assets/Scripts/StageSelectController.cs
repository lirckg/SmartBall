using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Security.Cryptography;


public class StageSelectController : MonoBehaviour {

	private GameObject img;

	// stagePrefabを入れる
	public GameObject stagePrefab;

	private string[] stageName = { "StageLEFT", "StageMIDDLE", "StageRIGHT"};

	// stageList
	private List<GameObject> stageList = new List<GameObject> ();

	private GameObject canvas;

	// Use this for initialization
	void Start () {

		this.canvas = GameObject.Find ("Canvas");
		

		for (int i = 0; i < stageName.Length; i++) {
			stageList.Add (GameObject.Find (stageName [i]));

		}
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetMouseButtonDown (0)) {

			// 移動
			for (int i = 0; i < stageList.Count; i++) {
				GameObject stage = stageList [i];
				stage.transform.Translate ( -300, 0, 0);
			}

			// 消去
			GameObject firstObject = stageList [0];
			this.stageList.Remove (firstObject);
			Destroy (firstObject);

			// 作成

			GameObject newStage = makeNewStage ();
			this.stageList.Add (newStage);


		}

		//this.img.transform.Translate ( 0.1f, 0, 0);

		//Debug.Log (this.img.transform.position);
	}


	GameObject makeNewStage(){

		// stageインスタンスを作成
		GameObject newStage = Instantiate (stagePrefab) as GameObject;
		newStage.transform.parent = this.canvas.transform;

		return newStage;


	}
}
