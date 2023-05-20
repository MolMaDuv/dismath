using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Text;

public class CuboOperacion : MonoBehaviour
{
    // Start is called before the first frame update
    Vector3 posInicial; //variable de vector en el cual empieza el dado al inicial el juego
    Vector3 posRespuesta = new Vector3(-0.234999999f,0.400999993f,0.34799999f);  //posicion a la cual se movera el dado
    int cuboCorrecto;

    public float n;
    public float x;
    public float y;

    public Text caraOp1;
    public Text caraOp2;
    public Text caraOp3;
    public Text caraOp4;
    public Text caraOp5;
    public Text caraOp6;

    public Text cara1;
    public Text cara2;
    public Text cara3;
    public Text cara4;
    public Text cara5;
    public Text cara6;

    public Text cara7;
    public Text cara8;
    public Text cara9;
    public Text cara10;
    public Text cara11;
    public Text cara12;

    public Text cara13;
    public Text cara14;
    public Text cara15;
    public Text cara16;
    public Text cara17;
    public Text cara18;

    public Cubo resDado1;
    public Cubo resDado2;
    public Cubo resDado3;

    
    void Start()
    {
	float res = generarOperaciones();
	generarNumeros(res);
    }
	

	public void generarNumeros(float res)
	{		
		x = Random.Range(1,10);	
		y = Random.Range(1,10);	
		
		while(res == x || res == y || x == y){

			x = Random.Range(1,10);	
			y = Random.Range(1,10);	
		}

		// n representa el numero del dado en el que va a quedar la respuesta, dado1 o dado2 o dado3
		int n = Random.Range(1,4);

		if(n == 1){
			cara1.text = ""+res;
			cara2.text = ""+res;
			cara3.text = ""+res;
			cara4.text = ""+res;
			cara5.text = ""+res;
			cara6.text = ""+res;

			cara7.text = ""+x;
			cara8.text = ""+x;
			cara9.text = ""+x;
			cara10.text = ""+x;
			cara11.text = ""+x;
			cara12.text = ""+x;

			cara13.text = ""+y;
			cara14.text = ""+y;
			cara15.text = ""+y;
			cara16.text = ""+y;
			cara17.text = ""+y;
			cara18.text = ""+y;   

			cuboCorrecto = 1;
			resDado1.respuestaC = true;
		}

		if(n == 2){
			cara1.text = ""+x;
			cara2.text = ""+x;
			cara3.text = ""+x;
			cara4.text = ""+x;
			cara5.text = ""+x;
			cara6.text = ""+x;

			cara7.text = ""+res;
			cara8.text = ""+res;
			cara9.text = ""+res;
			cara10.text = ""+res;
			cara11.text = ""+res;
			cara12.text = ""+res;

			cara13.text = ""+y;
			cara14.text = ""+y;
			cara15.text = ""+y;
			cara16.text = ""+y;
			cara17.text = ""+y;
			cara18.text = ""+y;

			cuboCorrecto = 2;
			resDado2.respuestaC = true;
		}

		if(n == 3){
			cara1.text = ""+x;
			cara2.text = ""+x;
			cara3.text = ""+x;
			cara4.text = ""+x;
			cara5.text = ""+x;
			cara6.text = ""+x;

			cara7.text = ""+y;
			cara8.text = ""+y;
			cara9.text = ""+y;
			cara10.text = ""+y;
			cara11.text = ""+y;
			cara12.text = ""+y;

			cara13.text = ""+res;
			cara14.text = ""+res;
			cara15.text = ""+res;
			cara16.text = ""+res;
			cara17.text = ""+res;
			cara18.text = ""+res;

			cuboCorrecto = 3;
			resDado3.respuestaC = true;
		}

	}
	
	 public float generarOperaciones() {	

		n = Random.Range(1,3);		
		x = Random.Range(1,10);	

		caraOp1.text = "" + n + "\n + \n" + x;
		caraOp2.text = "" + n + "\n + \n" + x;
		caraOp3.text = "" + n + "\n + \n" + x;
		caraOp4.text = "" + n + "\n + \n" + x;
		caraOp5.text = "" + n + "\n + \n" + x;
		caraOp6.text = "" + n + "\n + \n" + x;

		return (n + x);
	}  

	public int retornarCuboCorrecto() {
		return cuboCorrecto;
	}  
}
