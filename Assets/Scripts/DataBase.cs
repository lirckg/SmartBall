using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DataBase : MonoBehaviour {

	// Use this for initialization
	void Start () {
		SqliteDatabase sqlDB = new SqliteDatabase ("config.db");
		string query = "insert into user values(1, 'Yamada', 19, 'Tokyo')";
		sqlDB.ExecuteNonQuery (query);

		// Select
		string selectQuery = "select * from user";
		DataTable dataTable = sqlDB.ExecuteQuery (selectQuery);

		string name = "";
		foreach (DataRow dr in dataTable.Rows) {
			name = (string)dr ["name"];
			Debug.Log ("name:" + name);
		}
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
