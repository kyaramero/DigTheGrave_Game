using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeradorDeObstaculos : MonoBehaviour
{
    /* VARIÁVEIS */
    [SerializeField]
    private float tempoDeGeracaoFacil;
    [SerializeField]
    private float tempoDeGeracaoDificil;
    private float cronometro;
    public GameObject PrefabObstaculo;
    private ControleDeDificuldade controleDeDificuldade;

    /* MÉTODOS */
    private void Awake() 
    {
        cronometro = tempoDeGeracaoFacil;
    }

    private void Start() 
    {
        controleDeDificuldade = GameObject.FindObjectOfType<ControleDeDificuldade>();
    }
    void Update()
    {
        cronometro -= Time.deltaTime;
        if (cronometro < 0) 
        {
            GameObject.Instantiate(PrefabObstaculo, transform.position, Quaternion.identity);
            cronometro = Mathf.Lerp(tempoDeGeracaoFacil, tempoDeGeracaoDificil, controleDeDificuldade.Dificuldade);
        }
    }
}
