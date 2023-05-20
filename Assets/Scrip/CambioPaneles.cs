using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CambioPaneles : MonoBehaviour
{

	[Header("Panels")]
	public GameObject detalleModulosPanel;
	public GameObject detalleModulo1Panel;
	public GameObject detalleModulo2Panel;
	public GameObject detalleModulo3Panel;
	public GameObject detalleModulo4Panel;

	public void OpenPanel(GameObject panel) {

		detalleModulosPanel.SetActive(false);
		detalleModulo1Panel.SetActive(false);
		detalleModulo2Panel.SetActive(false);
		detalleModulo3Panel.SetActive(false);
		detalleModulo4Panel.SetActive(false);

		panel.SetActive(true);
	}
}
