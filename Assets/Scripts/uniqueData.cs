using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;



public class uniqueData : MonoBehaviour {

	public int ID=0;
	public GameObject visorInfo ;



	// Use this for initialization
	void Start () {

		this.GetComponent<Button>().onClick.AddListener (delegate {
			funcioncambiar ();
		});
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void funcioncambiar ()
	{

		Select.instance.id_to_DB = ID;
		Debug.Log ("ID SEND:"+ID.ToString());
		Select cambiarVista = GameObject.Find ("Scripts").GetComponent<Select> ();
		cambiarVista.activarInfo ();

	}


}
