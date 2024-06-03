using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

// MODIFICADORES DE PAR�METRO: REF, OUT PARAMS
public class RefOutParams : MonoBehaviour
{
    private int n;
    private int sub;

    // Start is called before the first frame update
    void Start()
    {
        n = 10;
        Example(10);
        print(Example(10, 5, out sub));
        print(Example(10, 20, 30, 50, 40));
    }

    // Passagem de parametros normal (passagem de valor de uma vari�vel para outra)
    private void Example(int n)
    {
        print(n);
    }

    // O problema com a solu��o anterior � que ela usa dois espa�os de mem�ria diferentes (duas vari�veis) para
    // trabalhar com o mesmo valor, podemos usar o modificador de par�metro Ref para fazer uma refer�ncia/ apontar
    // para a vari�vel original e trabalhar apenas com seu valor no m�todo, em vez de criar uma vari�vel adicional que
    // aponte para tal. � quase um ponteiro em C, a diferen�a � que n�o criamos uma vari�vel que aponta para outra, mas
    // sim passamos literalmente o endere�o de mem�ria onde aquela vari�vel est� na mem�ria

    private void Example (ref int n)
    {
        print(n);
    }

    // Out aqui permite um retorno direto no endere�o de mem�ria da vari�vel passada como par�metro, pode permitir
    // mais de um retorno
    private int Example(int a, int b, out int sub)
    {
        print(a + b);
        sub = a - b;
        print(sub);
        return a + b;
    }

    private int Example(params int [] n)
    {
        int sum, i;

        sum = 0;
        for(i = 0; i < n.Length; i++)
            sum += n[i];

        return sum;
    }
}
