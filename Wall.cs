using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
    Zadanie 4
    Wykorzystując możliwość dodawania obiektów czasie wykonania (zobacz: https://docs.unity3d.com/Manual/InstantiatingPrefabs.html) stórz nową scenę a w niej:

    * dodaj płaszczyznę o wymiarach 10x10
    * w momencie uruchomienia trybu play generuj 10 obiektów typu Cube,
      które umieszczaj losowo na płaszczyźnie
      ale tak, żeby w danym miejscu nie znalazł się więcej niż jeden obiekt. 
*/

public class Wall : MonoBehaviour
{
    public GameObject block;
    public int width = 10;
    public int height = 4;
    public int number_of_objects_to_spawn = 10;

    private int x = 10;
    private int y = 1;
    private int z = 10;

    void Start()
    {
        List<Vector3> listOfCoordinates = GenerateCoordinates(number_of_objects_to_spawn);


        for (int i = 0; i < listOfCoordinates.Count; i++)
        {
            RandomPlacement(listOfCoordinates[i]);
        }
    }

    public List<Vector3> GenerateCoordinates(int numberOfCoordinatesToGenerate)
    {
        List<Vector3> randomCoordinatesList = new List<Vector3>();

        for (int i = 0; i < numberOfCoordinatesToGenerate; i++)
        {
            Vector3 randomPosition = new Vector3(Random.Range(-x, x), Random.Range(y, y), Random.Range(-z, z));
            if(!randomCoordinatesList.Contains(randomPosition))
            {
                randomCoordinatesList.Add(randomPosition);
            }
        }

        return randomCoordinatesList;
    }


    void RandomPlacement(Vector3 randomCoordinates)
    {
        GameObject block_clone = Instantiate(block, randomCoordinates, Quaternion.identity);
    }
}
