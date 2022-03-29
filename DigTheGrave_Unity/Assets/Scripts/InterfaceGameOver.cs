using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InterfaceGameOver : MonoBehaviour
{
    /*  VARIÁVEIS */
    [SerializeField]
    private GameObject gameOver;
    [SerializeField]
    private Text TextoRecorde;
    private Pontuacao pontuacao;
    private int recorde;
    [SerializeField]
    private Image estrelaPosicao;
    [SerializeField]
    private Sprite umaEstrela;
    [SerializeField]
    private Sprite duasEstrelas;
    [SerializeField]
    private Sprite tresEstrelas;


    /* MÉTODOS */
    private void Start() 
    {
        this.pontuacao = GameObject.FindObjectOfType<Pontuacao>();
    }
    public void ExibirInterface()
    {
        AtualizarInterface();
        this.gameOver.SetActive(true);
    }

    public void EsconderInterface()
    {
        this.gameOver.SetActive(false);
    }
    
    public void AtualizarInterface()
    {
        this.recorde = PlayerPrefs.GetInt("recorde");
        TextoRecorde.text = recorde.ToString();

        this.VerificarEstrelas();
    }

    private void VerificarEstrelas()
    {
        if (pontuacao.Pontos > recorde - 3)
        {
            this.estrelaPosicao.sprite = this.tresEstrelas;
        }
        else if (pontuacao.Pontos > (recorde / 2))
        {
            this.estrelaPosicao.sprite = this.duasEstrelas;
        }
        else
        {
            this.estrelaPosicao.sprite = this.umaEstrela;
        }
    }
}
