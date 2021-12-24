using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WardMenager : MonoBehaviour
{
    public List<Word> drawnWords;

    public WordSpawner wordSpawner;

    AudioManager audioManager;

    private bool hasActiveWord;     // Czy słowo jest aktywne?
    private Word activeWord;        // Słowo, które ma być aktualnie wpisywane

    //private void Start()
    //{
    //    AddWord();
    //    AddWord();
    //    AddWord();
    //}

    private void Start()
    {
        audioManager = GameObject.FindGameObjectWithTag("AudioManager").GetComponent<AudioManager>();
    }

    public void AddWord()
    {    
        Word drawnWord = new Word(WordGenerator.GetRandomWord(), wordSpawner.SpawnWord());
        Debug.Log("Wylosowane słowo: " + drawnWord.word);

        drawnWords.Add(drawnWord);
    }

    public void TypeLetter (char letter)
    {
        if(hasActiveWord == true)
        {
            if(activeWord.GetNextLetter() == letter)
            {
                audioManager.PlayAudioLetterRemove(AudioManager.Sounds.LetterRemove);
                activeWord.TypeLetter();    // Usunięcie litery ze słowa
            }
        }
        else
        {
            foreach(Word word in drawnWords)
            {
                if (word.GetNextLetter() == letter)
                {
                    activeWord = word;
                    hasActiveWord = true;
                    word.TypeLetter();
                    break;
                }
            }
        }

        if (hasActiveWord & activeWord.WordTyped())
        {
            hasActiveWord = false;
            drawnWords.Remove(activeWord);

            Score.instance.AddPoints();
        }
    }
}
