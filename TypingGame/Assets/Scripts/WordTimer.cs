using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WordTimer : MonoBehaviour
{
    public WardMenager wordManager;

    public float wordDelay = 1.0f;      // Opóźnienie spawnu nowego słowa
    private float nextWordTime = 0.0f;

    public void WordSpawnDelay()
    {
        if (Time.time >= nextWordTime)
        {
            wordManager.AddWord();
            nextWordTime = Time.time + wordDelay;

            wordDelay *= 1.0f;                     // Przyśpieszenie spawnu
        }
    }

    private void Update()
    {
        WordSpawnDelay();
    }
}
