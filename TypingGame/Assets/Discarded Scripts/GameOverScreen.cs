using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameOverScreen : MonoBehaviour
{
    public Text scoreText;

    public void Setup(int score)
    {
        //gameObject.SetAcite(true);
        scoreText.text = score.ToString();
    }

    public void ReplayButton()
    {
        SceneManager.LoadScene("GameScean");     // Załadowanie wyznaczonej sceny: Powrót do rozgrywki
    }

    public void ExitButton()
    {
        SceneManager.LoadScene("MainMenuScean");     // Załadowanie wyznaczonej sceny: Powrót do menu
    }
}
