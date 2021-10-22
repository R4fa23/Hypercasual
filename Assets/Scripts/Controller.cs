using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Controller : MonoBehaviour
{
    public GameObject gameOverB;
    public Image[] vidas;
    static public int vida;
    static public bool gameOver = false;
    static public bool atirar = true;
    static public int pontos;
    [SerializeField] Text scoreText;
    [SerializeField] Text vidaText;


    void Start()
    {
        pontos = 0;
        vida = 5;

    }

    // Update is called once per frame
    void Update()
    {
        vidaText.text = "Vida: " + vida.ToString();

        scoreText.text = pontos.ToString();
        if (vida <= 0)
        {
            gameOver = true;
            gameOverB.SetActive(true);
            atirar = false;
        }

    }

    public void ResetarCena()
    {
        gameOver = false;
        atirar = true;
        vida = 5;
        SceneManager.LoadScene("Jogo");
    }

}