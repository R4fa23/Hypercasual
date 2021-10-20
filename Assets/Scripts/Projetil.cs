using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projetil : MonoBehaviour
{
    [SerializeField] Transform alvo;
    bool mirando;
    
    void Start()
    {
        mirando = true;
    }

    void Update()
    {
        if (mirando)
        {
            gameObject.transform.position = alvo.position;
        }

        
    }

    public void Resetar()
    {

    }
}
