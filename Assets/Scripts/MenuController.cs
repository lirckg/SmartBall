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
		this.menu.transform.localPosition = new Vector3 (0, -150, 0);
	}
}
