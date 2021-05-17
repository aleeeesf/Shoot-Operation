using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movimientobala : MonoBehaviour
{
    public float velocidad = 2.0f;

    private float contador=0;

    public LayerMask layerplayer;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float moveDistancia = Time.deltaTime * velocidad;
        transform.Translate(Vector3.forward * moveDistancia);

        contador+=Time.deltaTime;

        CheckCollision(moveDistancia);

        if(contador>=15){
            Destroy(gameObject);
        }
    }

    void CheckCollision(float mDistancia){
        Ray ray= new Ray(transform.position, transform.forward);
        RaycastHit hit;
        if(Physics.Raycast(ray, out hit, mDistancia,layerplayer, QueryTriggerInteraction.Collide)){
            OnHitObject(hit);
        }
    }

    void OnHitObject(RaycastHit hit){
        GameObject.Destroy(gameObject);
        hit.transform.gameObject.SendMessage("reducirVida");

    }
}
