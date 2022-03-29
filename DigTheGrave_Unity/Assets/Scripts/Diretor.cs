using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Diretor : MonoBehaviour
{
    /* VARIÁVEIS */
    private Personagem personagem;
    private Pontuacao pontuacao;
    [SerializeField]
    private GameObject trilhaSonora;
    [SerializeField]
    private GameObject quadroPontos;
    private InterfaceGameOver interfaceGameOver;
    [SerializeField]
    private GameObject pressSpace;
    private ControleDeDificuldade controleDeDificuldade;

    /* MÉTODOS */
    private void Start()
    {
        this.personagem = GameObject.FindObjectOfType<Personagem>();
        this.pontuacao = GameObject.FindObjectOfType<Pontuacao>();
        this.interfaceGameOver = GameObject.FindObjectOfType<InterfaceGameOver>();
        this.controleDeDificuldade = GameObject.FindObjectOfType<ControleDeDificuldade>();
    }
    public void FinalizarJogo() 
    {
        Time.timeScale = 0;
        interfaceGameOver.ExibirInterface();
        trilhaSonora.SetActive(false);
        pressSpace.SetActive(false);
        pontuacao.SalvarRecorde();
        interfaceGameOver.AtualizarInterface();
        controleDeDificuldade.TempoPercorrido = 0;
    }
    
    public void ReiniciarJogo()
    {
        interfaceGameOver.EsconderInterface();
        Time.timeScale = 1;
        personagem.ReiniciarPersonagem();
        DestruirObstaculos();
        pontuacao.ReiniciarPontos();
        quadroPontos.SetActive(true);
        trilhaSonora.SetActive(true);
        pressSpace.SetActive(true);
    }

    private void DestruirObstaculos()
    {
        Obstaculo[] obstaculos = GameObject.FindObjectsOfType<Obstaculo>();
        foreach(Obstaculo obstaculo in obstaculos)
        {
            obstaculo.Destruir();
        }
    }
}
