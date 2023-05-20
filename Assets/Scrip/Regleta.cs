using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using System;

public class Regleta : MonoBehaviour
{
    // Start is called before the first frame update
    Vector3 posInicial; //variable de vector en el cual empieza el Regleta al inicial el juego
    Vector3 posRespuesta = new Vector3(7.5f,0.0f,3.5f);  //posicion a la cual se movera la Regleta

    public bool respuestaC = false;
   

    public GameObject sonidoCorrecto;
    public GameObject sonidoIncorrecto;
    
    void Start()
    {
        posInicial = transform.position;
    }

    //guardo el resultado en vectores de donde quedo el Regleta ubicado luego de moverlo
    public void moverRegletaResultado()
    {
        transform.position = posInicial;
    }
    //metodo para mover el Regleta a traves de transformar su posicion en vectores
    public void moverRegleta()
    {
        transform.position = posRespuesta;
    }
    //metodos para validar si la respuesta dada por el usuario es correcta, con el fin de saber qué sonido reproducir
    public void validarRespuesta()
    {
        if (validarComponenteTransform() && respuestaC == true)
        {
            Instantiate(sonidoCorrecto);
	    LoadScene();
        }
        else
        {
            Instantiate(sonidoIncorrecto);
        }
    }
//metodo que valida si el Regleta se movio
    private bool validarComponenteTransform()
    {
        if ( Mathf.Approximately(transform.position.x, posRespuesta.x )&& Mathf.Approximately(transform.position.y, posRespuesta.y) && Mathf.Approximately(transform.position.z, posRespuesta.z) )
        {
            return true;
        }
        else
        {
            return false;
        }
    }

	public void modificarEscala(float t) {

		transform.localScale = new Vector3(1.990355f,0.1990355f, t);
	}

	public void LoadScene() {
		SceneManager.LoadScene("Regletas");
	}

    
}
