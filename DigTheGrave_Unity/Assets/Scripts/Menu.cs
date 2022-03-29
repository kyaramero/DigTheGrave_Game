using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Menu : MonoBehaviour
{
    /* VARIÁVEIS */
    [SerializeField]
    private GameObject botaoSair;

    /* MÉTODOS */
    private void Start () 
    {
    #if UNITY_STANDALONE || UNITY_EDITOR
        botaoSair.SetActive(true);
    #endif
    }

    public void Jogar()
    {
        SceneManager.LoadScene("Jogo");
    }
    public void Creditos()
    {
        SceneManager.LoadScene("Creditos");
    }
    public void Sair()
    {
        Application.Quit();
        #if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
        #endif
    }
}
