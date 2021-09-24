using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class plataformaCresce : MonoBehaviour
{
    public Vector3 scaleChange;
    public Vector3 scaleChange2;
    // Start is called before the first frame update
    void Awake()
    {
        scaleChange = new Vector3 (10f,01f,1f);
        scaleChange2 = new Vector3 (1f,1f,1f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            transform.localScale += scaleChange;
        }
    }
    void OnCollisionExit2D (Collision2D collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            transform.localScale = scaleChange2;
        }
    }
}
