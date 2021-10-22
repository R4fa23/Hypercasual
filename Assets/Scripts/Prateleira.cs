using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Prateleira : MonoBehaviour
{
    
    public LivroEstante[] livros;    
    int ligar;
    int indice;

    int contador;
    int minInd;
    int maxInd;

    bool sorteando;

    void Start()
    {
        ligar = Random.Range(0, livros.Length-1);
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
                livros[i].SomarQnt();
                contador++;
            }
        }
    }


    public void Resetar()
    {
        for (int i = 0; i < livros.Length; i++)
        {
            livros[i].cheio = false;
            livros[i].imagem.sprite = null;
            livros[i].atirado = false;
        }
        contador = 0;
        ligar = Random.Range(0, livros.Length -1);
        sorteando = true;
    }
  
}
