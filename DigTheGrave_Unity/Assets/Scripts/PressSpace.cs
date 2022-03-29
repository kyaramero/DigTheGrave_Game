using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PressSpace : MonoBehaviour
{
    [SerializeField]
    private Text textoPressSpace;

    void Update()
    {
        if(Input.GetButtonDown("Jump"))
        {
            Desaparecer();
        }       
    }

    private void Desaparecer()
    {
        textoPressSpace.enabled = false;
    }
}
