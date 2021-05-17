using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Shootscript : MonoBehaviour
{
    public GameObject arCamera;
    public GameObject explosion;
    public GameObject magic;

    public GameObject efecto;

    public GameObject disparo;
    public GameObject botonCambiar;

    public Button boton;
    public Transform salida;

    public Transform puntarifle;

    public GameObject bastonarma;

    public void Shoot(){
        RaycastHit hit;

        boton.gameObject.SetActive(false);

        if(bastonarma.activeInHierarchy){
            Instantiate(efecto,salida.position, Quaternion.LookRotation(salida.position));
        }
        else{
            Instantiate(disparo,puntarifle.position, Quaternion.LookRotation(puntarifle.position));
        }

        StartCoroutine(Esperaractivar());

        if(Physics.Raycast(arCamera.transform.position, arCamera.transform.forward, out hit)){
            switch(hit.transform.name)
            {
                case "SJ001":
                    hit.transform.gameObject.SendMessage("reducirVida");

                    Instantiate(explosion,hit.point, Quaternion.LookRotation(hit.normal));
                    //Instantiate(pref, gameObject.transform.position,gameObject.transform.rotation);
                    break;

                case "baston":                
                    hit.transform.gameObject.SetActive(false);
                    botonCambiar.SetActive(true);
                    Instantiate(magic,hit.point, Quaternion.LookRotation(hit.normal));
                    //Instantiate(pref, gameObject.transform.position,gameObject.transform.rotation);
                    break;

                case "bigPig":
                    hit.transform.gameObject.SendMessage("reducirVida");
                    Instantiate(explosion,hit.point, Quaternion.LookRotation(hit.normal));

                    break;

                
                case "attackBot":
                    hit.transform.gameObject.SendMessage("reducirVida");
                    Instantiate(explosion,hit.point, Quaternion.LookRotation(hit.normal));
                    break;

                case "Tower Mage":
                    hit.transform.gameObject.SendMessage("reducirVidaMagic");
                    Instantiate(explosion,hit.point, Quaternion.LookRotation(hit.normal));
                    break;
            }
        }

    }

    IEnumerator Esperaractivar(){
        yield return new WaitForSeconds(1);
        boton.gameObject.SetActive(true);
    }
}
