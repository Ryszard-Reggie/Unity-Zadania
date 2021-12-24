using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    private bool gameOverCheck = false;     // Czy gra została przegrana?
    public static bool gamePauseCheck = false;    // Czy gra została wstrzymana?
    public GameObject gameOverPanel;        // Miejsce do wstawienia obiektu gry: GameOverPanel
    public GameObject pauseMenuPanel;       // Miejsce do wstawienia obiektu gry: PauseMenuPanel

    private void Start()
    {
        Time.timeScale = 1.0f;         // Normalne funkcjonowanie czas w grze
        gamePauseCheck = false;
        gameOverCheck = false;
    }

    private void Update()
    {
        if (gameOverCheck || gamePauseCheck == true)
        {
            Time.timeScale = 0.0f;     // Poraża: Wstrzymanie funkcjonowania czasu w grze
        }

        //if (gamePauseCheck == true)
        //{
        //    Time.timeScale = 0.0f;     // Pauza: Wstrzymanie funkcjonowania czasu w grze
        //}

        //if (Input.GetKeyDown(KeyCode.Escape))
        //{
        //    if (gamePauseCheck == true)
        //    {
        //        ResumeGame();
        //    }
        //    else if (gamePauseCheck == false)
        //    {
        //        PauseGame();
        //    }
        //}
    }

    public void StartGame()
    {
        Debug.Log("GameManager: StartGame");

        SceneManager.LoadScene("GameScene");
    }

    public void PauseGame()
    {
        Debug.Log("GameManager: PauseGame");

        // Jeżeli 
        if (gamePauseCheck == false)
        {
            Time.timeScale = 0.0f;
            pauseMenuPanel.SetActive(true);
            gamePauseCheck = true;
        }
    }

    public void ResumeGame()
    {
        Debug.Log("GameManager: ReasumeGame");

        if (gamePauseCheck == true)
        {
            Time.timeScale = 1.0f;
            pauseMenuPanel.SetActive(false);
            gamePauseCheck = false;
        }
    }

    public void GameOver()
    {
        Debug.Log("GameManager: GameOver");

        if (gameOverCheck == false)
        {
            gameOverCheck = true;
            Time.timeScale = 0.0f;
            gameOverPanel.SetActive(true);      // Aktywowanie panelu: GameOverPanel

            DestroyAllWords("TextToBeTyped");
        }
    }

    public void DestroyAllWords(string tag)
    {
        /*
            Funkcja przeznaczona do zniszczenia wszystkich obiektów gry
            z podanym tagiem.
        */

        GameObject[] gameObjects = GameObject.FindGameObjectsWithTag(tag);  // Lista obiektów gry z podanym tagiem

        Debug.Log("GameManager-DestroyAllWords: Chciałbym żebyś rozwiązał za mnie pewien problem. ~ Marnypopis");
        Debug.Log("GameManager-DestroyAllWords: Nie ma sprawy szefie. Kogo zabić? ~ Nikosis");

        foreach (GameObject target in gameObjects)
        {
            Destroy(target);    // Zniszczenie celu
        }
    }

    public void ExitToMainMenu()
    {
        Time.timeScale = 1.0f;

        Debug.Log("GameManager: ExitToMainMenu");

        SceneManager.LoadScene("MainMenuScene");
    }

    public void ReplayGame()
    {
        // SceneManager.GetActiveScene().name - zwraca nazwę aktualnie aktywnej sceny
        // SceneManager.LoadScene() - wczytuje wskazaną scenę
        Time.timeScale = 1.0f;

        Debug.Log("GameManager: ReplayGame");

        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void QuitGame()
    {
        Time.timeScale = 1.0f;

        Debug.Log("GameManager: QuitGame");

        Application.Quit();
    }
}
