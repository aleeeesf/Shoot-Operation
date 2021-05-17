using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Opacity : MonoBehaviour
{
    // Start is called before the first frame update
    public Image imageOpac;
    void Start()
    {
        imageOpac.canvasRenderer.SetAlpha(0.3f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
