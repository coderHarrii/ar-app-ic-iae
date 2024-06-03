using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnityAwake : MonoBehaviour
{
    // Podemos despertar um gameObject com este m�todo, e ele � executado antes do void Start, sendo tamb�m executado apenas uma �nica vez
    private void Awake()
    {
        print("Awake");
    }

    void Start()
    {
        print("Start");
    }
}
