using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Player Prefs � uma maneira f�cil de salvar dados do tipo string, int e float
// Criado para salvar preferencias do jogador (idioma, brilho, cor etc)
// Problema: Player Prefs s�o vulner�veis por serem f�ceis de alterar por um usu�rio mal intencionado
public class UnityPlayerPrefs : MonoBehaviour
{
    int value;

    void Start()
    {
        value = 10;
        print(value);
        PlayerPrefs.SetInt("value", value);
        PlayerPrefs.Save();

        print(PlayerPrefs.GetInt("value"));

        // Verifico se aquela chave de acesso existe no jogo
        print(PlayerPrefs.HasKey("value"));
    }
}
