using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;
public class EnemyShoot : MonoBehaviour
{
    public float spawnTime;
    public GameObject bolafuegopre;

    public GameObject camera;
    private float counter;

    public Transform salida;
  
    private bool trakeado= false;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.LookAt(camera.transform.position);
        salida.LookAt(camera.transform.position);
        if(trakeado==true){
            counter += Time.deltaTime;
            if(counter > spawnTime)
            {
                GameObject bolafuego = Instantiate(bolafuegopre,salida.position, salida.rotation);
                
                counter=0;
            }
        }
    }

    public void isTracked()
    {
        trakeado = true;
    }

    public void isnotTracked()
    {
        trakeado = false;
    }
}
