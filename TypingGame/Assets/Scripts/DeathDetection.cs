using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathDetection : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        /*
            Funkcja wywoływana w momencie kiedy obiekt, do którego jest przypisany skrypt
            wejdzie w interakcję z obiektem, który ma ColLider 2D i zaznaczone ustawienie `Is Trigger`.
        */

        Debug.Log("DeathDetection: Ten grobowiec będzie waszym grobowcem! ~ Nikosis");

        // Znalezienie obiektu `GameManager` i wywołanie z niego funkcji `GameOver()`
        FindObjectOfType<GameManager>().GameOver();
    }
}
