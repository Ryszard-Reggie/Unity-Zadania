using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WordGenerator : MonoBehaviour
{
    // ZMIENIĆ NA POBIERANIE SŁÓW Z PLIKI
    // Lista ok. 100 słów w języku polskim:
    private static string[] wordList = { "substancja", "łatwowierny", "połowa", "pikantny", "wątpliwy", "nieproduktywny", "zatruć", "dziewczyny", "pomysł", "wścibski", "solidny", "ambitny", "filiżanka", "ptactwo", "używany", "kiełkować", "deficytowy", "opuszczony", "wojujący", "bezgraniczny", "cichy", "magenta", "zazdrosny", "uroczy", "sławny", "dziwaczny", "niebo", "skok", "wadliwy", "straszny", "wstrzykiwać", "grzech", "udawany", "łyk", "mdły", "pieluszka", "mglisty", "płodny", "początek", "dostępny", "akustyczny", "kolejny", "cichy", "kreda", "gwizdać", "możliwy", "rana", "zwinny", "postojowy", "konto", "rozżarzony", "miękki", "najszybszy", "raport", "przedstawiciel", "łokieć", "kije", "bezinteresowny", "lekki", "stopień", "otaczać", "oszołomiony", "nieznany", "zdecydować", "histeryczny", "krwawy", "nędzny", "wesoły", "romantyk", "zakurzony", "fajnie", "szczypta", "rodzaj", "płyn", "usunąć", "dostosowanie", "niemożliwy", "chętny", "przytulanki", "oceaniczny", "trzeci", "dziwaczny", "mecz", "głupkowaty", "wykryć", "rura", "biegać", "szturchać", "moc", "automatyczny", "drink", "poziom", "olej", "ugryzienie", "zamierzać", "wyprostowany", };

    public static string GetRandomWord()
    {
        int randomIndex = Random.Range(0, wordList.Length);
        string randomWord = wordList[randomIndex];

        return randomWord;
    }
}
