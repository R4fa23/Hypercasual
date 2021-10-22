using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FundoController : MonoBehaviour
{
    public Fundo fundo1;
    public Fundo fundo2;
    int indice;
    int minInd;
    int maxInd;
    bool sorteio;


    void Start()
    {
        
    }


    void Update()
    {
        if(fundo1.atual == fundo2.atual)
        {
            fundo1.atual++;
        }
    }

    public void Fundo1()
    {

        fundo1.CriarFundo();
    }

    public void Fundo2()
    {

        fundo2.CriarFundo();
    }
}
