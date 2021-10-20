using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Prateleira : MonoBehaviour
{
    public LivroEstante[] livros;

    public int ligar;
    public int contador;

    bool sorteando;



    public int indice;
    int minInd;
    int maxInd;

    void Start()
    {
        minInd = 0;
        maxInd = livros.Length;        
        sorteando = true;
    }

    void Update()
    {
        if (sorteando)
        {
            SortearLivros();
        }

      if(contador >= ligar)
        {
            sorteando = false;
        }

    }

    public void SortearLivros()
    {
        indice = Random.Range(minInd, maxInd);

        for (int i = 0; i < livros.Length; i++)
        {
            if (i == indice && livros[i].cheio == false)
            {
                livros[i].CriarLivro();
                contador ++;
            }
        }
    }


    public void Resetar()
    {
        for (int i = 0; i < livros.Length; i++)
        {
            livros[i].cheio = false;
        }

        contador = 0;
        sorteando = true;
    }
  
}
