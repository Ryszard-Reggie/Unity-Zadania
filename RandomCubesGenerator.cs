using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

/* 
    Zadanie 1
    Wykorzystaj kod z listingu 1 i zmodyfikuj go tak, aby możliwe było:

    * określenie w inspektorze ilości obiektów losowych do wegenerowania,
    * pozycje x oraz z były pobierane z platformy, do której skrypt jest dołączany (zakładamy, że tak będzie)
    * dodaj do swojego projektu nowe materiały, tak, aby było 5 różnych do wykorzystania i przydzielaj losowo materiał w trakcie tworzenia nowego obiektu.
*/

public class RandomCubesGenerator : MonoBehaviour
{
    public GameObject platform;
    // Domyślna pozycja platformy:
    public float platform_x_position;
    private float platform_y_position = 1.0f;
    public float platform_z_position;

    public float platform_x_scale;
    private float platform_y_scale = 1.0f;
    public float platform_z_scale;

    // Obiekt do wygenerowania:
    public GameObject klocek;

    public int ilosc_obiektow_do_wygenerowania;

    private Vector3 center;
    private Vector3 size;

    // Lista zawiarająca losowe pozycje dla klocków:
    List<Vector3> pozycje = new List<Vector3>();

    // Lista materiałów do przypisania:
    public Material[] materialy = new Material[5];

    // Odstęp czasu między ręderowaniem obiektu:
    public float delay = 0.3f;
    int objectCounter = 0;
    
    void Start()
    {
        // Ustawienie pozycji platformy:
        platform.transform.position = new Vector3(platform_x_position, platform_y_position, platform_z_position);
        
        // Ustawienie skali/wielkości platformy (platforma jest 10x większa od domyślnej kostki):
        platform.transform.localScale = new Vector3(platform_x_scale, platform_y_scale, platform_z_scale);

        // Punkt centralny spawnu - lokalna pozycja platformy:
        center = platform.transform.localPosition;
        
        // Rozmiar spawnu - scala pratformy * 10:
        size = new Vector3(platform_x_scale * 10, 1, platform_z_scale * 10);

        // Dla podanej liczby obiektów do wygenerowania ...
        for (int i = 0; i < this.ilosc_obiektow_do_wygenerowania; i++)
        {
            // dodaj do listy pozycji nową pozycję opartą na losowych wartościach bazujących na skali/rozmiarze platformy: 
            this.pozycje.Add(center + new Vector3(UnityEngine.Random.Range((-size.x) / 2, (size.x) / 2), 5, UnityEngine.Random.Range((-size.z) / 2, (size.z) / 2)));
        }
        
        // Dla każdego koordynatu w liście 'pozycje' ...
        foreach (Vector3 koordynaty in pozycje)
        {
            // wypisz przypisane koordynaty:
            Debug.Log("Kordynaty: " + koordynaty);
        }
        // Start coroutine:
        StartCoroutine(GenerujObiekt());
    }

    void Update()
    {

    }

    IEnumerator GenerujObiekt()
    {
        Debug.Log("wywołano coroutine");

        // Dla każdej pozycji w liście `pozycje` ...
        foreach (Vector3 pos in pozycje)
        {
            // zainicjuj obiekt `klocek` na pozycji `pozycje[objectCounter]`:
            GameObject obiekt = Instantiate(this.klocek, this.pozycje.ElementAt(this.objectCounter++), Quaternion.identity);
            
            // Nadanie obiektowi losowego materiały z tablicy materiałów:
            obiekt.GetComponent<MeshRenderer>().material = materialy[UnityEngine.Random.Range(0, materialy.Length)];
            
            // Przeczekanie określonej ilości czasu aż funkja zostanie wywołana ponowanie (koślawe tłumaczenie...):
            yield return new WaitForSeconds(this.delay);
        }
        // Zatrzymanie coroutine:
        StopCoroutine(GenerujObiekt());
    }

    private void OnDrawGizmosSelected()
    {
        Gizmos.color = new Color(0, 1, 0, 0.3f);
        Gizmos.DrawCube(center, size);
    }
}
