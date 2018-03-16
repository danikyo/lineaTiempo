using UnityEngine;
using UnityEngine.UI;
using System;
using System.Data;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using MySql.Data;
using MySql.Data.MySqlClient;

public class DB_Connector : MonoBehaviour
{


	public string host, database, user, password;
	public bool pooling = true;

	private string connectionString;
	public  MySqlConnection con = null;
	//private MySqlCommand cmd = null;
	//private MySqlDataReader rdr = null;
	private MD5 _md5Hash;

	[System.NonSerialized]
	public bool conexion = false;


	// Use this for initialization
	void Start ()
	{

	}
	
	// Update is called once per frame
	void Update ()
	{
		
	}

	public MySqlConnection conectar ()
	{
		//DontDestroyOnLoad (this.gameObject);
		connectionString = "Server=" + host + ";Database=" + database + ";User=" + user + ";Password=" + password + ";Charset=utf8;Pooling=";
		if (pooling) {
			connectionString += "true;";
		} else {
			connectionString += "false;";
		}

		try {
			con = new MySqlConnection (connectionString);

			Debug.Log ("**  ¡¡CONECTADO!!  **");
			conexion = true;


		} catch (Exception e) {
			Debug.Log ("**  FAIL: " + e);
			Debug.Log (e);
		}

		return con;
	}



	void OnApplicationQuit ()
	{
		if (con != null) {
			if (con.State.ToString () != "Closed") {
				con.Close ();
				Debug.Log ("**  MYSQL Connection closed");
				conexion = false;
			}
		}
	}
		

	// Use this for initialization



}
