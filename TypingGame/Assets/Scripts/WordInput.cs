using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WordInput : MonoBehaviour
{
    public WardMenager wardMenager;     // Nawiązanie do skryptu WordMenagera

    public void TypedCharacter()
    {
        // Input.inputString - Zwrawca klawisze wciśnięte na klawiaturze

        foreach (char letter in Input.inputString)
        {
            wardMenager.TypeLetter(letter);
            Debug.Log("Input: " + letter);
        }
    }

    private void Update()
    {
        TypedCharacter();

        if (GameManager.gamePauseCheck == true)
        {

        }
    }
}
