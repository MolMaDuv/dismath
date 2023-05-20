using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using System;

public class CargarNuevaEscena : MonoBehaviour {

	private string contRegletasNombre = "contRegletas";
	private string contDadosNombre = "contDados";
	private int contRegletas = 0;
	private int contDados = 0;

	private string numRegletasNombre = "numRegletas";
	private string numDadosNombre = "numDados";
	private int numRegletas;
	private int numDados;

	private void Awake() {

		cargarDatos();
	}

    	public void LoadScene(string sceneName) {
		

			if(contDados < numDados){
				SceneManager.LoadScene("Operaciones2");
			}

		

    	}

	private void OnDestroy() {
		guardarDatos();
	}

	public void guardarDatos(){
		PlayerPrefs.SetInt(contRegletasNombre, contRegletas);
		PlayerPrefs.SetInt(contDadosNombre, contDados);

		PlayerPrefs.SetInt(numRegletasNombre, numRegletas);
		PlayerPrefs.SetInt(numDadosNombre, numDados);
	}

	public void cargarDatos(){
		contRegletas = PlayerPrefs.GetInt(contRegletasNombre, 0);
		contDados = PlayerPrefs.GetInt(contDadosNombre, 0);

		numRegletas = PlayerPrefs.GetInt(numRegletasNombre, 0);
		numDados = PlayerPrefs.GetInt(numDadosNombre, 0);
	}

}
