using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class GetData : MonoBehaviour {

	public static int ID;
	public List<string> data = new List<string> ();
	private Select selectIntance;

	// Use this for initialization
	void Start () {
		selectIntance = GameObject.Find ("Scripts").GetComponent<Select> ();
		data = selectIntance.data;

	}
	
	// Update is called once per frame
	void Update () {
		if (data.Count == 0) {
			
		} else {	
			Text titulo = GameObject.Find ("Title").GetComponent<Text> ();
			titulo.text = data [0];
			Text parrafo = GameObject.Find ("Paragraph").GetComponentInChildren<Text> ();
			parrafo.text = data [1];
			Text fecha = GameObject.Find ("Date").GetComponent<Text> ();
			fecha.text = data [2];
			Text categoria = GameObject.Find ("Category").GetComponentInChildren<Text> ();
			categoria.text = data [3];



			clearList ();
		}
	}

	public void activate(){
		
	
	}
	public void clearList(){

		data.Clear ();
	
	}


}
