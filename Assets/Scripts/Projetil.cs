using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projetil : MonoBehaviour
{
    [SerializeField] Transform cursor;
    [SerializeField] Vector2 force;
    AudioSource source;

    [SerializeField] AudioClip[] clips;
    public AudioClip som;

    public bool mirando;

    LivroEstante livro;
    Rigidbody2D rb;
    SpriteRenderer sprite;
    
    void Start()
    {
        source = GetComponent<AudioSource>();
        sprite = GetComponent<SpriteRenderer>();
        livro = gameObject.GetComponent<LivroEstante>();
        livro.CriarLivro();
        mirando = true;
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
       if(Controller.atirar == false)
        {
            gameObject.SetActive(false);
        }
        if (mirando)
        {
            gameObject.transform.position = cursor.position;
        }
        else       
        {
            gameObject.transform.position = gameObject.transform.position;
            
        }

        if(Controller.som == true)
        {
            GetComponent<AudioSource>().enabled = true;
        }
        else {
            GetComponent<AudioSource>().enabled = false;
        }

    }

    public void Atirar()
    {
        if(mirando == true)
        {
            mirando = false;
            rb.velocity = force;
            source.PlayOneShot(som);
        }
        
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
            Controller.vida -= 1;
            Resetar();
        }

        if (colisor.gameObject.tag == "Livro")
        {            
            if (livro.atirado == false)
            {
                Controller.pontos += 10;
                livro.imagem.sprite = sprite.sprite;
                livro.atirado = true;
                int index = Random.Range(0, clips.Length);
                GetComponent<AudioSource>().PlayOneShot(clips[index]);                
                livro.SomarQnt();
                Resetar();
            }
            
        }
    }
}
