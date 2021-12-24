using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WordDisplay : MonoBehaviour
{
    public Text text;   // Referencja do obiektu wypisujacego tekst
    public float fallSpeed = 1.0f;      // Szybkość spadania obiektów

    public Color orange = new Color(1.0f, 0.6136808f, 0.0f);

    //public GameManager gameManager;

    // ZWIĘKSZAĆ PRĘDKOŚĆ W RAZ Z POSTĘPAMI np. co 100 punktów większenie prędkości o 0.2f

    public void SetWord (string word)
    {
        text.text = word;
    }

    public void RemoveLetter()
    {
        // Zamienić to później na funkcję zamiany koloru tekstu przy wpisywaniu
        // jeśli całe słowo zmini kolor to "odpada z ekranu" (spada jakby dostała kopniaka)
        
        text.text = text.text.Remove(0, 1);     // Usunięcie tylko jednej litery
        text.color = orange;
    }

    public void RemoveWord()
    {
        Destroy(gameObject);    // Zniszczenie obiektu gry
    }

    public void FallWord()
    {
        transform.Translate(0f, -fallSpeed * Time.deltaTime, 0.0f);
    }

    private void Update()
    {
        FallWord();
    }
}
