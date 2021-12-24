using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class OnClickEvents : MonoBehaviour
{
    public void StartGame()
    {
        Debug.Log("Zdarzenie: StartGame");
    }

    public void ExitToMainMenu()
    {
        Debug.Log("Zdarzenie: ExitToMainMenu");
    }

    public void PauseGame()
    {
        Debug.Log("Zdarzenie: PauseGame");
    }

    public void ReplayGame()
    {
        Debug.Log("Zdarzenie: ReplayGame");
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void QuitGame()
    {
        Debug.Log("Zdarzenie: QuitGame");
        Application.Quit();
    }


}
