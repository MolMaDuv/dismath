using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;//usar interfaz del canvas como botones
using System.Text;
using UnityEngine.SceneManagement;

public class Preparacion : MonoBehaviour {

	[Header("Sonidos")]
	public GameObject sonidoCorrecto;
    	public GameObject sonidoIncorrecto;

	[Header("Text")]
	public Text texto;

	public string sceneName;

	IEnumerator Esperar() {

 		yield return new WaitForSeconds (3000);
	}

	public void gestoUno() {

		Instantiate(sonidoCorrecto);
		//texto.text = "Excelente";
	    	StartCoroutine("Esperar");
		LoadScene(sceneName);
	}

	public void gestoIncorrecto() {

		Instantiate(sonidoIncorrecto);
		//texto.text = "Excelente";
	    	StartCoroutine("Esperar");	
	}
	 
	public void LoadScene(string sceneName) {

        	SceneManager.LoadScene(sceneName);
    	}	



}
