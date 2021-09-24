using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class chaosome : MonoBehaviour
{
     int peso;

    void start()
    {
        peso = 0;
        chaofalso cf = new chaofalso();
        chaofalso.Peso = peso;
    }

    public void sumir()
    {
        Destroy(gameObject, 0.25f);
    }
    public void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag=="Player")
        {
           peso += 1; 
        }
    }
    
    void Update()
    {
        if (peso > 0)
        {

            sumir();
        }
    }
}
