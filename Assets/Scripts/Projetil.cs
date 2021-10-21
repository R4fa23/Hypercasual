using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projetil : MonoBehaviour
{
    [SerializeField] Transform cursor;
    [SerializeField] Vector2 force;

    public bool mirando;

    LivroEstante livro;
    Rigidbody2D rb;
    SpriteRenderer sprite;
    
    void Start()
    {
        sprite = GetComponent<SpriteRenderer>();
        livro = gameObject.GetComponent<LivroEstante>();
        livro.CriarLivro();
        mirando = true;
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if (mirando)
        {
            gameObject.transform.position = cursor.position;
        }
        else       
        {
            gameObject.transform.position = gameObject.transform.position;
        }

        
    }

    public void Atirar()
    {
        mirando = false;
        rb.velocity = force;

    }

    public void Resetar()
    {
        mirando = true;
        livro.CriarLivro();
    }

    void OnTriggerEnter2D(Collider2D colisor)
    {
        LivroEstante livro;
        livro = colisor.GetComponent<LivroEstante>();
        if (colisor.gameObject.tag == "Reset" )
        {
            Resetar();
        }

        if (colisor.gameObject.tag == "Livro")
        {            
            if (livro.atirado == false)
            {
                Debug.Log(colisor.gameObject.name);
                livro.imagem.sprite = sprite.sprite;
                livro.atirado = true;
                Resetar();
            }
            
        }
    }
}
