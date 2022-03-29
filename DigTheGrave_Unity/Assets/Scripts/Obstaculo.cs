using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstaculo : MonoBehaviour
{
    /* VARIÁVEIS */
    [SerializeField]
    private VariavelCompartilhada velocidade;
    [SerializeField]
    private float variacaoY;
    private Vector3 posicaoPersonagem;
    private Pontuacao pontuacao;
    private bool pontuei;
        
    /* MÉTODOS */
    private void Awake() 
    {
        transform.Translate(Vector3.up * Random.Range(- variacaoY, variacaoY));
    }
    private void Start() 
    {
        posicaoPersonagem = GameObject.FindObjectOfType<Personagem>().transform.position;
        pontuacao = GameObject.FindObjectOfType<Pontuacao>();
    }
    private void Update()
    {
        transform.Translate(Vector3.left * velocidade.Valor * Time.deltaTime);

        if (!this.pontuei && this.transform.position.x < posicaoPersonagem.x)
        {
            pontuei = true;
            pontuacao.AdicionarPontos();
        }
    }
    private void OnTriggerEnter2D(Collider2D other) 
    {
        Destruir();
    }
    public void Destruir() 
    {
        Destroy(gameObject);
    }
}
