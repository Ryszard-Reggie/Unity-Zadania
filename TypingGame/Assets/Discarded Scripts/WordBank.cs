using System.Collections;
using System.Linq;
using System.Collections.Generic;
using UnityEngine;

public class WordBank : MonoBehaviour
{
    private List<string> originalWords = new List<string>()
    {
        "Warta", "Amestyt", "Towarzysz"
    };

    private List<string> workingWord = new List<string>();

    private void Awake()
    {
        workingWord.AddRange(originalWords);
        Shuffle(workingWord);
        ConvertToLower(workingWord);
    }

    private void Shuffle(List<string> list)
    {
        for (int index = 0; index < list.Count; index++)
        {
            int random = Random.Range(index, list.Count);
            string temporary = list[index];

            list[index] = list[random];
            list[random] = temporary;
        }
    }

    private void ConvertToLower(List<string> list)
    {
        for (int index = 0; index < list.Count; index++)
        {
            list[index] = list[index].ToLower();
        }
    }

    public string GetWord()
    {
        string newWord = string.Empty;

        if (workingWord.Count != 0)
        {
            newWord = workingWord.Last();
            workingWord.Remove(newWord);
        }

        return newWord;
    }
}
