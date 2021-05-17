using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Vida : MonoBehaviour
{
    // Start is called before the first frame update
    private float vida;
    public float vidaMax = 5.0f;
    public Image barraDeVida;
    public GameObject enemigo;
    void Start()
    {
        vida = vidaMax;        
    }

    // Update is called once per frame
    void Update()
    {
        barraDeVida.fillAmount = vida/vidaMax;
    }

    public void reducirVida()
    {
        vida--;

        if(vida < 1)
        {
            if(gameObject.name=="player"){
                SceneManager.LoadScene("fin", LoadSceneMode.Single);
            }
            Destroy(enemigo);

            
        }
    }
}
