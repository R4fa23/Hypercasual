using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fundo : MonoBehaviour
{
    public Sprite[] fundos;
    SpriteRenderer imagem;
    int indice;
    int minInd;
    int maxInd;
    public int atual;
    bool sorteio;
    void Start()
    {
        sorteio = false;
        imagem = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        if (sorteio)
        {
            for (int i = 0; i < fundos.Length; i++)
            {
                if (i == indice)
                {
                    imagem.sprite = fundos[i];
                    sorteio = false;
                }
            }
        }
    }

    public void CriarFundo()
    {
        indice = Random.Range(0, fundos.Length);
        if(indice == atual)
        {
            indice++;
            
        }
        atual = indice;
        sorteio = true;        
    }
}
