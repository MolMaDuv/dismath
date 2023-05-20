using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using System;

public class RegistroAcudiente : MonoBehaviour {

	[Header("Mensaje Registro Acudiente")]
	[SerializeField] private Text mensajeAcudiente = null;

	[Header("Registro Acudiente")]
	[SerializeField] private InputField cedulaAcudienteInput = null;
	[SerializeField] private InputField nombreAcudienteInput = null;
	[SerializeField] private InputField apellidoAcudienteInput = null;
	[SerializeField] private InputField parentescoAcudienteInput = null;
	[SerializeField] private InputField celularAcudienteInput = null;
	[SerializeField] private InputField correoAcudienteInput = null;
	[SerializeField] private InputField direccionAcudienteInput = null;

	private NetworkManager networkManager = null;

	private void Awake() {

		networkManager = GameObject.FindObjectOfType<NetworkManager>();		
	}

	public void SubmitRegistroAcudiente() {
		
		if(cedulaAcudienteInput.text == "" || nombreAcudienteInput.text == "" || apellidoAcudienteInput.text == "" || parentescoAcudienteInput.text == "" || celularAcudienteInput.text == "" || correoAcudienteInput.text == "" || direccionAcudienteInput.text == "") {

			mensajeAcudiente.text = "Por favor llenar todos los campos";
			return;
		}

		mensajeAcudiente.text = "Procesando...";

		networkManager.CreateAcudiente(Int32.Parse(cedulaAcudienteInput.text), nombreAcudienteInput.text, apellidoAcudienteInput.text, parentescoAcudienteInput.text, celularAcudienteInput.text, correoAcudienteInput.text, direccionAcudienteInput.text, delegate(Response response) 
		{
			mensajeAcudiente.text = response.message;
		});
	}
}
