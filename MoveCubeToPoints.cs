using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
    Zadanie 2

    Stwórz nową scenę. Dodaj do niej obiekt typu Cube o wymiarach (2, 1, 1).
    
    Napisz skrypt, z publicznym polem speed (float),
    który będzie przemieszczał obiekt wzdłóż osi x o 10 jednostek (metrów)
    i w momencie wykonania takiego przesunięcia będzie wykonywał ruch powrotny.
 */

public class MoveCubeToPoints : MonoBehaviour
    public GameObject[] check_points;   // Punkt kontorly, do którego dąży obiekt
    int current_point = 0;              // Numer punktu, do którego dąży obiekt. W zależności od ilości ustawionych puntów liczba się zmienia.
    public float speed;
    float CheckPointRadius = 1;

    // Rigidbody rb;

    void Start()
    {
        // rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        if(Vector3.Distance(check_points[current_point].transform.position, transform.position) < CheckPointRadius)
        {
            current_point = current_point + 1;

            //Jeżeli wartość punktów przekroczy/będzie równa długości tablicy `check_points` ...
            if (current_point >= check_points.Length)
            {
                // to wróć do punktu 0 (punkt startowy).
                current_point = 0;
            }
        }

        // Zmiana pozycji obiektu rozłożona w czasie (`Time.deltaTime`) o określonej prędkości (`speed`) między ustawionymi punktami kontrolnymi

        transform.position = Vector3.MoveTowards(transform.position, check_points[current_point].transform.position, Time.deltaTime * speed);

        Debug.Log(transform.position);  // Wyświetlenie na konsoli aktualnej pozycji obiektu, do którego przypiety jest TEN komponent (script).
    }
    void FixedUpdate()
    {

    }
}
