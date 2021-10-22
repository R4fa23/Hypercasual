using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cursor : MonoBehaviour
{
    Animator anim;
    float speed;
    [SerializeField] Estante estante;
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    
    void Update()
    {
        if (estante.quantidade < 6)
        {
            speed = 0.5f;            
        }

        if (estante.quantidade >= 6 && estante.quantidade < 12)
        {
            speed = 1f;         

        }    

        if (estante.quantidade >= 12 && estante.quantidade < 18)
        {
            speed = 1.5f;
        

        }

        anim.speed = speed;
    }
}
