using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Carrossel : MonoBehaviour
{
    /* VARIÁVEIS */
   [SerializeField]
   private VariavelCompartilhada velocidade;
   private Vector3 posicaoInicial;
   private float tamanhoRealDaImagem;
   private float tamanhoDaImagem;

    /* MÉTODOS */
   private void Awake() 
   {
       posicaoInicial = transform.position;
       tamanhoDaImagem = GetComponent<SpriteRenderer>().size.x;
       float escala = transform.localScale.x;
       tamanhoRealDaImagem = tamanhoDaImagem * escala;
   }
    void Update()
    {
        float deslocamento = Mathf.Repeat(velocidade.Valor * Time.time, tamanhoRealDaImagem);
        transform.position = posicaoInicial + (Vector3.left * deslocamento);
    }
}
