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
    public bool rag;
    public Estante estante;
    Vector2 force;
    int indice;
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

        force = new Vector2(0, 100);        
        torque = Random.Range(-5, 5);
        rb = gameObject.GetComponent<Rigidbody2D>();
        rb.gravityScale = 0;

    }

    void Update()
    {
        if (projetil && estante == null)
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
                    break;
                }                
            }            
        }

        
        
    }
    private void FixedUpdate()
    {
        if (Controller.gameOver == true && projetil == false && rag == true)
        {
            Debug.Log("explode");
            rag = true;
            rb.velocity = new Vector2(force.x, force.y);
            
            rag = false;
            
            
        }

        if (Controller.gameOver == true )
        {
            rb.gravityScale = 1;
            rb.AddTorque(torque);
        }
    }

    public void CriarLivro()
    {        
        indice = Random.Range(minInd, maxInd);        
        cheio = true;
    }

    public void SomarQnt()
    {
        estante.quantidade++;
    }
}
