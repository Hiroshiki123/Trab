using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cerebro : MonoBehaviour
{
    private BoxCollider2D box;
    public int Pontuacao;
    // Start is called before the first frame update
    void Start()
    {
        box = GetComponent<BoxCollider2D>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerEnter2D(Collider2D collider)
    {
        if(collider.gameObject.tag == "Player")
        {
        GameController.instance.totalScore += Pontuacao;
        GameController.instance.UpdateScoreText();
        Destroy(gameObject, 0f);

        }
   
    }
}
