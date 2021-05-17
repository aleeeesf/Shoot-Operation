using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class CambiarEscena : MonoBehaviour
{
    // Start is called before the first frame update
    public AudioSource fuente;
    public AudioClip clip;
    private Button button;
    private Button buttonExit;
    void Start()
    {
        fuente.clip = clip;
        button = GameObject.FindWithTag("btStart").GetComponent<Button>();    
        button.onClick.AddListener(Pulsado); 
    }

    private void Pulsado()
    {
        SceneManager.LoadScene("Juego",LoadSceneMode.Single);
    }

    public void Reproducir()
    {
        fuente.Play();
    }
}
