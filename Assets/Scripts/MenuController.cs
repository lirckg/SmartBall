using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuController : MonoBehaviour {

	private GameObject menu;

	// Use this for initialization
	void Start () {
		this.menu = GameObject.Find ("MENU");
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	// Menuボタンが押されたとき
	public void GetMenuButtonDown(){
		this.menu.transform.localPosition = new Vector3 ( 0, -150, 0);
	}
	// ReStartボタンが押されたとき
	public void GetReStartButtonDown(){
		Application.LoadLevel ("Stage1");

	}

	// Startボタンが押されたとき
	public void GetStartButtonDown(){
		this.menu.transform.localPosition = new Vector3 ( 500, -150, 0);
	}

	// Homeボタンが押されたとき
	public void GetHomeButtonDown(){
		Application.LoadLevel ("Main");
	}
}
