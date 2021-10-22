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
    static public bool som = true;
    [SerializeField] Text scoreText;
    [SerializeField] Text vidaText;


    void Start()
    {
        Application.targetFrameRate = 60;
        pontos = 0;
        vida = 10;

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
        vida = 10;
        SceneManager.LoadScene("Jogo");
    }

    public void Som()
    {
        som = !som;
    }

}