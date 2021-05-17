using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class VidaTorre : MonoBehaviour
{
    // Start is called before the first frame update
    private float vida;
    public float vidaMax = 5.0f;
    public Image barraDeVida;
    public GameObject enemigo;
    public GameObject Varita;
    void Start()
    {
        vida = vidaMax;        
    }

    // Update is called once per frame
    void Update()
    {
        barraDeVida.fillAmount = vida/vidaMax;
    }

    public void reducirVidaMagic()
    {
        if(Varita.gameObject.activeSelf)
        {
            vida--;

            if(vida < 1)
            {
                Destroy(enemigo);
               
                SceneManager.LoadScene("finGanador", LoadSceneMode.Single);
            
            }
        }
    }
}
