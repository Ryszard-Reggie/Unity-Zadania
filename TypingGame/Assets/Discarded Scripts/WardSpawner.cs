using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WardSpawner : MonoBehaviour
{
    public GameObject wordPrefab;

    public WordDisplay SpawnWord()
    {
        GameObject wordObject = Instantiate(wordPrefab);

        WordDisplay wordDisplay = wordObject.GetComponent<WordDisplay>();

        return wordDisplay;
    }
}
