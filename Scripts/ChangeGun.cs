using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeGun : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject gun1;
    public GameObject gun2;
    private int whatGun = 1;

    
    // Update is called once per frame
    public void CambiarArma()    
    {
        if(whatGun == 1)
        {
            whatGun = 2;
            gun1.SetActive(false);
            gun2.SetActive(true);
        }
        else
        {
            whatGun = 1;
            gun1.SetActive(true);
            gun2.SetActive(false);
        }            
    }
}
