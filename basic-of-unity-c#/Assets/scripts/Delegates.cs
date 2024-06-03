using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Com delegates podemos referenciar um m�todo por uma vari�vel de mesma assinatura (tipo e par�metros)
public class Delegates : MonoBehaviour
{
    // Defino um tipo (assinatura)
    private delegate void Example();
    // para instanciar um objeto com a mesma assinatura
    private Example variableDelegate;
    
    void Start()
    {
        variableDelegate = this.Attack;
        variableDelegate();

        // A grande utilidade do delegate � poder fazer a chamada de mais de um m�todo de uma vez
        variableDelegate += this.Jump;
        variableDelegate += this.Defend;
        variableDelegate();
    }

    private void Attack()
    {
        print("Atacking");
    }

    private void Jump()
    {
        print("Im Jumping");
    }

    // Podemos ainda passar uma vari�vel delegate como par�metro de m�todos
    private void Defend(Example deleg)
    {
        print("Im defending myself");
    }
}