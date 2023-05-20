using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ConfSonido : MonoBehaviour
{

	[Header("Options")]
	public AudioMixer mixer;
	public AudioSource fxSource;
	public AudioClip clickSound;
	public float lastVolumen;

    // Start is called before the first frame update
    void Start()
    {
        
    }
}
