using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LivroEstante : MonoBehaviour
{
    public Sprite[] livrosSprite;
    public SpriteRenderer imagem;
    public bool cheio;
    public bool projetil;
    public int indice;

    Vector2 force;
    int torque;
    int minInd;
    int maxInd;
    public bool atirado = false;
    

    Rigidbody2D rb;  

    private void Start()
    {
        minInd = 0;
        maxInd = livrosSprite.Length;

        imagem = gameObject.GetComponent<SpriteRenderer>();
        imagem.sprite = null;        
        cheio = false;

        force = new Vector2(10, 20);
        rb = gameObject.GetComponent<Rigidbody2D>();
        torque = Random.Range(-10, 10);

        


    }

    void Update()
    {
        if (projetil)
        {
            cheio = true;
        }

        if (cheio == true)
        {
            for (int i = 0; i < livrosSprite.Length; i++)
            {
                if (i == indice)
                {
                    imagem.sprite = livrosSprite[i];
                    atirado = true;
                }                
            }
        }
        
    }

   

    public void CriarLivro()
    {        
        indice = Random.Range(minInd, maxInd);
        cheio = true;
    }

    public void Explodir()
    {
        rb.gravityScale = 1;
        rb.AddTorque(torque);
        rb.AddForce(force);
    }
}
