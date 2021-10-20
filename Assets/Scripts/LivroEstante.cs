using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LivroEstante : MonoBehaviour
{
    public Sprite[] livrosSprite;
    public int indice;
    
    int minInd;
    int maxInd;

    public Image imagem;

    public bool cheio;

    private void Start()
    {
        minInd = 0;
        maxInd = livrosSprite.Length;

        imagem = gameObject.GetComponent<Image>();
        imagem.sprite = null;

        imagem.enabled = false;
        cheio = false;     

    }

    void Update()
    {
        if (cheio == true)
        {
            for (int i = 0; i < livrosSprite.Length; i++)
            {
                if (i == indice)
                {
                    imagem.sprite = livrosSprite[i];
                }
            }

            imagem.enabled = true;
        } else
        {
            imagem.enabled = false;
        }
    }

    public void CriarLivro()
    {        
        indice = Random.Range(minInd, maxInd);
        cheio = true;
    }
}
