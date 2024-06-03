using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interface : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }
}

// Usamos interfaces para abstrair a implementa��o de m�todos comuns a diferentes classes, para que elas tenham
// caracter�sticas parecidas, mas comportamentos distintos
// Tamb�m diminu�mos o acoplamento, aumentamos a capacidade de manuten��o,
// reutiliza��o de c�digo (ao iterar sobre diferentes objetos que s�o instanciados atrav�s da interface)
public interface Interactions
{
    public void Interact();
}

public class Door:MonoBehaviour, Interactions
{
    public void Interact()
    {
        print("The door has been opened");
    }
}
