using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Controller : MonoBehaviour
{
    static public int vida;
    static public bool gameOver = false;
    static public bool atirar = true;
    static public int pontos;
    [SerializeField] Text scoreText;

    void Start()
    {
        pontos = 0;
        vida = 5;
    }

    // Update is called once per frame
    void Update()
    {
        scoreText.text = pontos.ToString();
        if (vida<= 0)
        {
            gameOver = true;
            atirar = false;
        }

    }

    
}
