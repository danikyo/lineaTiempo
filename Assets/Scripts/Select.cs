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


public class Select : MonoBehaviour {

	public static Select instance;
	public int id_to_DB=0;
	public static MySqlConnection con;
	public Image viewerToChange;


	public List<string> data = new List<string> ();

	// Use this for initialization
	void Start () {
		instance = this; 
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void conectar ()
	{
		DB_Connector dbconnector = GameObject.Find ("Scripts").GetComponent<DB_Connector> ();
			
			con = dbconnector.conectar ();

		Debug.Log ("**************");

	}

	public void obtenerDatos(){
		conectar ();

		try {

			con.Open ();
			Debug.Log ("Hacer consulta General****");
			//CONSULTA
			//string consulta = "SELECT descripcion FROM historias WHERE id="+id_to_DB.ToString()+";";
			string consulta = "SELECT titulo,descripcion FROM cabanas.historias WHERE id="+id_to_DB+";"; 
			Debug.Log(consulta);
			using (MySqlCommand cmd = new MySqlCommand (consulta, con)) {
				//cmd.Parameters.AddWithValue("@pname", x);

				using (MySqlDataReader reader = cmd.ExecuteReader ())
				{

					while (reader.Read ()) 
					{

						Debug.Log("ENTRA A READ: -> "+reader.GetString(0));

					data.Add(reader["titulo"].ToString());
						data.Add(reader["descripcion"].ToString());
					}
				}

			}

		} catch (Exception e) {
			Debug.Log ("FAIL (3): " + e);
			Debug.Log (e);
		}

		con.Close ();
		Debug.Log ("MYSQL Connection closed .3");


		
	}

	public void activarInfo(){
		obtenerDatos ();
		viewerToChange.gameObject.SetActive(true);
		Debug.Log ("Cambio de vista a info");
	}
}
