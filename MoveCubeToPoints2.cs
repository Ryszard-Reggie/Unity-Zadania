using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
    Zadanie 3

    Rozbuduj skrypt z zadania 2 (ale zapisz wszystko w nowym skrypcie),
    tak aby obiekt poruszał się 'po kwadracie' o boku 10 jednostek
    i docierając do wierzchołka wykonywał obrót o 90 stopni w kierunku kolejnego wierzchołka.
 */

public class MoveCubeToPoints2 : MonoBehaviour
{
    public Vector3 startObjectPosition = new Vector3();
    public float speed;
    public Transform[] Positions;

    private int NextPositionIndex;

    Transform NextPosition;

    void Start()
    {
        transform.position = startObjectPosition;
        NextPosition = Positions[0];   
    }
    void Update()
    {
        MoveGameObjcet();
        RotateGameObject();
    }

    void FixedUpdate()
    {
        
    }

    void MoveGameObjcet()
    {

        // Jeżeli pozycja obiektu jest równa pozycji następnego obiektu ...   
        if(transform.position == NextPosition.position)
        {
            /*
                to dodaj kolejną wartość do `NextPositionIndex`.
                oraz
                jeżeli `NextPositionIndex` jest większe równe długości tablicy `Positions` ...
            */
            NextPositionIndex++;
            if(NextPositionIndex >= Positions.Length)
            {
                // wyzeruj `NextPositionIndex` (powrót do punktu pierwszego).
                NextPositionIndex = 0;
            }

            // Ustaw pozycję `NextPosition` jako pozycje z `Positions[NextPositionIndex]`,
            NextPosition = Positions[NextPositionIndex];
        }
        // Inaczej ...
        else
        {
            // Przesuń obiekt na współrzędne od obecnej pozycji `transform.position` do pozycji nastepnego punktu `NextPosition.position`.
            transform.position = Vector3.MoveTowards(transform.position, NextPosition.position, Time.deltaTime * speed);
            //Quaternion toRotation = Quaternion.LookRotation(NextPosition.forward, Vector3.up);
            
        }
    }
    void RotateGameObject()
    {
        if(transform.position == NextPosition.position)
        {
            transform.Rotate(0, 90, 0, Space.Self);
        }
    }
}
