using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;

public class Invoke : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // Busco um m�todo com o mesmo nome da string passada como argumento ap�s 2.5 segundos da execu��o
        // dessa instru��o. 
        // Problema: Ele consome bastante mem�ria e pode deixar o programa lento
        Invoke("Invoked", 2.5f);
    }

    private void Invoked()
    {
        print("Invoked");
    }
}
