using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoroutinesIEnumerator : MonoBehaviour
{
    private void Start()
    {
        StartCoroutine(Routine());
    }

    // � uma interface, uma coroutine permite executar um c�digo, fazer outra coisa em paralelo e dps
    // continuar a primeira tarefa
    IEnumerator Routine()
    {
        Debug.Log("Initializing");
        yield return new WaitForSeconds(2);
        Debug.Log("2 minutes has been passed");
        yield return null;
    }
}
