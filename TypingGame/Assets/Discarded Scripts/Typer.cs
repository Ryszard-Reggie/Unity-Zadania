using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Typer : MonoBehaviour
{
    // Zbiór słów do wyświetlenia:
    public WordBank wordBank = null;   
    
    public Text wordOutput = null;

    private string remainingWord = string.Empty;    // Następne słowo do wpisania
    //private string currentWord = string.Empty;      // Aktualne słowo do wpisania
    private string currentWord = "kraków";      // Aktualne słowo do wpisania | Wszystkie słowa powinny być z małej litery

    // Rzeczy startwoe:
    void Start()
    {
        SetCurrentWord();
    }

    // Rzeczy aktualizowane co klatkę:
    void Update()
    {
        CheckInput();
    }

    void SetCurrentWord()
    {
        currentWord = wordBank.GetWord();
        SetRemainingWord(currentWord);
    }

    void SetRemainingWord(string word)
    {
        remainingWord = word;
        wordOutput.text = remainingWord;
    }

    void CheckInput()
    {
        // Jeżeli został wciśnięty choć jeden klawisz ...
        if(Input.anyKeyDown)
        {
            string keyPressd = Input.inputString;           // Zmienna przechowująca wartość z wciśniętego klawisza
            Debug.Log("Wciśnięty klawisz: " + keyPressd);   

            // Jeżeli został wciśnięty tylko jeden klawisz ...
            if(keyPressd.Length == 1)
            {
                // wprowadź wartość wciśniętego klawisza.
                EnterLetter(keyPressd);
            }
        }
    }

    void EnterLetter(string letter)
    {
        if(IsCorretLetter(letter))
        {
            RemoveLetter();

            if(IsWordComplete())
            {
                SetCurrentWord();
            }
        }
    }

    bool IsCorretLetter(string letter)
    {
        return remainingWord.IndexOf(letter) == 0;
    }

    void RemoveLetter()
    {
        string word = remainingWord.Remove(0, 1);
        SetRemainingWord(word);
    }

    bool IsWordComplete()
    {
        return remainingWord.Length == 0;
    }
}
