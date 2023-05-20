using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GestosRegletas : MonoBehaviour
{
   
    [SerializeField]
    public Regleta[] miRegleta; //arreglo que guarda las posiciones de las caras del Regleta
    int posicionSeleccionada; 
   
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    //s
    //metodo que mueve los Regletas a la casiila de resultado para validas si es correcta
    public void detectarGestoResultado()
    {
        miRegleta[0].moverRegletaResultado();
        miRegleta[1].moverRegletaResultado();
        miRegleta[2].moverRegletaResultado();
    }
 //metodo  que retornma el Regleta 0 a la posicion de origen sacandolo de la casilla de respuesta
    public void detectarGesto1_Origen()
    {
        miRegleta[0].moverRegleta();
        miRegleta[1].moverRegletaResultado();
        miRegleta[2].moverRegletaResultado();
        posicionSeleccionada = 0;

    }
 //metodo  que retornma el Regleta 1 a la posicion de origen sacandolo de la casilla de respuesta

    public void detectarGesto2_Origen()
    {
        miRegleta[1].moverRegleta();
        miRegleta[0].moverRegletaResultado();
        miRegleta[2].moverRegletaResultado();
        posicionSeleccionada = 1;
    }
 //metodo  que retornma el Regleta 2 a la posicion de origen sacandolo de la casilla de respuesta

    public void detectarGesto3_Origen()
    {
        miRegleta[2].moverRegleta();
        miRegleta[0].moverRegletaResultado();
        miRegleta[1].moverRegletaResultado();
        posicionSeleccionada = 2;
    }
// metod que valida si el Regleta que esta en la casilla de respuesta es la correspondiente a la respuesta correcta de la suma
    public void seleccionRespuesta()
    {
        miRegleta[posicionSeleccionada].validarRespuesta();
        ///Invoke("seleccionRespuesta", 2f);
    }
    
   

    
}