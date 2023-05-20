using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using System;

public class Login : MonoBehaviour {

	[Header("Mensaje Login")]
	[SerializeField] private Text mensajeLogin = null;

	[Header("Login")]
	[SerializeField] private InputField loginUserEmailInput = null;
	[SerializeField] private InputField loginPasswordInput = null;

	private NetworkManager networkManager = null;

	private void Awake() {

		networkManager = GameObject.FindObjectOfType<NetworkManager>();		
	}

	public void SubmitLogin() {

		if(loginUserEmailInput.text == "" || loginPasswordInput.text == "") {

			mensajeLogin.text = "Por favor llenar todos los campos";
			return;
		}

		mensajeLogin.text = "Procesando...";

		networkManager.CheckUser(loginUserEmailInput.text, loginPasswordInput.text, delegate(Response response) 
		{
			mensajeLogin.text = response.message;

			string prueba = ""+mensajeLogin.text;
				
			if(prueba == "Bienvenido"){
				
				LoadScene("Main");			
			}
		});	
	}

    public void LoadScene(string sceneName) {

        SceneManager.LoadScene(sceneName);
    }
}

