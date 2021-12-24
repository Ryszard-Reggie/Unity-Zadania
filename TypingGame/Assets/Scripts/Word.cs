using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Word
{
    public string word;         // 
    private int typeIndex;      // 

    private WordDisplay display;

    // Konstruktor:
    public Word(string _word, WordDisplay _display)
    {
        word = _word;
        typeIndex = 0;

        display = _display;
        display.SetWord(word);
    }

    public char GetNextLetter()
    {
        return word[typeIndex];
    }

    public void TypeLetter()
    {
        typeIndex++;
        display.RemoveLetter(); // ZAMIENIĆ NA ZAMIANĘ KOLORÓW
    }

    public bool WordTyped()
    {
        bool wordTyped;

        if (typeIndex >= word.Length)
        {
            wordTyped = true;
        }
        else
        {
            wordTyped = false;
        }

        if(wordTyped == true)
        {
            display.RemoveWord(); // POŁĄCZYĆ Z "ANIMACJA" KOPNIĘTEGO SŁOWA
        }

        return wordTyped;
    }
}
