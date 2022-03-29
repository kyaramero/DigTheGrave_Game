using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControleDeDificuldade : MonoBehaviour
{
    /* VARIÁVEIS */
    [SerializeField]
    private float tempoDificuldadeHard;
    public float TempoPercorrido;
    public float Dificuldade {get; private set; }
    
    /* MÉTODOS */
    void Update()
    {
        this.TempoPercorrido += Time.deltaTime;
        this.Dificuldade = TempoPercorrido / tempoDificuldadeHard;
        Dificuldade = Mathf.Min(1, Dificuldade);
    }
}
