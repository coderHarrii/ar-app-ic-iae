using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnityFixedUpdate : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        Debug.Log("Update: " + Time.deltaTime);
    }

    // FixedUpdate � chamado de maneira constante num intervalo de tempo
    // independente de quantos frames tiverem naquele segundo
    // � mais �til em jogos que trabalham com f�sica, pois ele � mais preciso, o que � necess�rio para
    // os calculos
    private void FixedUpdate()
    {
        Debug.Log("Fixed Update: " + Time.deltaTime);
    }
}
