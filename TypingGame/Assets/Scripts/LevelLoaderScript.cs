using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;  // Moduł do obsługi scen

public class LevelLoaderScript : MonoBehaviour
{
    public Animator transition;    // Podpięcie pod animację prześcia (Crossfade_Start / Crossfade_End)
    public float waitForTransition = 1.0f;

    // Update is called once per frame
    void Update()
    {
        // Po wciśnięciu przycisku ma zostać odpalony skrypt przechodzenia między poziomami:
        if(Input.GetMouseButtonDown(0))
        {
            LoadGameScean("GameScean");
        }
    }

    public void LoadGameScean(string sceneName)
    {
        // SceneManager.LoadScene(1);  // Wczyta scene oznaczoną idnexem 1 z Buildu
        // SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1); // Będzie przechodzić po kolejnych indeksach scen od sceny, z której zaczeliśmy i odpali ja błyskawicznie.

        // Funkcja załaduje następną scenę od sceny startowej - poprawić na przechodzenie między konkretnymi scenami.
        StartCoroutine(LoadScean(sceneName));
    }

    IEnumerator LoadScean(string sceneName)
    {
        // Animacja:
        transition.SetTrigger("StartTrigger");

        // Wstrzymanie:
        yield return new WaitForSeconds(waitForTransition);

        // Przejście do sceany:
        SceneManager.LoadScene(sceneName);
    }
}
