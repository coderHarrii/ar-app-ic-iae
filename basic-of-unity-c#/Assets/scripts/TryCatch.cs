using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TryCatch : MonoBehaviour
{
    public int n1, n2, result;

    void Start()
    {
        try
        {
            result = n1 / n2;
        }
        catch(UnityException x)
        {
            print("Erro de divis�o por zero. Error: " + x);

            // Capturamos o erro em x. Nesse caso, por conta da captura do erro em x qualquer outra opera��o em vari�veis � ignorada
            // n2 = n2 + 1;
            // result = n1 / n2;
        }
        // Posso executar finally independente se tiver um erro ou n�o
        finally
        {
            print("Processo finalizado");
        }
    }
}
