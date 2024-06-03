using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sealed_class : MonoBehaviour
{
    private A a = new A();
    void Start()
    {
        a.ShowSomething();
    }
}

// Uma classe selada n�o pode ser herdada por outra classe
// Motivo de uso: Ela n�o cont�m todas as caracter�sticas que uma classe normal possui,
// justamente pq pelo fato de n�o permitir a heran�a ela carrega menos propriedades na mem�ria
// ou seja, temos uma otimiza��
// o no nosso sistema
public sealed class A
{
    public void ShowSomething()
    {
        Debug.Log("Showing something...");
    }
}