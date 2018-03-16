//Carlos Gabriel Santana Pulido 
//Creator of the script :) 
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

public class PrefabCreator : MonoBehaviour
{

	public GameObject PREFAB;
	public string SIGLO;

	private Image img;
	public static MySqlConnection con;



	private int contador = 0;
	private GameObject hijo;
	private static int ID, howMany = 0;
	private int prueba = 13;

	// Use this for initialization
	void Start ()
	{

		conectar ();

		try {
			
			con.Open ();
			Debug.Log ("Hacer consulta .1");
			//CONSULTA
			using (MySqlCommand cmd = new MySqlCommand ("SELECT COUNT(id) FROM historias;", con)) {
				//cmd.Parameters.AddWithValue("@pname", x);
				using (MySqlDataReader reader = cmd.ExecuteReader ()) {
					StringBuilder sb = new StringBuilder ();
					while (reader.Read ()) {
						sb.Append (reader.GetInt32 (0).ToString ());
						howMany = int.Parse (sb.ToString ());
						Debug.Log ("Hay " + sb.ToString () + " Campos");
					}
				}
			}
			con.Close ();
			Debug.Log ("MYSQL Connection closed .1");

		} catch (Exception e) {
			Debug.Log ("FAIL: " + e);
			Debug.Log (e);
		}


		List<int> listID = new List<int> ();
		//List<string> listTitulo = new List<string> ();



		try {
			
			con.Open ();
			Debug.Log ("Hacer 2da consulta .2");
			//CONSULTA

			using (MySqlCommand cmd = new MySqlCommand ("SELECT id FROM historias WHERE siglo=\""+SIGLO+"\";", con)) {
				//cmd.Parameters.AddWithValue("@pname", x);
				using (MySqlDataReader reader = cmd.ExecuteReader ()) {
					int x = 0;

					while (reader.Read ()) {
						listID.Add (reader.GetInt32 (0));//la variable dentro de int32 es el numero de columna en el query
						//listTitulo.Add(reader[1].ToString());
						Debug.Log ("Información [" + x + "] = ID:" + listID [x]);
						x++;
					}
				}
			}

		} catch (Exception e) {
			Debug.Log ("FAIL (2): " + e);
			Debug.Log (e);
		}

		con.Close ();
		Debug.Log ("MYSQL Connection closed .2");


	
		for (int i = 0; i <= howMany - 1; i++) {
			int idToSend = listID [i];
			clone (idToSend);
			contador++;
		}
	

	}


	public void  clone (int id)
	{
		
		GameObject PrefabCreatorClone = Instantiate (PREFAB) as GameObject;
		PrefabCreatorClone.name = "Circulo: " + contador.ToString ()+" ID: "+id;
		PrefabCreatorClone.transform.transform.localPosition = Vector3.zero;


		PrefabCreatorClone.transform.SetParent (this.transform);

		hijo = PrefabCreatorClone.transform.Find ("Imageninterna").gameObject;


		if (hijo != null) { //Verifica que el hijo exista 
			hijo.name = "hijo";

			//OBTENER RUTA DE LA IMAGEN.
			Sprite imageNew = Resources.Load<Sprite> ("Images/mural" + prueba);//prueba se usó para ver si cambiaba la imagen. verificar cual será la ruta. 
			prueba++;
			hijo.GetComponent<Image> ().sprite = imageNew;
		
		
			//Mandamos el id unico en un script por objeto. 
			hijo.GetComponent<uniqueData> ().ID = id;


		}

	}


	// Update is called once per frame
	void Update ()
	{

	
	}

	void conectar ()
	{
		DB_Connector dbconnector = GameObject.Find ("Scripts").GetComponent<DB_Connector> ();
		do {	
			con = dbconnector.conectar ();
		} while(!dbconnector.conexion);
	
	}


		
}

