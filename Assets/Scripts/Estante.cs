using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Estante : MonoBehaviour
{
    public AudioSource source;
    public Prateleira[] prat;
    public int quantidade;
    bool movimento;
    Animator anim;
     
    // Start is called before the first frame update
    void Start()
    {
        source = GetComponent<AudioSource>();
        anim = GetComponent<Animator>();
        
    }

    // Update is called once per frame
    void Update()
    {
        if (quantidade >= 18)
        {
            quantidade = 0;
            Controller.pontos += 100;
            anim.SetTrigger("IrEsquerda");                      
        }        
    }
    
    public void Resetar()
    {
        foreach (var p in prat)
        {
            p.Resetar();
        }
        Controller.vida = 5;
    }

    public void Som()
    {
        source.Play();
    }
}
