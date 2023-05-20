using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using System;

public class RegistroUsuario : MonoBehaviour {

	[Header("Mensaje Registro Jugador")]
	[SerializeField] private Text mensajeJugador = null;

	[Header("Registro Jugador")]
	[SerializeField] private InputField idJugadorInput = null;
	[SerializeField] private InputField nombreJugadorInput = null;
	[SerializeField] private InputField apellidoJugadorInput = null;
	[SerializeField] private InputField edadJugadorInput = null;
	[SerializeField] private InputField n_sesiones_asignadasJugadorInput = null;
	[SerializeField] private InputField cedula_terapeutaInput = null;
	[SerializeField] private InputField cedula_acudienteInput = null;
	[SerializeField] private InputField diagnosticoJugadorInput = null;

	private NetworkManager networkManager = null;

	private void Awake() {

		networkManager = GameObject.FindObjectOfType<NetworkManager>();		
	}

	public void SubmitRegistroJugador() {
		
		if(idJugadorInput.text == "" || nombreJugadorInput.text == "" || apellidoJugadorInput.text == "" || edadJugadorInput.text == "" || n_sesiones_asignadasJugadorInput.text == "" || cedula_terapeutaInput.text == "" || cedula_acudienteInput.text == "" || diagnosticoJugadorInput.text == "") {

			mensajeJugador.text = "Por favor llenar todos los campos";
			return;
		}

		mensajeJugador.text = "Procesando...";

		networkManager.CreateJugador(Int32.Parse(idJugadorInput.text), nombreJugadorInput.text, apellidoJugadorInput.text, Int32.Parse(edadJugadorInput.text), Int32.Parse(n_sesiones_asignadasJugadorInput.text), Int32.Parse(cedula_terapeutaInput.text), Int32.Parse(cedula_acudienteInput.text), diagnosticoJugadorInput.text, delegate(Response response) 
		{
			mensajeJugador.text = response.message;
		});
	}
}
