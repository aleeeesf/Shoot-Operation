using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Temporizador : MonoBehaviour
{
    public Text texto;

    private float cont;
    void Start()
    {
        cont=0;
        texto.text=""+cont;
    }

    // Update is called once per frame
    void Update()
    {
        cont+=Time.deltaTime;
        texto.text=""+(int)cont;
    }
}
