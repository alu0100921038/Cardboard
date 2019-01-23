using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class wololoo : MonoBehaviour {

	public Material rojo;
	public Material azul;




	/*void PointerEnter(){
		GetComponent<Renderer> ().material = rojo;	
		Debug.Log ("test1 - Enter");
	}

	void PointerClick(){
		GetComponent<Renderer> ().material = azul;	
		Debug.Log ("test2 - Click");
	}

	void PointerExit(){
		Debug.Log ("test3 - Salida");
		GetComponent<Renderer> ().material = rojo;
	}*/


	public void ColorRojo(){
		GetComponent<Renderer> ().material = rojo;	
	}

	public void ColorAzul(){
		GetComponent<Renderer> ().material = azul;	
	}


}
