using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TamRegletas : MonoBehaviour
{

    public Regleta tamRegleta1;
    public Regleta tamRegleta2;
    public Regleta tamRegleta3;
    public Regleta tamRegletaRes;

    public float res;
    public float x;
    public float y;
    
    void Start()
    {
        generarTamaños();
    }


	public void generarTamaños()
	{
		res = Random.Range(1,12);
		x = Random.Range(1,12);	
		y = Random.Range(1,12);	
		
		while(res == x || res == y || x == y){

			x = Random.Range(1,10);	
			y = Random.Range(1,10);	
		}

		int n = Random.Range(1,4);

		if(n == 1){ 

			tamRegletaRes.modificarEscala(res);
			tamRegleta1.modificarEscala(res);
			tamRegleta2.modificarEscala(x);
			tamRegleta3.modificarEscala(y);

			tamRegleta1.respuestaC = true;
		}

		if(n == 2){ 

			tamRegletaRes.modificarEscala(res);
			tamRegleta1.modificarEscala(x);
			tamRegleta2.modificarEscala(res);
			tamRegleta3.modificarEscala(y);

			tamRegleta2.respuestaC = true;
		}

		if(n == 3){ 

			tamRegletaRes.modificarEscala(res);
			tamRegleta1.modificarEscala(x);
			tamRegleta2.modificarEscala(y);
			tamRegleta3.modificarEscala(res);

			tamRegleta3.respuestaC = true;
		}


	}

}
