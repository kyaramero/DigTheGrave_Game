using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RetornarAoMenu : MonoBehaviour
{
     public void Retornar()
    {
        SceneManager.LoadScene("Menu");
    }
}
