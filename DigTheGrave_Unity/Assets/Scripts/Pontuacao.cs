using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Pontuacao : MonoBehaviour
{
    /* Variáveis */
    public int Pontos {get; private set ;}
    [SerializeField]
    private Text textoPontuacao;
    private AudioSource audioPontuacao;

    /* Métodos */
    private void Awake() 
    {
        audioPontuacao = GetComponent<AudioSource>();
    }
    public void AdicionarPontos()
    {
        Pontos++;
        textoPontuacao.text = Pontos.ToString();
        audioPontuacao.Play();
    }

    public void ReiniciarPontos()
    {
        Pontos = 0;
        textoPontuacao.text = Pontos.ToString();
    }

    public void SalvarRecorde()
    {
        int recordeAtual = PlayerPrefs.GetInt("recorde");
        if (Pontos > recordeAtual)
        {
            PlayerPrefs.SetInt("recorde", Pontos);
        }
    }
}
