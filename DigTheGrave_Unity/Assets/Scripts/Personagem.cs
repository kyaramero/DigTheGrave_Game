using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Personagem : MonoBehaviour
{

    /* VARIÁVEIS */
    Rigidbody2D fisica;
    [SerializeField]
    private float forca;
    private Diretor diretor;
    private Vector3 posicaoInicial;
    private bool deveImpulsionar;

    /* MÉTODOS */
    private void Awake() 
    {
        this.fisica = this.GetComponent<Rigidbody2D>();
        this.diretor = GameObject.FindObjectOfType<Diretor>();
        posicaoInicial = transform.position;
    }

    private void Start() 
    {
        this.diretor = GameObject.FindObjectOfType<Diretor>();
    }

    private void Update()
    {
        if(Input.GetButtonDown("Jump")) 
        {
            this.deveImpulsionar = true;
        }
    }

    private void FixedUpdate() 
    {
        if (deveImpulsionar)
        {
            this.Impulsionar();
        }
        
    }
    private void Impulsionar() 
    {
        fisica.velocity = Vector2.zero;
        this.fisica.AddForce(Vector2.up * forca, ForceMode2D.Impulse);
        deveImpulsionar = false;
    }

    private void OnCollisionEnter2D(Collision2D other) 
    {
        this.fisica.simulated = false;
        this.diretor.FinalizarJogo();
    }

    public void ReiniciarPersonagem()
    {
        transform.position = posicaoInicial;
        fisica.simulated = true;
    }
}
